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
using OpenCvSharp.UserInterface;
using OpenCvSharp.Utilities;

namespace AFIM
{
    public partial class Warping : Form
    {
        Point[] i_points, o_points;
        Point[] f_points, z_points;
        int iWidth, iHeight;
        public class ClLat // 3(入力,出力)座標点
        {
            public double xdel;
            public double ydel;
            public double xfai;
            public double yfai;
            public double ome;
        }
        int current_counter;
        bool[] AllPixelFlag;
        struct dXY
        {
            public double X;
            public double Y;
        }
        dXY[] AllPixelValue;
        Bitmap bitmap_keep;

        // 画像ファイル・特徴点ファイルのフィルター
        const string ImageFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png|All file (*.*)|*.*";
        const string FileFilter = "Text File (*.txt, *.pts)|*.txt;*.pts";
        const string SaveImageFilter = "BMP (*.bmp)|*.bmp|JPG/JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png";
        string CurFileName = "";
        int MaxPoints, PtsProperty;                 // 最大点数, Ptsプロパティ
        
        public Warping()
        {
            InitializeComponent();
            MaxPoints = (int)NumUDFeaturePoints.Value;
            Array.Resize<Point>(ref i_points, 0);
            Array.Resize<Point>(ref o_points, 0);
            Array.Resize<Point>(ref f_points, 0);
            Array.Resize<Point>(ref z_points, 0);
            pbResult.Image = new Bitmap(pbResult.Width, pbResult.Height);
        }

        //-- 画像データ読み込み --//
        private void FileOpen_Click(object sender, EventArgs e)
        {
            // ファイルを開く
            string CurFileName = "";
            string FileFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png|All file (*.*)|*.*";
            OpenFileDialog1.FileName = CurFileName;
            OpenFileDialog1.Filter = FileFilter;
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CurFileName = OpenFileDialog1.FileName;
                pbOriginal.Image = Image.FromFile(CurFileName);
                pbOriginalZoom.Image = Image.FromFile(CurFileName);
                bitmap_keep = new Bitmap(pbOriginal.Image); 
                iWidth = pbOriginal.Image.Width;
                iHeight = pbOriginal.Image.Height;
            }
        }

