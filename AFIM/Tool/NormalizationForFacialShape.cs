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

namespace AFIM
{
    public partial class NormalizationForFacialShape : Form
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

        Point[] InputCoordinate, OutputCoordinate;
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
        ThreePoints[] InputAssosiation = new ThreePoints[204];
        ThreePoints[] OutputAssosiation = new ThreePoints[204];
        int AssociationCounter;
        // 画像情報
        int iWidth, iHeight;
        private Bitmap src_img, dst_img;

        // フラグ
        bool BtnFlagOpenImages = false;
        bool BtnFlagOpenPoints = false;
        bool BtnFlagOpenTarget = false;
        bool BtnFlagFileSave = false;

        public NormalizationForFacialShape()
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
            RunFileCount.Text = (dataGridView1.RowCount - 1).ToString();
        }
        private void BtnFileInit_Click(object sender, EventArgs e)
        {
            for (int i = CurrentCounter - 1; i >= 0; i--)
                dataGridView1.Rows.RemoveAt(i);
            CurrentCounter = 0;
            ImageCounterBox.Items.Clear();
            PointCounterBox.Items.Clear();
            // 選択ファイル数を表示(追加行はカウントしない)
            RunFileCount.Text = (dataGridView1.RowCount - 1).ToString();
        }
        //--- 関連付け処理 ---//
        private void BtnRun_Click(object sender, EventArgs e)
        {
            bool FlagIO;
            if (BtnFlagOpenImages == true && BtnFlagOpenPoints == true && BtnFlagOpenTarget == true && BtnFlagFileSave == true)
            {
                // 出力(ターゲット)ポイント処理
                FlagIO = true;
                ReadPoint(FileTargetLocation.Text, FlagIO);

                // 入力(オリジナル)ポイント処理
                FlagIO = false;
                for (int i = 0; i < CurrentCounter; i++)
                {
                    AssociationCounter = 0;
                    
                    // 画像の読み込み
                    src_img = new Bitmap(Image.FromFile(ImageCounterBox.Items[i].ToString()));
                    iWidth = src_img.Width;
                    iHeight = src_img.Height;
                    dst_img = new Bitmap(iWidth, iHeight);

                    // 特徴点+変形
                    ReadPoint(PointCounterBox.Items[i].ToString(), FlagIO); // 特徴点側
                    ReadAssociation(); // ※出力の関連付けも実行される
                    TransformationShape();
                    
                    // 画像の書き出し
                    string SaveImageFilename;
                    SaveImageFilename = FilenameBefore.Text + _ImageFilename[i] + FilenameAfter.Text + ".png";
                    dst_img.Save(FolderSaveLocation.Text + "\\" + SaveImageFilename);
                    OutputList.Items.Add(SaveImageFilename);

                    // メモリ解放
                    src_img.Dispose();
                    dst_img.Dispose();

                    // 表示
                    progressBar1.Value = (int)(100.0 * ((double)i / (double)CurrentCounter));
                    label10.Text = (i + 1).ToString() + "/" + CurrentCounter.ToString();
                    this.Update();
                }
            }
            else
            {
                MessageBox.Show("必要な情報を先に入力してください", "入力データの未選択");
            }
        }
        private void ReadPoint(string Filename, bool FlagIO)
        {
            PointsMax = 114;    // 最大点数
            PtsProperty = 12;   // プロパティ行数(座標以外の情報)
            Array.Resize<Point>(ref InputCoordinate, PointsMax + 1);
            Array.Resize<Point>(ref OutputCoordinate, PointsMax + 1);

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
                    InputCoordinate[i - PtsProperty].X = int.Parse(SplitText2[5]);
                    InputCoordinate[i - PtsProperty].Y = int.Parse(SplitText2[6]);
                }
                else
                {
                    OutputCoordinate[i - PtsProperty].X = int.Parse(SplitText2[5]);
                    OutputCoordinate[i - PtsProperty].Y = int.Parse(SplitText2[6]);
                }
            }
        }
        private void ReadAssociation()
        {
            // 関連付け
            for (int i = 0; i < 204; i++)
            {
                InputAssosiation[i].Reset();
                OutputAssosiation[i].Reset();
            }
            Association();
            AssociationCounter = 0;
        }
        private void Association()
        {
            if (cbLEye.Checked)     //左目
            {
                Substitution(27, 28, 34);
                Substitution(28, 29, 34);
                Substitution(29, 33, 34);
                Substitution(29, 32, 33);
                Substitution(29, 30, 32);
                Substitution(30, 31, 32);
            }
            if (cbREye.Checked)     //右目
            {
                Substitution(36, 37, 43);
                Substitution(37, 38, 43);
                Substitution(38, 42, 43);
                Substitution(38, 39, 42);
                Substitution(39, 41, 42);
                Substitution(39, 40, 41);
            }
            if (cbLEBlow.Checked)   //左眉
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
            }
            if (cbREBlow.Checked)   //右眉
            {
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
            }
            if (cbNose.Checked)     //鼻孔
            {

            }
            if (cbInMouse.Checked)  //口(内側)
            {
            }
            if (cbOutMouse.Checked) //口(外側)
            {
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
            }
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
            InputAssosiation[AssociationCounter].px[0] = InputCoordinate[p1].X;
            InputAssosiation[AssociationCounter].py[0] = InputCoordinate[p1].Y;
            InputAssosiation[AssociationCounter].px[1] = InputCoordinate[p2].X;
            InputAssosiation[AssociationCounter].py[1] = InputCoordinate[p2].Y;
            InputAssosiation[AssociationCounter].px[2] = InputCoordinate[p3].X;
            InputAssosiation[AssociationCounter].py[2] = InputCoordinate[p3].Y;

            // ターゲット座標
            OutputAssosiation[AssociationCounter].px[0] = OutputCoordinate[p1].X;
            OutputAssosiation[AssociationCounter].py[0] = OutputCoordinate[p1].Y;
            OutputAssosiation[AssociationCounter].px[1] = OutputCoordinate[p2].X;
            OutputAssosiation[AssociationCounter].py[1] = OutputCoordinate[p2].Y;
            OutputAssosiation[AssociationCounter].px[2] = OutputCoordinate[p3].X;
            OutputAssosiation[AssociationCounter].py[2] = OutputCoordinate[p3].Y;

            AssociationCounter++;
        }
        //--- 実行 ---//
        int StartX, StartY;
        int EndX, EndY;
        private void TransformationShape()
        {
            //--- アフィン変換 ---//
            for (AssociationCounter = 0; AssociationCounter < 204; AssociationCounter++)
            {
                StartEndPoint();
                AffineTransformation();
            }
        }
        private void StartEndPoint()
        {
            StartX = iWidth;		// スキャン開始位置:x
            StartY = iHeight;		// スキャン開始位置:y
            EndX = 0;				// スキャン終了位置:x
            EndY = 0;				// スキャン終了位置:y
            for (int i = 0; i < 3; i++)
            {
                if (StartX > InputAssosiation[AssociationCounter].px[i]) StartX = InputAssosiation[AssociationCounter].px[i];
                if (StartY > InputAssosiation[AssociationCounter].py[i]) StartY = InputAssosiation[AssociationCounter].py[i];
                if (EndX < InputAssosiation[AssociationCounter].px[i]) EndX = InputAssosiation[AssociationCounter].px[i];
                if (EndY < InputAssosiation[AssociationCounter].py[i]) EndY = InputAssosiation[AssociationCounter].py[i];
            }
        }

        //-- 入力点の代入 --//
        private void AffineTransformation()
        {
            double x, y;
            double alpha, beta, gamma;	// ベクトルの係数
            double denominator;			// β,γの分母

            // β,γの分母の計算
            denominator = -InputAssosiation[AssociationCounter].px[1] * InputAssosiation[AssociationCounter].py[2] +
                InputAssosiation[AssociationCounter].px[1] * InputAssosiation[AssociationCounter].py[0] +
                InputAssosiation[AssociationCounter].px[0] * InputAssosiation[AssociationCounter].py[2] +
                InputAssosiation[AssociationCounter].px[2] * InputAssosiation[AssociationCounter].py[1] -
                InputAssosiation[AssociationCounter].px[2] * InputAssosiation[AssociationCounter].py[0] -
                InputAssosiation[AssociationCounter].px[0] * InputAssosiation[AssociationCounter].py[1];

            // 画像左上(startX,startY)からスキャン
            for (int j = StartY; j < EndY; j++)
            {		// for(;iHeight;)
                for (int i = StartX; i < EndX; i++)
                {	// for(;iWidth;)
                    // ベクトルの各係数を求める Eq:X = ax1 + bx2 + gx3
                    beta = j * InputAssosiation[AssociationCounter].px[2] - InputAssosiation[AssociationCounter].px[0] * j -
                        InputAssosiation[AssociationCounter].px[2] * InputAssosiation[AssociationCounter].py[0] - InputAssosiation[AssociationCounter].py[2] * i +
                        InputAssosiation[AssociationCounter].px[0] * InputAssosiation[AssociationCounter].py[2] + i * InputAssosiation[AssociationCounter].py[0];
                    beta = beta / denominator;
                    gamma = i * InputAssosiation[AssociationCounter].py[1] - i * InputAssosiation[AssociationCounter].py[0] -
                        InputAssosiation[AssociationCounter].px[0] * InputAssosiation[AssociationCounter].py[1] - InputAssosiation[AssociationCounter].px[1] * j +
                        InputAssosiation[AssociationCounter].px[1] * InputAssosiation[AssociationCounter].py[0] + InputAssosiation[AssociationCounter].px[0] * j;
                    gamma = gamma / denominator;
                    alpha = 1 - (beta + gamma);
                    // 指定した3点内を処理する	[0 <= a,b,g <= 1]
                    if (alpha >= 0 && alpha <= 1 && beta >= 0 && beta <= 1 && gamma >= 0 && gamma <= 1)
                    {
                        // 式の適応
                        x = alpha * OutputAssosiation[AssociationCounter].px[0] + beta * OutputAssosiation[AssociationCounter].px[1] + gamma * OutputAssosiation[AssociationCounter].px[2];
                        y = alpha * OutputAssosiation[AssociationCounter].py[0] + beta * OutputAssosiation[AssociationCounter].py[1] + gamma * OutputAssosiation[AssociationCounter].py[2];

                        // ニアレストネイバー補間
                        if ((int)(x + 0.5) >= 0 && (int)(x + 0.5) < iWidth && (int)(y + 0.5) >= 0 && (int)(y + 0.5) < iHeight)
                        {
                            dst_img.SetPixel(i, j, src_img.GetPixel((int)(x + 0.5), (int)(y + 0.5)));
                        }
                    }
                }
            }
        }
    }
}
