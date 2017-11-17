using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // 描画処理
using System.IO;                // 入出力
using System.Collections;       // 並び替え(クラスの追加)

namespace AFIM
{
    //=== フォーム内処理 ===//
    public partial class Landmarker : Form
    {
        //--- 変数宣言 ---//
        // To Main Form
        private PictureBox pb1;
        private Bitmap bmp;
        private Bitmap _bmp;
        // This Form
        private int point_counter;
        private int current_counter;
        private int erase_counter;
        private Point[] io_points; // 点(x,y)の配列宣言
        private int[] stack_points;
        private bool RowsRemovedFlag;
        private int pts_property;   // プロパティの行数
        private int read_max_point;      // 読み込みの最大点数
        private string FormText = "";
        private int MAX_MESH;
        private int StartLeftEYEBLOW, EndLeftEYEBLOW;
        private int StartRightEYEBLOW, EndRightEYEBLOW;
        private int StartLeftEYE, EndLeftEYE; 
        private int StartRightEYE, EndRightEYE;
        private int StartLeftNOSE, EndLeftNOSE;
        private int StartRightNOSE, EndRightNOSE;
        private int StartInMouse, EndInMouse;
        private int StartOutMouse, EndOutMouse;
        private int StartFacilLine, EndFacilLine;

        //--- 画面表示の関係 ---//
        enum SelectionMode
        {
            None,   // 選択されている
            One,    // 一端が選択されている
            Two     // 両端が選択されている
        };
        //SelectionMode CurSelectionMode; // 選択モードの状態
        //Rectangle CurSelection;         // 現在の選択範囲

        Color PointsColor1, PointsColor2, PointsColor3, PointsColor4;           // 点の色
        private bool FlagOfColor1, FlagOfColor2, FlagOfColor3, FlagOfColor4;    // (点の)色のフラグ

        String CurFileName = ""; // 現在のファイル名
        const string FileFilter = "TEXT File (*.txt, *.pts)|*.txt;*.pts|CSV File (*.csv)|*.csv|All file (*.*)|*.*";

        String CurImageName = ""; // 現在のファイル名
        const string ImageFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png|All file (*.*)|*.*";

        //--- 読み込み時 ---//
        public Landmarker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = ((MainSystem)this.Owner).pb.Image;
            FlagOfColor1 = FlagOfColor2 = false;
            point_counter = 0; // 点の数
            current_counter = 0; // 現在の数
            erase_counter = 0; // 削除した点の数

            RowsRemovedFlag = true;
            FormText = this.Text;

            MAX_MESH = 204;
            
            StartLeftEYEBLOW = 0;
            EndLeftEYEBLOW = 12;
            StartRightEYEBLOW = 13;
            EndRightEYEBLOW = 25;
            StartLeftEYE = 27;
            EndLeftEYE = 34;
            StartRightEYE = 36;
            EndRightEYE = 43;
            StartLeftNOSE = 45;
            EndLeftNOSE = 49;
            StartRightNOSE = 59;
            EndRightNOSE = 63;
            StartOutMouse = 66;
            EndOutMouse = 79;
            StartInMouse = 80;
            EndInMouse = 91;
            StartFacilLine = 92;
            EndFacilLine = 113;
        }