        // 特徴点取得(入力側)
        private void BtnPt1_Click(object sender, EventArgs e)
        {
            OpenFileDialog2.Filter = FileFilter;

            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                PtsProperty = 12;   // プロパティ行数(座標以外の情報)
                Array.Resize<Point>(ref i_points, MaxPoints + 1);
                Array.Resize<Point>(ref f_points, MaxPoints + 1);
                Array.Resize<Point>(ref z_points, MaxPoints + 1);
                i_points.Initialize();

                string Filename = OpenFileDialog2.FileName;

                string StrText = "";
                using (StreamReader sr = new StreamReader(@Filename)) StrText = sr.ReadToEnd();

                // string.Splitで分割
                string[] SplitText1;
                SplitText1 = StrText.Replace("\r\n", "\n").Split('\n');
                for (int i = PtsProperty; i <= PtsProperty + MaxPoints; i++)
                {
                    string[] SplitText2;
                    SplitText2 = SplitText1[i].Split(' ');

                    // 値をセット
                    i_points[i - PtsProperty].X = int.Parse(SplitText2[5]);
                    i_points[i - PtsProperty].Y = int.Parse(SplitText2[6]);
                    z_points[i - PtsProperty].X = int.Parse(SplitText2[5]);
                    z_points[i - PtsProperty].Y = int.Parse(SplitText2[6]);
                }
                this.Refresh();
            }
        }
        // 特徴点取得(出力側)
        private void BtnPt2_Click(object sender, EventArgs e)
        {
            OpenFileDialog2.Filter = FileFilter;

            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                PtsProperty = 12;   // プロパティ行数(座標以外の情報)
                Array.Resize<Point>(ref o_points, MaxPoints + 1);

                string Filename = OpenFileDialog2.FileName;

                string StrText = "";
                using (StreamReader sr = new StreamReader(@Filename)) StrText = sr.ReadToEnd();

                // string.Splitで分割
                string[] SplitText1;
                SplitText1 = StrText.Replace("\r\n", "\n").Split('\n');
                for (int i = PtsProperty; i <= PtsProperty + MaxPoints; i++)
                {
                    string[] SplitText2;
                    SplitText2 = SplitText1[i].Split(' ');

                    // 値をセット
                    o_points[i - PtsProperty].X = int.Parse(SplitText2[5]);
                    o_points[i - PtsProperty].Y = int.Parse(SplitText2[6]);
                }
                this.Refresh();
            }
        }
        private void ToolBtnSave_Click(object sender, EventArgs e)
        {
            if (pbResult.Image == null)
                return;
            SaveImgDialog.FileName = this.Text;
            SaveImgDialog.Filter = SaveImageFilter;
            if (SaveImgDialog.ShowDialog(this) == DialogResult.OK)
            {
                CurFileName = SaveImgDialog.FileName; // 名前入力
                pbResult.Image.Save(CurFileName);
            }
        }
        //=== B-Spline変換===//

        private void ToolBtnRun_Click(object sender, EventArgs e)
        {
            // 先に特徴点の読み込みが必要
            if (i_points.Count() > 0 && o_points.Count() > 0)
                InitRun();
            else
                return;

            int MultiLevel = (int)(NumUDMultiLevel.Value - 1);
            int lat_bw;
            ClLat[] cl;
            lat_bw = (int)NumUDLattice.Value * 2;	// 初期格子の間隔

            // Basic MBA Algorithm
            for (int k = 0; k <= MultiLevel; k++)
            {
                // 時間計測
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start(); // ミリ秒単位で出力

                // 新しい格子を作成
                lat_bw = lat_bw / 2;
                cl = InitSpline(lat_bw, k);

                // Compute f(k) from P(k) by the 
                ObtainWeight(lat_bw, cl, k);

                // Compute z(k+1)c = z(k)c - f(k)(x,y) for each data point
                BSpline(lat_bw, cl, k);
                for (int p = 0; p < current_counter; p++)
                {
                    z_points[p].X -= f_points[p].X;
                    z_points[p].Y -= f_points[p].Y;
                }

                // 画像出力
                Output(k);

                // 画像内走査の時間は少ない(ピクセル操作で時間がかかる)
                sw.Stop();
                StatusRunTime.Text = StatusRunTime.Text + " Level" + (k + 1).ToString() + ": " +
                    ((double)sw.ElapsedMilliseconds / 1000).ToString() + "sec";
            } 
        }

        //--- スプライン初期化 ---//
        private void InitRun()
        {
            StatusRunTime.Text = "";

            // 走査ピクセル範囲の初期化
            AllPixelFlag = new bool[iWidth * iHeight];
            PixelFlag(false, 0, iWidth, 0, iHeight);
            AllPixelValue = new dXY[iWidth * iHeight];
            PixelValue(0.0, 0, iWidth, 0, iHeight);

            for (int p = 0; p < i_points.Count(); p++)
            {
                z_points[p].X = i_points[p].X;
                z_points[p].Y = i_points[p].Y;
            }

            // 現在の点数を取得
            if (i_points.Count() > o_points.Count())
                current_counter = o_points.Count();
            else
                current_counter = i_points.Count();
        }
        private ClLat[] InitSpline(int lat_bw, int MultiLevel)
        {
            int lat_w = (iWidth / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);        // 横幅全体の格子数
            int lat_h = (iHeight / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);      // 縦幅全体の格子数
            ClLat[] cl = new ClLat[lat_w * lat_h];                                  // 格子[全体の格子数]
            
            // 全格子の各座標を格納
            for (int j = 0; j < lat_h; j++)
            {
                for (int i = 0; i < lat_w; i++)
                {
                    cl[j * lat_w + i] = new ClLat();
                    cl[j * lat_w + i].xdel = 0;
                    cl[j * lat_w + i].ydel = 0;
                    cl[j * lat_w + i].ome = 0;
                    cl[j * lat_w + i].xfai = 0;
                    cl[j * lat_w + i].yfai = 0;
                }
            }
            return cl;
        }

        //-- Bスプライン基底関数 --//
        private double Basic(int num, double t)
        {
            double[] B = new double[4];

            if (num == 0)
                B[num] = ((1 - t) * (1 - t) * (1 - t)) / 6;
            else if (num == 1)
                B[num] = (3 * t * t * t - 6 * t * t + 4) / 6;
            else if (num == 2)
                B[num] = (-3 * t * t * t + 3 * t * t + 3 * t + 1) / 6;
            else if (num == 3)
                B[num] = (t * t * t) / 6;
            return (B[num]);
        }

        private void SumWeight(int lat_bw, ClLat[] cl, int MultiLevel, int lat_bw_ref, ClLat[] cl_ref, int MaxLevel)
        {
            int lat_w = (iWidth / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);      // 横幅全体の格子数
            int lat_h = (iHeight / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);     // 縦幅全体の格子数
            int lat_w_ref = (iWidth / lat_bw_ref) + 3 * (int)Math.Pow(2, MaxLevel);   // 横幅全体の格子数
            int lat_h_ref = (iHeight / lat_bw_ref) + 3 * (int)Math.Pow(2, MaxLevel);  // 縦幅全体の格子数

            for (int j = 0; j < lat_h; j++)
            {
                for (int i = 0; i < lat_w; i++)
                {
                    cl_ref[(j * lat_w + i) * (int)Math.Pow(2, MaxLevel - MultiLevel)].xfai += cl[j * lat_w + i].xfai;
                    cl_ref[(j * lat_w + i) * (int)Math.Pow(2, MaxLevel - MultiLevel)].yfai += cl[j * lat_w + i].yfai;
                }
            }

        }
        //-- 格子の大きさを求める --//
        private void ObtainWeight(int lat_bw, ClLat[] cl, int MultiLevel)
        {
            int lat_w = (iWidth / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);      // 横幅全体の格子数
            int lat_h = (iHeight / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);     // 縦幅全体の格子数

            // 各点からの格子の大きさ
            for (int p = 0; p < current_counter; p++)
            {
                int x_dtmp = z_points[p].X % lat_bw;	// 格子までの差:x
                int y_dtmp = z_points[p].Y % lat_bw;	// 格子までの差:y
                int i = ((int)(z_points[p].X - x_dtmp) / lat_bw) - 1;	// [x]-1:格子上の点x
                int j = ((int)(z_points[p].Y - y_dtmp) / lat_bw) - 1;	// [y]-1:格子上の点y
                double s = (double)x_dtmp / (double)lat_bw;	// 格子までの差(0-1)
                double t = (double)y_dtmp / (double)lat_bw;	// 格子までの差(0-1)
                double Wab = 0;
                for (int b = 0; b <= 3; b++)
                {		// row
                    for (int a = 0; a <= 3; a++)
                    {	// col
                        Wab = Wab + (Basic(a, s) * Basic(b, t)) * (Basic(a, s) * Basic(b, t));
                    }
                }
                double[] W = new double[16];
                double[] x_fai = new double[16];
                double[] y_fai = new double[16];
                for (int l = 0; l <= 3; l++)
                {		// row
                    for (int k = 0; k <= 3; k++)
                    {	// col
                         W[l * 4 + k] = Basic(k, s) * Basic(l, t);
                        x_fai[l * 4 + k] = (W[l * 4 + k] * (z_points[p].X - o_points[p].X)) / Wab;
                        y_fai[l * 4 + k] = (W[l * 4 + k] * (z_points[p].Y - o_points[p].Y)) / Wab;
                        int itmp = (j + l + 1) * lat_w + (i + k + 1);
                        cl[itmp].xdel = cl[itmp].xdel + W[l * 4 + k] * W[l * 4 + k] * x_fai[l * 4 + k];
                        cl[itmp].ydel = cl[itmp].ydel + W[l * 4 + k] * W[l * 4 + k] * y_fai[l * 4 + k];
                        cl[itmp].ome = cl[itmp].ome + W[l * 4 + k] * W[l * 4 + k];
                    }
                }
            }
            // 範囲内のオーバーラップを考慮
            for (int j = 0; j < lat_h; j++)
            {
                for (int i = 0; i < lat_w; i++)
                {
                    if (cl[j * lat_w + i].ome != 0)
                    {
                        double omega = 0;
                        for (int l = 0; l <= 3; l++)
                        {		// row
                            for (int k = 0; k <= 3; k++)
                            {	// col
                                int itmp = (j + l - 1) * lat_w + (i + k - 1);
                                if (itmp > 0 && itmp < lat_h * lat_w)
                                {
                                    cl[j * lat_w + i].xfai = cl[j * lat_w + i].xfai + cl[itmp].xdel;
                                    cl[j * lat_w + i].yfai = cl[j * lat_w + i].yfai + cl[itmp].ydel;
                                    omega = omega + cl[itmp].ome;
                                }
                            }
                        }
                        cl[j * lat_w + i].xfai = (cl[j * lat_w + i].xfai / omega);
                        cl[j * lat_w + i].yfai = (cl[j * lat_w + i].yfai / omega);
                    }
                    else
                    {
                        cl[j * lat_w + i].xfai = 0;
                        cl[j * lat_w + i].yfai = 0;
                    }
                }
            }
        }

        //-- B-Spline --//
        private void BSpline(int lat_bw, ClLat[] cl, int MultiLevel)
        {
            int lat_w = (iWidth / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);      // 横幅全体の格子数
            int lat_h = (iHeight / lat_bw) + 3 * (int)Math.Pow(2, MultiLevel);     // 縦幅全体の格子数

            int transform_frame = 1;
            int frameNum = 1;

            // 画像全体の変形
            for (int j = 0; j < iHeight; j++)
            {
                for (int i = 0; i < iWidth; i++)
                {
                    double fx = 0;
                    double fy = 0;

                    if (AllPixelFlag[i + iWidth * j] == false)
                    {
                        int x_dtmp = i % lat_bw;
                        int y_dtmp = j % lat_bw;
                        int inw = i / lat_bw;
                        int inh = j / lat_bw;
                        double s = (double)x_dtmp / (double)lat_bw;
                        double t = (double)y_dtmp / (double)lat_bw;

                        for (int l = 0; l <= 3; l++)
                        {		// row
                            for (int k = 0; k <= 3; k++)
                            {	// col
                                int itmp = (inh + l - 1) * lat_w + (inw + k - 1);
                                if (itmp > 0 && itmp < lat_w * lat_h)
                                {
                                    fx = fx + Basic(k, s) * Basic(l, t) * (cl[itmp].xfai * ((double)frameNum / (double)transform_frame));
                                    fy = fy + Basic(k, s) * Basic(l, t) * (cl[itmp].yfai * ((double)frameNum / (double)transform_frame));
                                }
                            }
                        }
                        // 入力特徴点の移動後の座標
                        for (int p = 0; p < current_counter; p++)
                        {
                            if (z_points[p].X == i && z_points[p].Y == j)
                            {
                                f_points[p].X = ( (int)(fx + 0.5));
                                f_points[p].Y = ( (int)(fy + 0.5));
                            }
                        }
                    }

                    // 画素の変更なし
                    if (fx == 0 && fy == 0)
                        AllPixelFlag[i + iWidth * j] = true;
                    AllPixelValue[i + iWidth * j].X += fx;
                    AllPixelValue[i + iWidth * j].Y += fy;
                }
            }
        }

        //-- 書き出し --//
        private void Output(int MultiLevel)
        {
            Bitmap bit_tmp;
            if (MultiLevel == 0)
                bit_tmp = new Bitmap(bitmap_keep);
            else if (MultiLevel == 1)
                bit_tmp = new Bitmap(pbMultiLevel1.Image);
            else if (MultiLevel == 2)
                bit_tmp = new Bitmap(pbMultiLevel2.Image);
            else if (MultiLevel == 3)
                bit_tmp = new Bitmap(pbMultiLevel3.Image);
            else if (MultiLevel == 4)
                bit_tmp = new Bitmap(pbMultiLevel4.Image);
            else
                bit_tmp = new Bitmap(pbMultiLevel5.Image);

            Bitmap bitmap_out = new Bitmap(bit_tmp);
            if(cbBackBlack.Checked == true)
                bitmap_out = new Bitmap(iWidth, iHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (IplImage SrcImg = new IplImage(bitmap_keep.Width, bitmap_keep.Height, BitDepth.U8, 3))
            using (IplImage DstImg = new IplImage(bitmap_keep.Width, bitmap_keep.Height, BitDepth.U8, 3))
            {
                SrcImg.CopyFrom(bitmap_keep);
                DstImg.CopyFrom(bitmap_out);
                                // 画像全体の変形
                for (int j = 0; j < iHeight; j++)
                {
                    for (int i = 0; i < iWidth; i++)
                    {
                        double x = i + AllPixelValue[i + iWidth * j].X;
                        double y = j + AllPixelValue[i + iWidth * j].Y;
                        // 補間 + 結果画像へ出力
                        if (AllPixelFlag[i + iWidth * j] == false)
                        {
                            if ((int)(x + 0.5) >= 0 && (int)(x + 0.5) < iWidth && (int)(y + 0.5) >= 0 && (int)(y + 0.5) < iHeight)
                            {
                                if (RadioBtnNN.Checked == true)
                                    NearestNeighbor(SrcImg, DstImg, x, y, i, j);
                                if (RadioBtnBilinear.Checked == true)
                                    Bilinear(SrcImg, DstImg, x, y, i, j);
                            }
                        }
                    }
                }
                bit_tmp = DstImg.ToBitmap();
            }
            bitmap_out = bit_tmp;
            pbResult.Image = bitmap_out;
            pbResultZoom.Image = bit_tmp;
            
            if (MultiLevel == 0)
                pbMultiLevel1.Image = bitmap_out;
            else if (MultiLevel == 1)
                pbMultiLevel2.Image = bitmap_out;
            else if (MultiLevel == 2)
                pbMultiLevel3.Image = bitmap_out;
            else if (MultiLevel == 3)
                pbMultiLevel4.Image = bitmap_out;
            else if (MultiLevel == 4)
                pbMultiLevel5.Image = bitmap_out;
            else
                pbMultiLevel5.Image = bitmap_out;
        }

        // ピクセル走査フラグ
        private void PixelFlag(bool pix_flag, int Xstart, int Xend, int Ystart, int Yend)
        {
            // 画像領域内に変更
            if (Xstart < 0) Xstart = 0;
            if (Ystart < 0) Ystart = 0;
            if (Xend > iWidth) Xend = iWidth;
            if (Yend > iHeight) Yend = iHeight;

            for (int i = Ystart; i < Yend; i++)
            {
                for (int j = Xstart; j < Xend; j++)
                {
                    if (j < iWidth && j >= 0 && i < iHeight && i >= 0)
                    {
                        AllPixelFlag[j + i * Xend] = pix_flag;
                    }
                }
            }
        }
        private void PixelValue(double value, int Xstart, int Xend, int Ystart, int Yend)
        {
            // 画像領域内に変更
            if (Xstart < 0) Xstart = 0;
            if (Ystart < 0) Ystart = 0;
            if (Xend > iWidth) Xend = iWidth;
            if (Yend > iHeight) Yend = iHeight;

            for (int i = Ystart; i < Yend; i++)
            {
                for (int j = Xstart; j < Xend; j++)
                {
                    if (j < iWidth && j >= 0 && i < iHeight && i >= 0)
                    {
                        AllPixelValue[j + i * Xend].X = value;
                        AllPixelValue[j + i * Xend].Y = value;
                    }
                }
            }
        }
        //-- 補間 --//
        //ニアレストネイバー
        private void NearestNeighbor(IplImage src_img, IplImage dst_img, double inx, double iny, int outx, int outy)
        {
            unsafe
            {
                byte* ptrSrc = (byte*)src_img.ImageData;    // 画素データへのポインタ
                byte* ptrDst = (byte*)dst_img.ImageData;    // 画素データへのポインタ
                int offset1 = (src_img.WidthStep * (int)(iny + 0.5)) + ((int)(inx + 0.5) * 3);
                int offset2 = (dst_img.WidthStep * outy) + (outx * 3);
                ptrDst[offset2 + 0] = ptrSrc[offset1 + 0];    // B
                ptrDst[offset2 + 1] = ptrSrc[offset1 + 1];    // G
                ptrDst[offset2 + 2] = ptrSrc[offset1 + 2];    // R
            }
            //* その他ピクセル操作 *//
            //int P = bitmap_keep.GetPixel((int)(x + 0.5), (int)(y + 0.5)).ToArgb();    // ピクセルデータの取得
            //bitmap_out.SetPixel(i, j, Color.FromArgb(P));  // ピクセルデータの設定
            //DstImg[j, i] = SrcImg[(int)(y + 0.5), (int)(x + 0.5)];
        }

        //バイリニア
        private void Bilinear(IplImage src_img, IplImage dst_img, double inx, double iny, int outx, int outy)
        {
            int bx = (int)(inx);    // 四捨五入の値:X
            int by = (int)(iny);    // 四捨五入の値:Y

            double tmpX1 = bx + 1 - inx;
            double tmpY1 = by + 1 - iny;
            double tmpX2 = inx - bx;
            double tmpY2 = iny - by;

            double S1 = tmpX2 * tmpY1;
            double S2 = tmpX1 * tmpY1;
            double S3 = tmpX1 * tmpY2;
            double S4 = tmpX2 * tmpY2;

            if (bx + 1 < iWidth && by + 1 < iHeight)
            {
                CvColor c1 = src_img[by, bx + 1];
                CvColor c2 = src_img[by, bx];
                CvColor c3 = src_img[by + 1, bx];
                CvColor c4 = src_img[by + 1, bx + 1];
                CvColor c = new CvColor
                {
                    B = (byte)(Math.Round(c1.B * S1 + c2.B * S2 + c3.B * S3 + c4.B * S4)),
                    G = (byte)(Math.Round(c1.G * S1 + c2.G * S2 + c3.G * S3 + c4.G * S4)),
                    R = (byte)(Math.Round(c1.R * S1 + c2.R * S2 + c3.R * S3 + c4.R * S4)),
                };

                dst_img[outy, outx] = new CvColor
                {
                    B = c.B,
                    G = c.G,
                    R = c.R,
                };
            }
            else
            {
                CvColor c = src_img[by, bx];
                dst_img[outy, outx] = new CvColor
                {
                    B = (byte)(Math.Round(c.B * 1.0)),
                    G = (byte)(Math.Round(c.G * 1.0)),
                    R = (byte)(Math.Round(c.R * 1.0)),
                };
            }
        }
    
        private void pbOriginal_Paint(object sender, PaintEventArgs e)
        {
            int radius = (int)NumUDRadius.Value; // 半径
            Graphics g = e.Graphics;

            // 点の表示
            Pen pen1 = new Pen(Color.Red, radius);
            Pen pen2 = new Pen(Color.Blue, radius);

            if (i_points.Count() > 0)
            {
                for (int i = 0; i < i_points.Count(); i++)
                {
                    int pix, piy;
                    pix = i_points[i].X;
                    piy = i_points[i].Y;

                    // 点の描画(楕円)
                    if (cbDisplayP.Checked) g.DrawEllipse(pen1, pix, piy, radius, radius);
                }
            }
            if (o_points.Count() > 0)
            {
                for (int i = 0; i < i_points.Count(); i++)
                {
                    int pox, poy;
                    pox = o_points[i].X;
                    poy = o_points[i].Y;

                    // 点の描画(楕円)
                    if (cbDisplayP.Checked) g.DrawEllipse(pen2, pox, poy, radius, radius);
                }
            }
        }
        private void pbResult_Paint(object sender, PaintEventArgs e)
        {
            pbOriginal_Paint(sender, e);
        }
        private void pbMultiLevel1_Paint(object sender, PaintEventArgs e)
        {
            pbOriginal_Paint(sender, e);
        }
        private void pbMultiLevel2_Paint(object sender, PaintEventArgs e)
        {
            pbOriginal_Paint(sender, e);
        }
        private void pbMultiLevel3_Paint(object sender, PaintEventArgs e)
        {
            pbOriginal_Paint(sender, e);
        }
        private void pbMultiLevel4_Paint(object sender, PaintEventArgs e)
        {
            pbOriginal_Paint(sender, e);
        }
        private void pbMultiLevel5_Paint(object sender, PaintEventArgs e)
        {
            pbOriginal_Paint(sender, e);
        }
        private void cbDisplayP_CheckedChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
