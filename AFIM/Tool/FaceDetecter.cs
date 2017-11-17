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

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using OpenCvSharp;

namespace AFIM
{
    public partial class FaceDetecter : Form
    {
        private PictureBox pb1;
        private Bitmap bmp;

        private Image<Bgr, Byte> _oldimg = null;
        private Image<Bgr, Byte> _img = null;
        //private readonly Bitmap otherfile;

        String CurImageName = ""; // 現在のファイル名
        const string ImageFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png|All file (*.*)|*.*";
        //const string xmlpath = "../Resources/";

        public FaceDetecter()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.cmbHaarcascade.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var item in GetHaarCascade())
            {
                //this.cmbHaarcascade.Items.Add(new ComboItem(new HaarCascade(Properties.Resources.haarcascade_frontalface_default + "xml"), item));
                this.cmbHaarcascade.Items.Add(new ComboItem(new HaarCascade("haarcascade_frontalface_default.xml"), item));
                //this.cmbHaarcascade.Items.Add(new ComboItem(new HaarCascade(xmlpath + item + ".xml"), item));
            }
            this.cmbHaarcascade.SelectedIndex = 0;            
        }

        private IEnumerable<string> GetHaarCascade()
        {
            yield return "haarcascade_frontalface_alt";
            yield return "haarcascade_frontalface_alt2";
            yield return "haarcascade_frontalface_alt_tree";
            yield return "haarcascade_frontalface_default";
            yield return "haarcascade_eye";
            yield return "haarcascade_eye_tree_eyeglasses";
            yield return "haarcascade_fullbody";
            yield return "haarcascade_lowerbody";
            yield return "haarcascade_profileface";
            yield return "haarcascade_upperbody";
        }

        private void Image_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.FileName = "default.jpg";
                ofd.InitialDirectory = @"D:\test\img\";
                ofd.Filter = "画像ファイル(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|すべてのファイル(*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.Title = "対象の画像ファイルを選択してください";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    _img = new Image<Bgr, Byte>(ofd.FileName); ;
                    _oldimg = _img.Clone();
                    this.pictureBox1.Image = _img.ToBitmap();
                }
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (_img == null) return;

            //モノクロ変換
            var imgGray = _img.Convert<Gray, Byte>();

            Bitmap img1 = _img.Bitmap;

            var hc = (ComboItem)this.cmbHaarcascade.SelectedItem;
            foreach (var face in imgGray.DetectHaarCascade(hc.HaarCascade, (double)numericUpDown2.Value, (int)numericUpDown1.Value, 
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(70, 70)).First())
            {
                var ori_rect = face.rect;
                var rect = face.rect;
                using (var g = Graphics.FromImage(img1))
                {
                    var w = Convert.ToSingle(rect.Width * 1.8);
                    var h = Convert.ToSingle(rect.Height * 1.5);

                    float x = rect.X - ((w - rect.Width) / 3);
                    float y = rect.Y - (h - rect.Height) / 2 - rect.Height / 6;
                    //g.DrawImage(_yukkuri, x, y, w, h);
                }

                if (chkFaceDetect.Checked)
                {
                    //_img.Draw(rect, new Bgr(Color.Yellow), 1);
                    _img.Draw(ori_rect, new Bgr(Color.Yellow), 1);
                    img1 = _img.Bitmap;
                }
            }

            this.pictureBox1.Image = img1;
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (_img == null) return;
            _img = _oldimg.Clone();
            this.pictureBox1.Image = _oldimg.ToBitmap();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null) return;

            using (var sfd = new SaveFileDialog())
            {
                sfd.FileName = ofd.FileName;

                sfd.InitialDirectory = @"C:\";
                sfd.Filter = "PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.Title = "保存先のファイルを選択してください";

                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog(this) == DialogResult.OK)
                    this.pictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openImageDialog1.FileName = CurImageName;
            openImageDialog1.Filter = ImageFilter;
            if (openImageDialog1.ShowDialog() == DialogResult.OK)
            {
                CurImageName = openImageDialog1.FileName;
                pictureBox2.Image = Image.FromFile(CurImageName);
                pb1 = pictureBox1;
                bmp = new Bitmap(pictureBox2.Image);
                pictureBox1.Enabled = true;
                //this.Text = FormText + " [" + CurImageName + "]";
            }
        }

    }

    public class ComboItem
    {
        private HaarCascade _haarCascade = null;
        private string _name = null;

        public ComboItem(HaarCascade haarCascade, string name)
        {
            _haarCascade = haarCascade;
            _name = name;
        }

        public HaarCascade HaarCascade
        {
            get { return _haarCascade; }
        }

        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