        //--- マウスダウン ---//
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // ドラッグ移動
            if (e.Button == MouseButtons.Right)
            {
                DragStartX = e.X;
                DragStartY = e.Y;
                FlagOfHold = true;
            }
            else if (e.Button == MouseButtons.Left && FlagOfHold)
            {
                dataGridView.ClearSelection(); // ドラック移動不可(選択解除)
                r_startX = e.X;
                r_startY = e.Y;
                FlagOfDoubleHold = true;
            }
            // 特徴点の取得
            else if (e.Button == MouseButtons.Left)
            {
                // 選択解除
                dataGridView.ClearSelection();

                // 行の作成
                DataGridViewRow rows = new DataGridViewRow();
                dataGridView.Rows.Add(rows);    // 行の追加
                dataGridView.Rows[current_counter].Selected = true; // 選択
                dataGridView.FirstDisplayedScrollingRowIndex = current_counter; // 行の自動スクロール

                // 一時保存
                DataGridViewRow tmp_rows = new DataGridViewRow();
                dgv_tmp.Rows.Add(tmp_rows);

                if (erase_counter > 0)
                {
                    erase_counter--;
                    dataGridView[0, current_counter].Value = stack_points[erase_counter];
                    // 次の特徴点表示(削除箇所)
                    if (erase_counter == 0)
                    {
                        textBoxNFP.Text = (point_counter + 1).ToString();
                    }
                    else
                    {
                        textBoxNFP.Text = stack_points[erase_counter - 1].ToString();
                    }
                }
                else
                {
                    dataGridView[0, current_counter].Value = point_counter;
                    textBoxNFP.Text = (point_counter + 1).ToString();
                    dgv_tmp[0, current_counter].Value = point_counter; // for Keep    
                    point_counter++; // 全体の点の数(行数)
                }
                // 値をセット
                dataGridView[1, current_counter].Value = e.X;
                dataGridView[2, current_counter].Value = e.Y;

                current_counter++; // 編集後の点の数(行数)

                // 一時保存の更新
                for (int i = 0; i < current_counter; i++)
                {
                    dgv_tmp[0, i].Value = dataGridView[0, i].Value;
                }
                this.Refresh();
            }
            dataGridView.Update();
        }

        //--- Pointに値を格納 ---//
        private void SetPoints()
        {
            // 配列Pointのサイズ変更
            Array.Resize<Point>(ref io_points, current_counter + 1);
            for (int i = 0; i < current_counter; i++)
            {
                io_points[i].X = (int)dataGridView[1, i].Value;
                io_points[i].Y = (int)dataGridView[2, i].Value;
            }
        }

        //--- セルを検証中 ---//
        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // 文字列が数字であるか判定
            if (Validation.IsNumeric(e.FormattedValue.ToString()))
            {
                // 数値の時
                int value = int.Parse(e.FormattedValue.ToString());
                if (dgv.Columns[e.ColumnIndex].Name == "pointX")
                {
                    if (value < 0 || value >= pb1.Image.Width)
                    {
                        dgv.CancelEdit(); //入力した値をキャンセルして元に戻す
                        e.Cancel = true; //キャンセルする
                    }
                }
                else
                {
                    if (value < 0 || value >= pb1.Image.Height)
                    {
                        dgv.CancelEdit(); //入力した値をキャンセルして元に戻す
                        e.Cancel = true; //キャンセルする
                    }
                }
            }
            else
            {
                dgv.CancelEdit(); //入力した値をキャンセルして元に戻す
                e.Cancel = true; //キャンセルする
            }
        }

        //--- ソート後の処理 ---//
        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < current_counter; i++)
            {
                dgv_tmp[0, i].Value = int.Parse(dataGridView[0, i].Value.ToString());
            }
            this.Refresh();
        }

        //--- 行を削除した時 ---//
        private void dataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            current_counter--;

            if (RowsRemovedFlag == true)
            {
                Array.Resize<int>(ref stack_points, erase_counter + 1);
                stack_points[erase_counter] = (int)dgv_tmp[0, e.RowIndex].Value;
                textBoxNFP.Text = dgv_tmp[0, e.RowIndex].Value.ToString();
                erase_counter++;

                // 一時保存の更新
                for (int i = 0; i < current_counter; i++)
                {
                    dgv_tmp[0, i].Value = dataGridView[0, i].Value;
                }
                this.Refresh();
            }
        }
        //--- ペイント処理：PictureBox1 ---//
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int radius = (int)nudPointSize.Value; // 半径
            Graphics g = e.Graphics;

            // 点の表示
            Pen pen1 = new Pen(Color.Red, radius);
            Pen pen2 = new Pen(Color.Blue, radius);
            Pen pen3 = new Pen(Color.Lime, radius);
            Pen pen4 = new Pen(Color.Purple, radius);

            if (FlagOfColor1)
                pen1 = new Pen(PointsColor1, radius);
            if (FlagOfColor2)
                pen2 = new Pen(PointsColor2, radius);
            if (FlagOfColor3)
                pen3 = new Pen(PointsColor3, radius);
            if (FlagOfColor4)
                pen4 = new Pen(PointsColor4, radius);

            Font myFont = new Font("Times New Roman", 10);
            LinearGradientBrush myBrush = new
               LinearGradientBrush(ClientRectangle,
               Color.White, Color.White, LinearGradientMode.Horizontal);

            for (int i = 0; i < current_counter; i++)
            {
                int pn, px, py;
                pn = int.Parse(dataGridView[0, i].Value.ToString());
                px = int.Parse(dataGridView[1, i].Value.ToString());
                py = int.Parse(dataGridView[2, i].Value.ToString());

                // 点の描画(楕円)
                if (ToolPoint.Checked)
                {
                    if (dataGridView.Rows[i].Selected == true)
                    {

                        g.DrawEllipse(pen3, px, py, radius, radius);
                    }
                    else if (0 == i % 2)
                        g.DrawEllipse(pen1, px, py, radius, radius);
                    else
                        g.DrawEllipse(pen2, px, py, radius, radius);
                }
                // 番号を表示
                if (ToolPointNumber.Checked)
                    g.DrawString(pn.ToString(), myFont, myBrush, px + 2, py + 2);
            }
            // メッシュ表示
            if (ToolMesh.Checked && ToolMesh.Enabled)
            {
                for (int i = 0; i < MAX_MESH; i++)
                {
                    g.DrawLine(pen4, Assosiation[i].px[0], Assosiation[i].py[0], Assosiation[i].px[1], Assosiation[i].py[1]);
                    g.DrawLine(pen4, Assosiation[i].px[1], Assosiation[i].py[1], Assosiation[i].px[2], Assosiation[i].py[2]);
                    g.DrawLine(pen4, Assosiation[i].px[2], Assosiation[i].py[2], Assosiation[i].px[0], Assosiation[i].py[0]);
                }
            }
            // 顔パーツの表示
            if (ToolEyeBrows.Checked)
            {
                //左眉
                for (int i = StartLeftEYEBLOW; i < EndLeftEYEBLOW; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                g.DrawLine(pen4, io_points[StartLeftEYEBLOW].X, io_points[StartLeftEYEBLOW].Y, io_points[EndLeftEYEBLOW].X, io_points[EndLeftEYEBLOW].Y);
                //右眉
                for (int i = StartRightEYEBLOW; i < EndRightEYEBLOW; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                g.DrawLine(pen4, io_points[StartRightEYEBLOW].X, io_points[StartRightEYEBLOW].Y, io_points[EndRightEYEBLOW].X, io_points[EndRightEYEBLOW].Y);
            }
            if (ToolEyes.Checked)
            {
                //左
                for (int i = StartLeftEYE; i < EndLeftEYE; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                g.DrawLine(pen4, io_points[StartLeftEYE].X, io_points[StartLeftEYE].Y, io_points[EndLeftEYE].X, io_points[EndLeftEYE].Y);
                //右
                for (int i = StartRightEYE; i < EndRightEYE; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                g.DrawLine(pen4, io_points[StartRightEYE].X, io_points[StartRightEYE].Y, io_points[EndRightEYE].X, io_points[EndRightEYE].Y);
            }
            if (ToolNose.Checked)
            {
                //左
                for (int i = StartLeftNOSE; i < EndLeftNOSE; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                //右
                for (int i = StartRightNOSE; i < EndRightNOSE; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
            }
            if (ToolMouth.Checked)
            {
                for (int i = StartInMouse; i < EndInMouse; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                g.DrawLine(pen4, io_points[StartInMouse].X, io_points[StartInMouse].Y, io_points[EndInMouse].X, io_points[EndInMouse].Y);
                for (int i = StartOutMouse; i < EndOutMouse; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                g.DrawLine(pen4, io_points[StartOutMouse].X, io_points[StartOutMouse].Y, io_points[EndOutMouse].X, io_points[EndOutMouse].Y);
            }
            if (ToolLine.Checked)
            {
                for (int i = StartFacilLine; i < EndFacilLine; i++)
                {
                    g.DrawLine(pen4, io_points[i].X, io_points[i].Y, io_points[i + 1].X, io_points[i + 1].Y);
                }
                g.DrawLine(pen4, io_points[StartFacilLine].X, io_points[StartFacilLine].Y, io_points[EndFacilLine].X, io_points[EndFacilLine].Y);
            }
            // 
            if (FlagOfDoubleHold)
            {
                g.DrawRectangle(new Pen(Color.Lime), r_startX, r_startY, r_endX - r_startX, r_endY - r_startY);
            }
        }

        private void ToolBtnSaveImg_Click(object sender, EventArgs e)
        {
            SaveImgDialog.FileName = CurImageName;
            SaveImgDialog.Filter = ImageFilter;
            if (SaveImgDialog.ShowDialog(this) == DialogResult.OK)
            {
                CurImageName = SaveImgDialog.FileName; // 名前入力
                if (_bmp == null)
                    return;
                if (CurImageName.Length < 1) // 名前入力なし
                    ToolBtnSaveImg_Click(sender, e);
                else
                    _bmp.Save(CurImageName); // 保存
            }
        }
        //--- 点の初期化 ---//
        private void btnClear_Click(object sender, EventArgs e)
        {
            RowsRemovedFlag = false; // 行の削除判定1
            for (int i = current_counter - 1; i >= 0; i--)
            {
                dataGridView.Rows.RemoveAt(i);
            }
            RowsRemovedFlag = true; // 行の削除判定2
            current_counter = 0;
            point_counter = 0;
            erase_counter = 0;
            textBoxNFP.Text = "1";
            Array.Resize<int>(ref stack_points, erase_counter);
            this.Refresh();
        }

        //--- 特徴点の読み込み ---//
        private void btnRead_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = CurFileName;
            openFileDialog1.Filter = FileFilter;

            read_max_point = (int)nudPointCounter.Value;
            pts_property = (int)nudProperty.Value;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CurFileName = openFileDialog1.FileName;
                string strText = "";
                using (StreamReader sr = new StreamReader(@CurFileName))
                {
                    strText = sr.ReadToEnd();
                }

                // string.Splitで分割
                string[] splitText1;
                splitText1 = strText.Replace("\r\n", "\n").Split('\n');

                for (int i = pts_property; i < read_max_point + pts_property; i++)
                {
                    string[] splitText2;
                    splitText2 = splitText1[i].Split(' ');
                    // 選択解除
                    if (current_counter != 0)
                    {
                        dataGridView.Rows[current_counter - 1].Selected = false;
                    }

                    // 行の作成
                    DataGridViewRow rows = new DataGridViewRow();
                    dataGridView.Rows.Add(rows);                // 行の追加
                    dataGridView.Rows[current_counter].Selected = true; // 選択
                    dataGridView.FirstDisplayedScrollingRowIndex = current_counter; // 行の自動スクロール

                    // 一時保存
                    DataGridViewRow tmp_rows = new DataGridViewRow();
                    dgv_tmp.Rows.Add(tmp_rows);

                    // 値をセット
                    dataGridView[0, current_counter].Value = point_counter;
                    dataGridView[1, current_counter].Value = int.Parse(splitText2[5]);
                    dataGridView[2, current_counter].Value = int.Parse(splitText2[6]);
                    point_counter++; // 全体の点の数(行数)
                    current_counter++; // 編集後の点の数(行数)
                }
                // 一時保存の更新
                for (int i = 0; i < current_counter; i++)
                {
                    dgv_tmp[0, i].Value = dataGridView[0, i].Value;
                    _bmp.SetPixel((int)dataGridView[1, i].Value, (int)dataGridView[2, i].Value, Color.Blue);
                }
            }
            SetPoints();
            this.Refresh();
        }
        //--- 特徴点の書き込み ---//
        private void btnWrite_Click(object sender, EventArgs e)
        {
            // 時間取得
            DateTime dt = DateTime.Now;

            // 点のセット(DGV->Point)
            SetPoints();
            saveFileDialog1.FileName = CurFileName;
            saveFileDialog1.Filter = FileFilter;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CurFileName = saveFileDialog1.FileName; // 名前入力
                // PTS：書き出し
                using (StreamWriter sw = new StreamWriter(@CurFileName))
                {
                    string str = CurFileName;
                    string[] splitText = str.Split('.');

                    sw.WriteLine("*********************************************"); // 1行目
                    sw.WriteLine("*   FileType : {0} File", splitText[splitText.Count() - 1].ToUpper()); // 4行目
                    sw.WriteLine("*   DateTime : {0}.{1}.{2} [{3}:{4}:{5}]", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second); // 3行目
                    sw.WriteLine("*   Written by AFIMsystem"); // 2行目
                    sw.WriteLine("*********************************************"); // 5行目
                    sw.WriteLine(""); // 6行目
                    sw.WriteLine("# Total Landmark number: {0}", current_counter); // 7行目
                    sw.WriteLine(""); // 8行目
                    sw.WriteLine("# Total Area number: 10"); // 9行目
                    sw.WriteLine("# Area number List: 0 1 2 3 4 5 6 7 8 9"); // 10行目
                    sw.WriteLine(""); // 11行目
                    sw.WriteLine("# Format: [Area_Number][Index_Numer_in_Area][Index_Numer][X][Y][ConnectFrom][ConnectTo]"); // 12行目

                    for (int i = 0; i < current_counter; i++)
                    {
                        sw.WriteLine("#  0 0 {0} {1} {2} 0 0", i, io_points[i].X, io_points[i].Y);
                    }
                }
                //// CSV：ファイル書き出し
                //using (StreamWriter sw = new StreamWriter(@CurFileName))
                //{
                //    string str = CurFileName;
                //    string[] splitText = str.Split('.');

                //    for (int i = 0; i < current_counter; i++)
                //    {
                //        sw.WriteLine("{0},{1},{2}", i, io_points[i].X, io_points[i].Y);
                //    }
                //}
            }
        }

        //--- 点の色を変更 ---//
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ColorDialog Cdlg = new ColorDialog();
            if (Cdlg.ShowDialog() == DialogResult.OK)
            {
                PointsColor1 = Cdlg.Color;
                EvenColorItem.BackColor = PointsColor1;
                FlagOfColor1 = true;
            }
            this.Refresh();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ColorDialog Cdlg = new ColorDialog();
            if (Cdlg.ShowDialog() == DialogResult.OK)
            {
                PointsColor2 = Cdlg.Color;
                OddColorItem.BackColor = PointsColor2;
                FlagOfColor2 = true;
            }
            this.Refresh();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ColorDialog Cdlg = new ColorDialog();
            if (Cdlg.ShowDialog() == DialogResult.OK)
            {
                PointsColor3 = Cdlg.Color;
                SelectColorItem.BackColor = PointsColor3;
                FlagOfColor3 = true;
            }
            this.Refresh();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ColorDialog Cdlg = new ColorDialog();
            if (Cdlg.ShowDialog() == DialogResult.OK)
            {
                PointsColor4 = Cdlg.Color;
                MeshColorItem.BackColor = PointsColor4;
                FlagOfColor4 = true;
            }
            this.Refresh();
        }
        //--- 画面情報を更新 ---//
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        //--- ファイルメニューコマンド ---//
        private void FileOpenImage_Click(object sender, EventArgs e)
        {
            openImageDialog.FileName = CurImageName;
            openImageDialog.Filter = ImageFilter;
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                CurImageName = openImageDialog.FileName;
                pictureBox1.Image = Image.FromFile(CurImageName);
                pb1 = pictureBox1;
                bmp = new Bitmap(pictureBox1.Image);
                _bmp = new Bitmap(pictureBox1.Image);
                pictureBox1.Enabled = true;
                this.Text = FormText + " [" + CurImageName + "]";
            }
        }

        //*** Display ***//
        private void DisplayP_Click(object sender, EventArgs e)
        {
            if (ToolPoint.Checked == true)
                ToolPoint.Checked = false;
            else
                ToolPoint.Checked = true;
            this.Refresh();
        }

        private void DisplayPN_Click(object sender, EventArgs e)
        {
            if (ToolPointNumber.Checked == true)
                ToolPointNumber.Checked = false;
            else
                ToolPointNumber.Checked = true;
            this.Refresh();
        }

        private void ToolMesh_Click(object sender, EventArgs e)
        {
            if (ToolMesh.Checked == true)
                ToolMesh.Checked = false;
            else
                ToolMesh.Checked = true;
            this.Refresh();
        }

        private void ToolEyeBrows_Click(object sender, EventArgs e)
        {
            if (ToolEyeBrows.Checked == true)
                ToolEyeBrows.Checked = false;
            else
                ToolEyeBrows.Checked = true;
            this.Refresh();
        }

        private void ToolEyes_Click(object sender, EventArgs e)
        {
            if (ToolEyes.Checked == true)
                ToolEyes.Checked = false;
            else
                ToolEyes.Checked = true;
            this.Refresh();
        }

        private void ToolNose_Click(object sender, EventArgs e)
        {
            if (ToolNose.Checked == true)
                ToolNose.Checked = false;
            else
                ToolNose.Checked = true;
            this.Refresh();
        }

        private void ToolMouth_Click(object sender, EventArgs e)
        {
            if (ToolMouth.Checked == true)
                ToolMouth.Checked = false;
            else
                ToolMouth.Checked = true;
            this.Refresh();
        }

        private void ToolLine_Click(object sender, EventArgs e)
        {
            if (ToolLine.Checked == true)
                ToolLine.Checked = false;
            else
                ToolLine.Checked = true;
            this.Refresh();
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int DragStartX, DragStartY;
        bool FlagOfHold, FlagOfDoubleHold;
        int r_startX, r_startY, r_endX, r_endY;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsOutOfPicBox(e.X, e.Y))
            {
                if (FlagOfDoubleHold)
                {
                    r_endX = e.X;
                    r_endY = e.Y;
                    this.Refresh();
                }
                else if (FlagOfHold)
                {
                    Color c = bmp.GetPixel(e.X, e.Y);

                    // Graphics g = Graphics.FromImage(pictureBox1.Image);
                    PixelInfoText.Text = "(X,Y) = (" + e.X.ToString() + "," + e.Y.ToString() + ")"
                        + " : (R,G,B)=(" + c.R + "," + c.G + "," + c.B + ")";


                    // 現在の行から選択した行数まで
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        if (dataGridView.Rows[i].Selected == true)
                        {
                            int value_x = int.Parse(dataGridView[1, i].Value.ToString()); // 値の取得
                            value_x = value_x + (e.X - DragStartX); // 値の変更

                            int value_y = int.Parse(dataGridView[2, i].Value.ToString()); // 値の取得
                            value_y = value_y + (e.Y - DragStartY); // 値の変更

                            if (value_y < 0)
                                value_y = 0; // 画像内に収める

                            dataGridView[1, i].Value = value_x; // 値の格納
                            dataGridView[2, i].Value = value_y; // 値の格納
                        }
                    }
                    DragStartX = e.X;
                    DragStartY = e.Y;
                    this.Refresh();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            FlagOfHold = false;
            if (FlagOfDoubleHold)
            {
                FlagOfDoubleHold = false;
                SelectArea();
                pictureBox1.Refresh();
            }
        }

        // エリアの選択
        private void SelectArea()
        {
            dataGridView.ClearSelection();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                int value_x = int.Parse(dataGridView[1, i].Value.ToString()); // 値の取得
                int value_y = int.Parse(dataGridView[2, i].Value.ToString()); // 値の取得

                if (value_x > r_startX && value_x < r_endX && value_y > r_startY && value_y < r_endY)
                    dataGridView.Rows[i].Selected = true;
            }
            dataGridView.Update();
        }

        // ピクチャーボックスの範囲外の時:処理離脱
        private bool IsOutOfPicBox(int x, int y)
        {
            if (x <= 0 || y <= 0)
                return false;
            if (pictureBox1.Width <= x || pictureBox1.Height <= y)
                return false;

            return true; // 処理続行
        }

        // 表示画面の更新
        private void cbNumber_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void cbPoints_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void nudPointSize_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void ToolMesh_CheckedChanged(object sender, EventArgs e)
        {
            if (current_counter != 114)
                ToolMesh.Enabled = false;
            pictureBox1.Refresh();
        }

        // 関連付け
        struct ThreePoints      // 三角パッチ
        {
            public int[] px; 	// x座標
            public int[] py;	// y座標
            public void Reset()
            {
                px = new int[3];
                py = new int[3];
            }
        }
        ThreePoints[] Assosiation;
        int AssosiationCounter;

        // 関連付け開始
        private void btnAsso_Click(object sender, EventArgs e)
        {
            SetPoints();
            ToolMesh.Enabled = false;
            Assosiation = new ThreePoints[204];
            if (current_counter == 114)
            {
                AssosiationCounter = 0;
                ToolMesh.Enabled = true;
                ToolEyeBrows.Enabled = true;
                ToolEyes.Enabled = true;
                ToolNose.Enabled = true;
                ToolMouth.Enabled = true;
                ToolLine.Enabled = true;

                for (int i = 0; i < 204; i++)
                    Assosiation[i].Reset();
                FuncOfAssosiation();
                AssosiationCounter = 0;
            }
            pictureBox1.Refresh();
        }

        private void DisplayOfFacialParts()
        {

        }

        private void FuncOfAssosiation()
        {
            Substitution(0, 1, 12);
            Substitution(1, 11, 12);
            Substitution(1, 2, 11);
            Substitution(2, 3, 11);
            Substitution(3, 10, 11);
            Substitution(3, 9, 10);
            Substitution(3, 4, 9);
            Substitution(4, 5, 9);
            Substitution(5, 8, 9);
            Substitution(5, 7, 8);
            Substitution(5, 6, 7);
            Substitution(13, 14, 25);
            Substitution(14, 24, 25);
            Substitution(14, 23, 24);
            Substitution(14, 15, 23);
            Substitution(15, 16, 23);
            Substitution(23, 16, 22);
            Substitution(16, 21, 22);
            Substitution(16, 17, 21);
            Substitution(17, 18, 21);
            Substitution(18, 20, 21);
            Substitution(18, 19, 20);
            Substitution(27, 28, 34);
            Substitution(28, 29, 34);
            Substitution(29, 33, 34);
            Substitution(29, 32, 33);
            Substitution(29, 30, 32);
            Substitution(30, 31, 32);
            Substitution(36, 37, 43);
            Substitution(37, 38, 43);
            Substitution(38, 42, 43);
            Substitution(38, 39, 42);
            Substitution(39, 41, 42);
            Substitution(39, 40, 41);
            Substitution(35, 45, 44);
            Substitution(45, 46, 44);
            Substitution(46, 47, 44);
            Substitution(47, 51, 44);
            Substitution(47, 50, 51);
            Substitution(47, 48, 50);
            Substitution(48, 49, 50);
            Substitution(50, 49, 53);
            Substitution(51, 50, 53);
            Substitution(52, 51, 53);
            Substitution(49, 71, 53);
            Substitution(54, 52, 53);
            Substitution(53, 71, 54);
            Substitution(54, 71, 70);
            Substitution(56, 58, 57);
            Substitution(56, 55, 58);
            Substitution(44, 51, 52);
            Substitution(54, 44, 52);
            Substitution(55, 44, 54);
            Substitution(58, 55, 54);
            Substitution(58, 54, 69);
            Substitution(59, 58, 69);
            Substitution(54, 70, 69);
            Substitution(57, 58, 59);
            Substitution(59, 60, 57);
            Substitution(63, 35, 44);
            Substitution(62, 63, 44);
            Substitution(61, 62, 44);
            Substitution(56, 61, 44);
            Substitution(56, 44, 55);
            Substitution(66, 67, 80);
            Substitution(67, 81, 80);
            Substitution(68, 81, 67);
            Substitution(68, 82, 81);
            Substitution(68, 69, 82);
            Substitution(69, 70, 82);
            Substitution(70, 83, 82);
            Substitution(70, 84, 83);
            Substitution(70, 71, 84);
            Substitution(71, 72, 84);
            Substitution(72, 85, 84);
            Substitution(72, 73, 85);
            Substitution(73, 86, 85);
            Substitution(73, 74, 86);
            Substitution(74, 75, 86);
            Substitution(75, 87, 86);
            Substitution(76, 87, 75);
            Substitution(88, 87, 76);
            Substitution(76, 89, 88);
            Substitution(89, 76, 77);
            Substitution(89, 77, 78);
            Substitution(90, 89, 78);
            Substitution(91, 90, 78);
            Substitution(79, 91, 78);
            Substitution(80, 91, 79);
            Substitution(66, 80, 79);
            Substitution(80, 81, 91);
            Substitution(81, 82, 91);
            Substitution(82, 90, 91);
            Substitution(82, 89, 90);
            Substitution(82, 83, 89);
            Substitution(83, 84, 89);
            Substitution(84, 88, 89);
            Substitution(84, 87, 88);
            Substitution(84, 85, 87);
            Substitution(85, 86, 87);
            Substitution(65, 98, 99);
            Substitution(65, 99, 100);
            Substitution(74, 65, 100);
            Substitution(74, 100, 101);
            Substitution(74, 101, 75);
            Substitution(75, 101, 102);
            Substitution(76, 75, 102);
            Substitution(77, 76, 102);
            Substitution(77, 102, 103);
            Substitution(104, 77, 103);
            Substitution(78, 77, 104);
            Substitution(79, 78, 104);
            Substitution(66, 79, 105);
            Substitution(79, 104, 105);
            Substitution(106, 66, 105);
            Substitution(107, 64, 106);
            Substitution(64, 66, 106);
            Substitution(108, 27, 64);
            Substitution(107, 108, 64);
            Substitution(109, 27, 108);
            Substitution(0, 27, 109);
            Substitution(110, 0, 109);
            Substitution(111, 0, 110);
            Substitution(111, 112, 1);
            Substitution(111, 1, 0);
            Substitution(112, 2, 1);
            Substitution(112, 3, 2);
            Substitution(112, 113, 3);
            Substitution(113, 4, 3);
            Substitution(113, 5, 4);
            Substitution(113, 92, 5);
            Substitution(5, 92, 6);
            Substitution(92, 26, 6);
            Substitution(92, 13, 26);
            Substitution(92, 14, 13);
            Substitution(92, 93, 14);
            Substitution(93, 15, 14);
            Substitution(93, 16, 15);
            Substitution(93, 94, 16);
            Substitution(94, 17, 16);
            Substitution(94, 18, 17);
            Substitution(94, 95, 18);
            Substitution(95, 19, 18);
            Substitution(95, 96, 19);
            Substitution(96, 97, 19);
            Substitution(40, 19, 97);
            Substitution(40, 97, 98);
            Substitution(40, 98, 65);
            Substitution(26, 13, 25);
            Substitution(6, 26, 7);
            Substitution(26, 25, 35);
            Substitution(7, 26, 35);
            Substitution(31, 7, 35);
            Substitution(25, 36, 35);
            Substitution(25, 37, 36);
            Substitution(25, 24, 37);
            Substitution(24, 23, 37);
            Substitution(23, 38, 37);
            Substitution(23, 22, 38);
            Substitution(22, 21, 38);
            Substitution(21, 39, 38);
            Substitution(21, 20, 39);
            Substitution(19, 39, 20);
            Substitution(19, 40, 39);
            Substitution(65, 41, 40);
            Substitution(35, 36, 45);
            Substitution(31, 35, 63);
            Substitution(7, 31, 30);
            Substitution(8, 7, 30);
            Substitution(9, 8, 30);
            Substitution(10, 9, 29);
            Substitution(9, 30, 29);
            Substitution(11, 10, 29);
            Substitution(12, 11, 28);
            Substitution(11, 29, 28);
            Substitution(0, 12, 28);
            Substitution(0, 28, 27);
            Substitution(36, 46, 45);
            Substitution(31, 63, 62);
            Substitution(32, 31, 64);
            Substitution(33, 32, 64);
            Substitution(34, 33, 64);
            Substitution(27, 34, 64);
            Substitution(36, 43, 65);
            Substitution(43, 42, 65);
            Substitution(42, 41, 65);
            Substitution(48, 47, 65);
            Substitution(64, 61, 60);
            Substitution(60, 66, 64);
            Substitution(48, 65, 74);
            Substitution(48, 74, 73);
            Substitution(48, 73, 49);
            Substitution(49, 73, 72);
            Substitution(49, 72, 71);
            Substitution(60, 67, 66);
            Substitution(60, 59, 67);
            Substitution(59, 68, 67);
            Substitution(59, 69, 68);
            Substitution(31, 62, 61);
            Substitution(31, 61, 64);
            Substitution(36, 47, 46);
            Substitution(36, 65, 47);
            Substitution(61, 56, 57);
            Substitution(60, 61, 57);
        }
        private void Substitution(int p1, int p2, int p3)
        {
            // 入力画像の座標
            Assosiation[AssosiationCounter].px[0] = io_points[p1].X;
            Assosiation[AssosiationCounter].py[0] = io_points[p1].Y;
            Assosiation[AssosiationCounter].px[1] = io_points[p2].X;
            Assosiation[AssosiationCounter].py[1] = io_points[p2].Y;
            Assosiation[AssosiationCounter].px[2] = io_points[p3].X;
            Assosiation[AssosiationCounter].py[2] = io_points[p3].Y;

            AssosiationCounter++;
        }
    }
}
