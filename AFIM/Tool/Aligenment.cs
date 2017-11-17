using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Collections;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Blob;
using OpenCvSharp.Extensions;
using OpenCvSharp.MachineLearning;

namespace AFIM
{
    public partial class Aligenment : Form
    {
        // 画像ファイル・特徴点ファイルのフィルター
        const string ImageFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png|All file (*.*)|*.*";
        const string FileFilter = "Text File (*.txt, *.pts)|*.txt;*.pts";
        const string SaveImageFilter = "BMP (*.bmp)|*.bmp|JPG/JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
        int CurrentCounter = 0;
        string[] ImageFilenames, PointFilenames;    // パスありファイル名
        string[] ImageFilename, PointFilename;      // パスなしファイル名/拡張子ありファイル名
        string[] _ImageFilename, _PointFilename;    // 拡張子なしファイル名
        int PointsMax, PtsProperty;                 // 最大点数, Ptsプロパティ
        string SaveFilename;

        Point[] BaseCoordinate, TransferCoordinate;
        CvMat A_mat, Z_mat;

        // 画像情報
        int iWidth, iHeight;
        Bitmap src_img, dst_img;
        //private Thread thread = null;

        // フラグ
        bool BtnFlagOpenImages = false;
        bool BtnFlagOpenPoints = false;
        bool BtnFlagOpenTarget = false;
        bool BtnFlagFileSave = false;

        // アライメント
        int DIMENTION = 2;      // 次元数(x,y座標)
        int POINTNUM = 114;     // 点の数


