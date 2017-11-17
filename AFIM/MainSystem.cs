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
    public partial class MainSystem : Form
    {
        String CurFileName = ""; // 現在のファイル名
        const string FileFilter = "Image File (*.bmp, *.jpg, *.png)|*.bmp;*.jpg";
        private string WindowTitle = "Untitled";

        public MainSystem()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        
        //*** File ***//
        public void NewImageItem_Click(object sender, EventArgs e)
        {
            UntitledWindow IEForm = new UntitledWindow();
            IEForm.MdiParent = this;
            IEForm.Text = WindowTitle + "-" + this.MdiChildren.Length.ToString();

            NewWindow NWForm = new NewWindow();
            NWForm.TbFilename.Text = IEForm.Text;
            NWForm.ShowDialog();

            if (NWForm.DialogResult == DialogResult.OK)
            {
                IEForm.PicBox.Width = int.Parse(NWForm.TbWidth.Text);
                IEForm.PicBox.Height = int.Parse(NWForm.TbHeight.Text);
                IEForm.Text = NWForm.TbFilename.Text;
                IEForm.Show();

                IEForm.UntitledWindow_Resize(sender, e); // 中心に移動させる
                IEForm.SetWindowSize(); // ウィンドウのサイズをイメージのサイズに合わせる
            }
            else
            {
                return;
            }
        }
        public void OpenFile(object sender, EventArgs e) 
        {
            // ファイルを開く
            OpenImageDialog.FileName = CurFileName;
            OpenImageDialog.Filter = FileFilter;
            if (OpenImageDialog.ShowDialog() == DialogResult.OK)
            {
                UntitledWindow IEForm = new UntitledWindow();
                IEForm.MdiParent = this;
                IEForm.Text = OpenImageDialog.FileName;
                IEForm.Show();

                CurFileName = OpenImageDialog.FileName;
                IEForm.PicBox.Image = Image.FromFile(CurFileName);
                IEForm.PicBox.Width = IEForm.PicBox.Image.Width;    // 画像の大きさを記憶
                IEForm.PicBox.Height = IEForm.PicBox.Image.Height;

                IEForm.UntitledWindow_Resize(sender, e); // 中心に移動させる
                IEForm.SetWindowSize(); // ウィンドウのサイズをイメージのサイズに合わせる
            }
        }
        private void CloseActiveItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.Close();
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in MdiChildren)
            {
                ChildForm.Close();
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //*** Image ***//
        private void FaceDetectItem_Click(object sender, EventArgs e)
        {
            FaceDetecter FDForm = new FaceDetecter();
            FDForm.MdiParent = this;
            FDForm.Show();
        }

        //*** View ***//
        private void ToolPanel_Click(object sender, EventArgs e)
        {
            ToolPanel.Visible = ToolPanelItem.Checked;
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip.Visible = ToolBarItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStrip.Visible = StatusBarItem.Checked;
        }
        //********************//

        private void LandmarkerItem_Click(object sender, EventArgs e)
        {
            Landmarker LMForm = new Landmarker();
            LMForm.MdiParent = this;
            LMForm.Show();
        }

        private void AligenmentItem_Click(object sender, EventArgs e)
        {
            Aligenment ALForm = new Aligenment();
            ALForm.MdiParent = this;
            ALForm.Show();
        }

        private void NShapeItem_Click(object sender, EventArgs e)
        {
            NormalizationForFacialShape NSForm = new NormalizationForFacialShape();
            NSForm.MdiParent = this;
            NSForm.Show();
        }

        private void NTextureItem_Click(object sender, EventArgs e)
        {
            NormalizationForFacialTexture NTForm = new NormalizationForFacialTexture();
            NTForm.MdiParent = this;
            NTForm.Show();
        }

        private void WarpingItem_Click(object sender, EventArgs e)
        {
            Warping WPForm = new Warping();
            WPForm.MdiParent = this;
            WPForm.Show();
        }

        private void ChangeTextureItem_Click(object sender, EventArgs e)
        {
            ChangeTexture CTForm = new ChangeTexture();
            CTForm.MdiParent = this;
            CTForm.Show();
        }

        //*** Window ***//
        private void CascadeItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);           //重ねて表示
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);      //横に並べて表示
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);    //縦に並べて表示
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in MdiChildren)
            {
                ChildForm.WindowState = FormWindowState.Minimized;
            }
            LayoutMdi(MdiLayout.ArrangeIcons);      //アイコンを並べて表示
        }
        private void ArrangeFormItem_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in MdiChildren)
            {
                ChildForm.WindowState = FormWindowState.Normal;
            }
        }


        //********************//
    }
}
