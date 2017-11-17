using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AFIM
{
    public partial class UntitledWindow : Form
    {
        // 現在のファイル名
        String CurFileName = ""; 
        const string FileFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg";

        // 編集モードの状態を表す列挙型
        enum EditMode
        {
            PenMode,
            EraserMode,
            SelectMode,
            NotEditing
        };
        EditMode CurEditMode; // 編集モードの状態

        // 選択モードの状態を表す列挙型
        enum SelectionMode
        {
            None,   // 選択されている
            One,    // 一端が選択されている
            Two     // 両端が選択されている
        };

        SelectionMode CurSelectionMode; // 選択モードの状態
        Rectangle CurSelection; // 現在の選択範囲

        public UntitledWindow()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            NewImage(); // 新しいイメージを作成する
        }

        public void NewImage()
        {
            // イメージの作成
            PicBox.Image = new Bitmap(PicBox.Width, PicBox.Height);
            // 選択範囲なし
            CurSelection = Rectangle.Empty;
            // 最初のツール(ペン)
            ToolPen.Checked = true;
            ToolEraser.Checked = false;
            ToolSelectArea.Checked = false;
            SetMode();
        }
        public void SetMode()
        {
            if (StatusBar.Items.Count == 0)
                StatusBar.Items.Add("");
            if (ToolPen.Checked) // ペンモード
            {
                CurEditMode = EditMode.PenMode;
                StatusBar.Items[0].Text = "Pen Mode";
            }
            if (ToolEraser.Checked) // 消しゴムモード
            {
                CurEditMode = EditMode.EraserMode;
                StatusBar.Items[0].Text = "Eraser Mode";
            }
            if (ToolSelectArea.Checked) // 選択モード
            {
                CurEditMode = EditMode.SelectMode;
                StatusBar.Items[0].Text = "Select Area Mode";
            }
        }
               
        public void SetWindowSize()
        {
            int w = PicBox.Width;
            int h = PicBox.Height + StatusBar.Height + ToolBar.Height;
            int sw = Screen.PrimaryScreen.Bounds.Width;
            int sh = Screen.PrimaryScreen.Bounds.Height;

            // クライアントサイズを設定する
            this.SetClientSizeCore(w+10, h+10);

            // Window配置
            if (w > sw)
                PicBox.Top = 0;
            if (h > sh)
                PicBox.Left = 0;
        }

        public bool IsOutOfPicBox(int x, int y)
        {
            // ピクチャーボックスの範囲外の時:処理離脱
            if (x <= 0 || y <= 0)
                return true;
            if (PicBox.Width - 4 <= x || PicBox.Height - 4 <= y)
                return true;
            // 処理続行
            return false;
        }

        // ---ツール関係--- //
        public void ToolPen_Click(object sender, EventArgs e)
        {
            // ペンツール選択
            ToolPen.Checked = true;
            ToolEraser.Checked = false;
            ToolSelectArea.Checked = false;
            SetMode();
            // 選択解除
            CurSelection = Rectangle.Empty;
            PicBox.Refresh();
        }

        public void ToolEraser_Click(object sender, EventArgs e)
        {
            // 消しゴムを選択
            ToolPen.Checked = false;
            ToolEraser.Checked = true;
            ToolSelectArea.Checked = false;
            SetMode();
            // 選択を解除する
            CurSelection = Rectangle.Empty;
            PicBox.Refresh();
        }

        public void ToolSelectArea_Click(object sender, EventArgs e)
        {
            // 選択を解除する
            CurSelection = Rectangle.Empty;
            PicBox.Refresh();
            // 範囲を選択する
            ToolPen.Checked = false;
            ToolEraser.Checked = false;
            ToolSelectArea.Checked = true;
            SetMode();
        }
        private void ToolBtnOpen_Click(object sender, EventArgs e)
        {
            OpenImgDialog.FileName = CurFileName;
            OpenImgDialog.Filter = FileFilter;
            if (OpenImgDialog.ShowDialog() == DialogResult.OK)
            {
                CurFileName = OpenImgDialog.FileName;
                this.Text = CurFileName;
                PicBox.Image = Image.FromFile(CurFileName);
                PicBox.Width = PicBox.Image.Width;    // 画像の大きさを記憶
                PicBox.Height = PicBox.Image.Height;

                UntitledWindow_Resize(sender, e); // 中心に移動させる
                SetWindowSize(); // ウィンドウのサイズをイメージのサイズに合わせる
            }
        }
        private void SaveImageItem_Click(object sender, EventArgs e)
        {
            if (PicBox == null)
                return;
            if (CurFileName.Length < 1) // 名前入力なし
                SaveAsItem_Click(sender, e);
            else
                PicBox.Image.Save(CurFileName); // 保存
        }
        public void SaveAsItem_Click(object sender, EventArgs e)
        {
            SaveImgDialog.FileName = this.Text;
            SaveImgDialog.Filter = FileFilter;
            if (SaveImgDialog.ShowDialog(this) == DialogResult.OK)
            {
                CurFileName = SaveImgDialog.FileName; // 名前入力
                SaveImageItem_Click(sender, e); // 保存関数
            }
        }
        // ---ペイント処理--- //
        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (CurEditMode == EditMode.SelectMode)
            {
                Graphics g = e.Graphics;

                if (CurSelectionMode == SelectionMode.One)
                {
                    // ラバーバンドを描画する
                    Pen pn = new Pen(Color.LightGray);
                    g.DrawRectangle(pn, CurSelection);
                }

                if (CurSelectionMode == SelectionMode.Two)
                {
                    // 選択領域を描画する
                    // CurSelection = // 現在の選択範囲
                    Pen pn = new Pen(Color.Gray);
                    g.DrawRectangle(pn, CurSelection);
                }
            }
        }

        // ---オペレーション関係---//
        public void OpClear_Click(object sender, EventArgs e)
        {
            // 砂時計カーソルにする
            this.Cursor = Cursors.WaitCursor;

            Bitmap bm = (Bitmap)PicBox.Image;

            int w = PicBox.Image.Width;
            int h = PicBox.Image.Height;

            int xs = 0, ys = 0;

            if (!CurSelection.IsEmpty)
            {
                ys = CurSelection.Top;
                xs = CurSelection.Left;
                w = CurSelection.Left + CurSelection.Width;
                h = CurSelection.Top + CurSelection.Height;
            }
            for (int y = ys; y < h; y++)
            {
                for (int x = xs; x < w; x++)
                {
                    bm.SetPixel(x, y, Color.White);
                }
            }
            PicBox.Image = bm;
            this.Cursor = Cursors.Default;
        }

        public void OpMono_Click(object sender, EventArgs e)
        {
            // 砂時計カーソルにする
            this.Cursor = Cursors.WaitCursor;

            Bitmap bm = (Bitmap)PicBox.Image;

            int w = PicBox.Image.Width;
            int h = PicBox.Image.Height;

            int xs = 0, ys = 0;
            if (!CurSelection.IsEmpty)
            {
                ys = CurSelection.Top;
                xs = CurSelection.Left;
                w = CurSelection.Left + CurSelection.Width;
                h = CurSelection.Top + CurSelection.Height;
            }
            for (int y = ys; y < h; y++)
            {
                for (int x = xs; x < w; x++)
                {
                    Color c = bm.GetPixel(x, y);
                    // 平均輝度を求める
                    int rgbdiv3 = (c.R + c.G + c.B) / 3;
                    Color nc = Color.FromArgb(rgbdiv3, rgbdiv3, rgbdiv3);
                    bm.SetPixel(x, y, nc);
                }
            }
            PicBox.Image = bm;
            // デフォルトカーソルに戻す
            this.Cursor = Cursors.Default;
        }

        public void OpReduce_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Bitmap srcbm = (Bitmap)PicBox.Image;

            int w = PicBox.Image.Width;
            int h = PicBox.Image.Height;
            int nw = (w + 1) / 2;
            int nh = (h + 1) / 2;

            Bitmap destbm = new Bitmap(nw, nh);
            for (int y = 0; y < h; y += 2)
            {
                for (int x = 0; x < w; x++)
                {
                    Color c = srcbm.GetPixel(x, y);
                    int xx = x / 2;
                    int yy = y / 2;
                    destbm.SetPixel(xx, yy, c);
                }
            }
            PicBox.Width = nw;
            PicBox.Height = nh;
            PicBox.Image = destbm;

            SetWindowSize();

            this.Cursor = Cursors.Default;
            // サイズ変更後はペンツールにする
            ToolPen.Checked = true;
            ToolEraser.Checked = false;
            ToolSelectArea.Checked = false; // (選択ツール範囲外の可能性あり)
            SetMode();
        }

        // ---マウス処理--- //
        public void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // マウスの左ボタンを押している時
            if (CurEditMode == EditMode.SelectMode)
            {
                // 選択モードのとき最初の点を保存する
                if (IsOutOfPicBox(e.X, e.Y))
                    return;
                // 一端が選択されている
                CurSelectionMode = SelectionMode.One;
                // クリック点からサイズが0の範囲
                CurSelection = new Rectangle(e.X, e.Y, 0, 0);
                PicBox.Refresh();
            }
        }

        public void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // マウスの左ボタンを離した時(&コンポーネントの上にある)
            if (CurEditMode == EditMode.SelectMode)
            {
                // 範囲条件
                if (IsOutOfPicBox(e.X, e.Y))
                    return;

                if (CurSelectionMode == SelectionMode.One)
                {
                    // 四角形の"左上"から指定
                    CurSelection = new Rectangle(
                        CurSelection.Left, CurSelection.Top,
                        e.X - CurSelection.Left, e.Y - CurSelection.Top);
                    // 範囲が設定されている状態
                    CurSelectionMode = SelectionMode.Two;
                    PicBox.Refresh();
                }
            }
        }

        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // マウスの左ボタンを押している状態
            if (e.Button == MouseButtons.Left)
            {
                if (IsOutOfPicBox(e.X, e.Y))
                    return;

                if (CurEditMode == EditMode.PenMode)
                {
                    Bitmap bm = (Bitmap)PicBox.Image;
                    bm.SetPixel(e.X, e.Y, Color.Black);
                    PicBox.Image = bm;
                }

                if (CurEditMode == EditMode.EraserMode)
                {
                    Bitmap bm = (Bitmap)PicBox.Image;
                    bm.SetPixel(e.X, e.Y, Color.White);
                    PicBox.Image = bm;
                }
                if (CurEditMode == EditMode.SelectMode)
                {
                    if (CurSelectionMode == SelectionMode.One)
                    {
                        // 選択領域
                        CurSelection = new Rectangle(
                            CurSelection.Left, CurSelection.Top,
                            e.X - CurSelection.Left,
                            e.Y - CurSelection.Top);
                        PicBox.Refresh();
                    }
                }
            }
        }

        private void InitImageItem_Click(object sender, EventArgs e)
        {
            // 新しくファイルを作る
            PicBox.Image = null;
            NewImage();
        }
        public void UntitledWindow_Resize(object sender, EventArgs e)
        {
            int w = PicBox.Width;
            int h = PicBox.Height + StatusBar.Height + ToolBar.Height;

            // イメージが画像サイズより大きい場合は調整する
            int sw = Screen.PrimaryScreen.Bounds.Width;
            int sh = Screen.PrimaryScreen.Bounds.Height;

            // Windowサイズ変更時
            if (w < sw)
                PicBox.Left = (int)((this.Width - 16) / 2 - w / 2); // 横幅:計-16pixel
            if (h < sh)
                PicBox.Top = (int)((this.Height + 8) / 2 - h / 2); // 縦幅:計+8pixel[ToolBarなし:38]
        }
    }
}