        public Aligenment()
        {
            InitializeComponent();
        }
        //--- イメージ設定 ---//
        private void BtnFolderImages_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialogImages.ShowDialog(this) == DialogResult.OK)
            {
                FolderImagesLocation.Text = FolderBrowserDialogImages.SelectedPath;
                BtnFlagOpenImages = true;
            }
        }
        //--- ポイント設定 ---//
        private void BtnFolderPoints_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialogPoints.ShowDialog(this) == DialogResult.OK)
            {
                FolderPointsLocation.Text = FolderBrowserDialogPoints.SelectedPath;
                BtnFlagOpenPoints = true;
            }
        }
        //--- セーブ設定 ---//
        private void BtnFolderSave_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialogSave.ShowDialog(this) == DialogResult.OK)
            {
                FolderSaveLocation.Text = FolderBrowserDialogSave.SelectedPath;
                BtnFlagFileSave = true;
            }
        }
        //---  正規化設定 ---//
        private void BtnFileTarget_Click(object sender, EventArgs e)
        {
            OpenFileDialogTarget.Filter = FileFilter;   // フィルター
            if (OpenFileDialogTarget.ShowDialog(this) == DialogResult.OK)
            {
                FileTargetLocation.Text = OpenFileDialogTarget.FileName;
                BtnFlagOpenTarget = true;
            }
        }
        private void BtnFileAssociation_Click(object sender, EventArgs e)
        {
            OpenFileDialogAssociation.Filter = ImageFilter;
            if (OpenFileDialogAssociation.ShowDialog(this) == DialogResult.OK)
            {
                FileAssociationLocation.Text = OpenFileDialogAssociation.FileName;
            }
        }
        //--- DataGridView処理 ---//
        private void dataGridView1_Insert(int ImageFileNumber, int PointFileNumber)
        {
            // 行の作成
            DataGridViewRow rows = new DataGridViewRow();
            dataGridView1.Rows.Add(rows);               // 行の追加
            //dataGridView1.Rows[0].Selected = true;    // 行の選択
            dataGridView1.FirstDisplayedScrollingRowIndex = CurrentCounter; // 行の自動スクロール
            dataGridView1[0, CurrentCounter].Value = true;      // チェック
            dataGridView1[1, CurrentCounter].Value = ImageFilename[ImageFileNumber];     // 画像ファイル名
            dataGridView1[2, CurrentCounter].Value = PointFilename[PointFileNumber];    // テキストファイル名

            // 全読み込みファイル
            ImageCounterBox.Items.Add(ImageFilenames[ImageFileNumber]);
            PointCounterBox.Items.Add(PointFilenames[PointFileNumber]);
            CurrentCounter++;
        }
        private void BtnFileRead_Click(object sender, EventArgs e)
        {
            if (BtnFlagOpenImages == true && BtnFlagOpenPoints == true)
            {
                BtnFileInit_Click(sender, e);
                BtnFileAdd_Click(sender, e);
                BtnFileAdd.Enabled = true;
                BtnFileInit.Enabled = true;
                //label11.Text = ExecutableMode.TrueValue.ToString();
            }
            else
            {
                MessageBox.Show("画像と特徴点を先に入力してください", "入力データの未選択");
            }
        }
        private void BtnFileAdd_Click(object sender, EventArgs e)
        {
            // フォルダファイルの取得
            ImageFilenames = System.IO.Directory.GetFiles(FolderImagesLocation.Text, "*.jpg");
            PointFilenames = System.IO.Directory.GetFiles(FolderPointsLocation.Text, "*.txt");

            ImageFilename = new string[ImageFilenames.Count()];     // 表示用
            PointFilename = new string[PointFilenames.Count()];     // パスなし

            _ImageFilename = new string[ImageFilenames.Count()];    // 一致判定
            _PointFilename = new string[PointFilenames.Count()];    // +拡張子なし

            for (int i = 0; i < ImageFilenames.Count(); i++)
            {
                string[] SplitText;
                SplitText = ImageFilenames[i].Replace("\\", "/").Split('/');
                string StrText = SplitText[SplitText.Count() - 1];             // パスの削除
                ImageFilename[i] = StrText;                                   // ファイル名(+拡張子)取得
                SplitText = StrText.Split('.');
                _ImageFilename[i] = SplitText[0];                               // 拡張子の削除
            }
            for (int i = 0; i < PointFilenames.Count(); i++)
            {
                string[] SplitText;
                SplitText = PointFilenames[i].Replace("\\", "/").Split('/');
                string StrText = SplitText[SplitText.Count() - 1];
                PointFilename[i] = StrText;
                SplitText = StrText.Split('.');
                _PointFilename[i] = SplitText[0];
            }

            // 一致ファイル名の検索
            for (int i = 0; i < ImageFilenames.Count(); i++)
            {
                for (int j = 0; j < PointFilenames.Count(); j++)
                {
                    if (_ImageFilename[i] == _PointFilename[j])
                    {
                        dataGridView1_Insert(i, j);
                    }
                }
            }
            // 選択ファイル数を表示(追加行はカウントしない)
            RunFileCount.Text = (dataGridView1.RowCount).ToString();
        }
        private void BtnFileInit_Click(object sender, EventArgs e)
        {
            for (int i = CurrentCounter - 1; i >= 0; i--)
                dataGridView1.Rows.RemoveAt(i);
            CurrentCounter = 0;
            ImageCounterBox.Items.Clear();
            PointCounterBox.Items.Clear();
            // 選択ファイル数を表示(追加行はカウントしない)
            RunFileCount.Text = (dataGridView1.RowCount).ToString();
        }
        // 実行ボタン
        private void BtnRun_Click(object sender, EventArgs e)
        {
            BtnRun.Enabled = false; // ボタン制御
            BackgroundWorker.RunWorkerAsync();
        }
        // 実行中断 
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (BtnRun.Enabled == false)
            {
                BackgroundWorker.CancelAsync();
                BtnRun.Enabled = true;
            }
            else
                MessageBox.Show("実行して下さい");
        }
        // 実行経過
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;
            OutputList.Items.Add(SaveFilename); // 画像の書き出し
            progressBar1.Value = (int)(((double)(i+1) / (double)CurrentCounter) * 100);
            textBox1.Text = (i + 1).ToString() + "/" + CurrentCounter.ToString();
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnRun.Enabled = true;
        }
        //--- 正規化処理 ---//
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool FlagIO;
            if (BtnFlagOpenImages == true && BtnFlagOpenPoints == true && BtnFlagOpenTarget == true && BtnFlagFileSave == true)
            {
                // 行列計算
                A_mat = Cv.CreateMat(DIMENTION * POINTNUM, 4, MatrixType.F32C1);
                Z_mat = Cv.CreateMat(4, 1, MatrixType.F32C1);
                
                //　基準座標行列
                CvMat X1_mat = Cv.CreateMat(DIMENTION * POINTNUM, 1, MatrixType.F32C1);
                CvMat X2_mat = Cv.CreateMat(DIMENTION * POINTNUM, 1, MatrixType.F32C1);

                // 基準座標ポイント
                FlagIO = true;
                ReadPoint(FileTargetLocation.Text, FlagIO);
                
                // 変換座標ポイント
                FlagIO = false;
                for (int i = 0; i < CurrentCounter; i++)
                {
                    // 画像の読み込み
                    src_img = new Bitmap(Image.FromFile(ImageCounterBox.Items[i].ToString()));
                    iWidth = src_img.Width;
                    iHeight = src_img.Height;
                    dst_img = new Bitmap(iWidth, iHeight);

                    // 特徴点読み込み
                    ReadPoint(PointCounterBox.Items[i].ToString(), FlagIO);
                    for (int j = 0; j < POINTNUM; j++)
                    {
                        // 行列Aを格納
                        Cv.Set2D(A_mat, j * 2, 0, TransferCoordinate[j].X);
                        Cv.Set2D(A_mat, j * 2, 1, -TransferCoordinate[j].Y);
                        Cv.Set2D(A_mat, j * 2, 2, 1);
                        Cv.Set2D(A_mat, j * 2, 3, 0);
                        Cv.Set2D(A_mat, j * 2 + 1, 0, TransferCoordinate[j].Y);
                        Cv.Set2D(A_mat, j * 2 + 1, 1, TransferCoordinate[j].X);
                        Cv.Set2D(A_mat, j * 2 + 1, 2, 0);
                        Cv.Set2D(A_mat, j * 2 + 1, 3, 1);

                        // 行列Xに座標を格納
                        Cv.Set2D(X1_mat, j * 2, 0, BaseCoordinate[j].X);
                        Cv.Set2D(X1_mat, j * 2 + 1, 0, BaseCoordinate[j].Y);
                    }

                    //--- 行列W(重み)を求める ---//
                    CvMat W_mat = Cv.CreateMat(DIMENTION * POINTNUM, DIMENTION * POINTNUM, MatrixType.F32C1);
                    for (int j = 0; j < POINTNUM * DIMENTION; j++)
                    {
                        for (int k = 0; k < POINTNUM * DIMENTION; k++)
                        {
                            if (j == k)
                            {
                                Cv.Set2D(W_mat, j, k, 1);
                                if(j==31 || j==36 || j==44)
                                    Cv.Set2D(W_mat, j, k, 5);
                            }
                            else
                            {
                                Cv.Set2D(W_mat, j, k, 0);
                            }
                        }
                    }

                    // アライメント行列計算
                    CvMat tmp1 = Cv.CreateMat(4, DIMENTION * POINTNUM, MatrixType.F32C1);
                    CvMat tmp1_t = Cv.CreateMat(DIMENTION * POINTNUM, 4, MatrixType.F32C1);
                    CvMat tmp2 = Cv.CreateMat(4, 4, MatrixType.F32C1);

                    // 転置行列の準備
                    CvMat W_mat_t = Cv.CreateMat(DIMENTION * POINTNUM, DIMENTION * POINTNUM, MatrixType.F32C1);
                    Cv.Transpose(W_mat, W_mat_t);

                    CvMat A_mat_t = Cv.CreateMat(4, DIMENTION * POINTNUM, MatrixType.F32C1);
                    Cv.Transpose(A_mat, A_mat_t);
                    
                    Cv.MatMul(A_mat_t, W_mat_t, tmp1);
                    Cv.MatMul(tmp1, W_mat, tmp1);
                    Cv.MatMul(tmp1, A_mat, tmp2);
                    Cv.Invert(tmp2, tmp2);
                    Cv.MatMul(tmp2, A_mat_t, tmp1);
                    Cv.MatMul(tmp1, W_mat_t, tmp1);
                    Cv.MatMul(tmp1, W_mat, tmp1);
                    Cv.MatMul(tmp1, X1_mat, Z_mat);
                    Cv.MatMul(A_mat, Z_mat, X2_mat);

                    // 書き出しファイル名
                    SaveFilename = FilenameBefore.Text + _ImageFilename[i] + FilenameAfter.Text;
                    string filename = FolderSaveLocation.Text + "\\" + SaveFilename + ".txt";
                    WritePTS(X2_mat, filename); // 座標の書き出し

                    // 画像の変換と書き出し
                    if (cbImageOutput.Checked == true)
                    {
                        Transform();
                        dst_img.Save(FolderSaveLocation.Text + "\\" + SaveFilename + ".png");
                    }

                    // メモリ解放
                    src_img.Dispose();
                    dst_img.Dispose();

                    // 表示
                    BackgroundWorker.ReportProgress(i);
                }
            }
            else
            {
                MessageBox.Show("必要な情報を先に入力してください", "入力データの未選択");
            }
        }
        private void ReadPoint(string Filename, bool FlagIO)
        {
            PointsMax = POINTNUM;    // 最大点数
            PtsProperty = 12;   // プロパティ行数(座標以外の情報)
            Array.Resize<Point>(ref BaseCoordinate, PointsMax + 1);
            Array.Resize<Point>(ref TransferCoordinate, PointsMax + 1);

            string StrText = "";
            using (StreamReader sr = new StreamReader(@Filename)) StrText = sr.ReadToEnd();

            // string.Splitで分割
            string[] SplitText1;
            SplitText1 = StrText.Replace("\r\n", "\n").Split('\n');
            for (int i = PtsProperty; i < PtsProperty + PointsMax; i++)
            {
                string[] SplitText2;
                SplitText2 = SplitText1[i].Split(' ');

                // 値をセット
                if (FlagIO)
                {
                    BaseCoordinate[i - PtsProperty].X = int.Parse(SplitText2[5]);
                    BaseCoordinate[i - PtsProperty].Y = int.Parse(SplitText2[6]);
                }
                else
                {
                    TransferCoordinate[i - PtsProperty].X = int.Parse(SplitText2[5]);
                    TransferCoordinate[i - PtsProperty].Y = int.Parse(SplitText2[6]);
                }
            }
        }
        public void WritePTS(CvMat input_mat, string filename)
        {
            // 時間取得
            DateTime dt = DateTime.Now;
            using (StreamWriter sw = new StreamWriter(@filename))
            {
                string str = filename;
                string[] splitText = str.Split('.');

                sw.WriteLine("*********************************************"); // 1行目
                sw.WriteLine("*   FileType : {0} File", splitText[splitText.Count() - 1].ToUpper()); // 4行目
                sw.WriteLine("*   DateTime : {0}.{1}.{2} [{3}:{4}:{5}]", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second); // 3行目
                sw.WriteLine("*   Written by AFIMsystem"); // 2行目
                sw.WriteLine("*********************************************"); // 5行目
                sw.WriteLine(""); // 6行目
                sw.WriteLine("# Total Landmark number: {0}", POINTNUM); // 7行目
                sw.WriteLine(""); // 8行目
                sw.WriteLine("# Total Area number: 10"); // 9行目
                sw.WriteLine("# Area number List: 0 1 2 3 4 5 6 7 8 9"); // 10行目
                sw.WriteLine(""); // 11行目
                sw.WriteLine("# Format: [Area_Number][Index_Numer_in_Area][Index_Numer][X][Y][ConnectFrom][ConnectTo]"); // 12行目

                for (int i = 0; i < POINTNUM; i++)
                {
                    int X = (int)(Cv.Get2D(input_mat, i * DIMENTION, 0) + 0.5);
                    int Y = (int)(Cv.Get2D(input_mat, i * DIMENTION + 1, 0) + 0.5);
                    if (X < 0) X = 0;
                    if (Y < 0) Y = 0;
                    if (X >= iWidth) X = iWidth - 1;
                    if (Y >= iHeight) Y = iHeight - 1;
                    sw.WriteLine("#  0 0 {0} {1} {2} 0 0", i, X, Y);
                }
            }
        }
        public void Transform()
        {
            // アライメント処理
            CvMat M_mat = Cv.CreateMat(2, 2, MatrixType.F32C1);
            CvMat T_mat = Cv.CreateMat(2, 1, MatrixType.F32C1);

            // 行列Mと行列Tにパラメータを格納
            Cv.Set2D(M_mat, 0, 0, Cv.Get2D(Z_mat, 0, 0));
            Cv.Set2D(M_mat, 0, 1, -Cv.Get2D(Z_mat, 1, 0));
            Cv.Set2D(M_mat, 1, 0, Cv.Get2D(Z_mat, 1, 0));
            Cv.Set2D(M_mat, 1, 1, Cv.Get2D(Z_mat, 0, 0));
            Cv.Set2D(T_mat, 0, 0, Cv.Get2D(Z_mat, 2, 0));
            Cv.Set2D(T_mat, 1, 0, Cv.Get2D(Z_mat, 3, 0));

            CvMat M_mat_inv = Cv.CreateMat(2, 2, MatrixType.F32C1);
            Cv.Invert(M_mat, M_mat_inv);

            CvMat Image_mat = Cv.CreateMat(2, 1, MatrixType.F32C1);
            for (int j = 0; j < iHeight; j++)
            {
                for (int k = 0; k < iWidth; k++)
                {
                    Cv.Set2D(Image_mat, 0, 0, k);
                    Cv.Set2D(Image_mat, 1, 0, j);

                    Cv.Sub(Image_mat, T_mat, Image_mat);
                    Cv.MatMul(M_mat_inv, Image_mat, Image_mat);

                    int xmat = (int)Cv.Get2D(Image_mat, 0, 0);
                    int ymat = (int)Cv.Get2D(Image_mat, 1, 0);

                    if (0 <= xmat && xmat < iWidth)
                    {
                        if (0 <= ymat && ymat < iHeight)
                        {
                            dst_img.SetPixel(k, j, src_img.GetPixel(xmat, ymat));
                        }
                    }
                }
            }
            //thread.Abort();
        }
    }
}
