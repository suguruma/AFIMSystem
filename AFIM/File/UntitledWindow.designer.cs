namespace AFIM
{
    partial class UntitledWindow
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UntitledWindow));
            this.OpenImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveImgDialog = new System.Windows.Forms.SaveFileDialog();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.ImgPanel = new System.Windows.Forms.Panel();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolBtnTool = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolPen = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolEraser = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSelectArea = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBtnInit = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBtnOperate = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolBtnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBtnMonoclome = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBtnSizeCutS = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.ImgPanel.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenImgDialog
            // 
            this.OpenImgDialog.FileName = "OpenImgDialog";
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.Color.White;
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Location = new System.Drawing.Point(0, 25);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(400, 400);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicBox.TabIndex = 2;
            this.PicBox.TabStop = false;
            this.PicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.PicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.PicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // ImgPanel
            // 
            this.ImgPanel.AutoScroll = true;
            this.ImgPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ImgPanel.Controls.Add(this.PicBox);
            this.ImgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgPanel.Location = new System.Drawing.Point(0, 0);
            this.ImgPanel.Name = "ImgPanel";
            this.ImgPanel.Size = new System.Drawing.Size(634, 540);
            this.ImgPanel.TabIndex = 3;
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 540);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(634, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "StatusBar";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBtnInit,
            this.ToolBtnOpen,
            this.ToolBtnSave,
            this.toolStripSeparator,
            this.ToolBtnTool,
            this.ToolBtnOperate});
            this.ToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(634, 25);
            this.ToolBar.TabIndex = 4;
            this.ToolBar.Text = "ToolBar";
            // 
            // ToolBtnTool
            // 
            this.ToolBtnTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolPen,
            this.ToolEraser,
            this.ToolSelectArea});
            this.ToolBtnTool.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnTool.Image")));
            this.ToolBtnTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnTool.Name = "ToolBtnTool";
            this.ToolBtnTool.Size = new System.Drawing.Size(64, 22);
            this.ToolBtnTool.Text = "Tool";
            // 
            // ToolPen
            // 
            this.ToolPen.Name = "ToolPen";
            this.ToolPen.Size = new System.Drawing.Size(161, 22);
            this.ToolPen.Text = "Pen(&P)";
            this.ToolPen.Click += new System.EventHandler(this.ToolPen_Click);
            // 
            // ToolEraser
            // 
            this.ToolEraser.Name = "ToolEraser";
            this.ToolEraser.Size = new System.Drawing.Size(161, 22);
            this.ToolEraser.Text = "Eraser(&E)";
            this.ToolEraser.Click += new System.EventHandler(this.ToolEraser_Click);
            // 
            // ToolSelectArea
            // 
            this.ToolSelectArea.Name = "ToolSelectArea";
            this.ToolSelectArea.Size = new System.Drawing.Size(161, 22);
            this.ToolSelectArea.Text = "Select Area(&S)";
            this.ToolSelectArea.Click += new System.EventHandler(this.ToolSelectArea_Click);
            // 
            // ToolBtnInit
            // 
            this.ToolBtnInit.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnInit.Image")));
            this.ToolBtnInit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnInit.Name = "ToolBtnInit";
            this.ToolBtnInit.Size = new System.Drawing.Size(54, 22);
            this.ToolBtnInit.Text = "New";
            this.ToolBtnInit.Click += new System.EventHandler(this.InitImageItem_Click);
            // 
            // ToolBtnOpen
            // 
            this.ToolBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnOpen.Image")));
            this.ToolBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnOpen.Name = "ToolBtnOpen";
            this.ToolBtnOpen.Size = new System.Drawing.Size(58, 22);
            this.ToolBtnOpen.Text = "Open";
            this.ToolBtnOpen.Click += new System.EventHandler(this.ToolBtnOpen_Click);
            // 
            // ToolBtnSave
            // 
            this.ToolBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnSave.Image")));
            this.ToolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnSave.Name = "ToolBtnSave";
            this.ToolBtnSave.Size = new System.Drawing.Size(57, 22);
            this.ToolBtnSave.Text = "Save";
            this.ToolBtnSave.Click += new System.EventHandler(this.SaveAsItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // ToolBtnOperate
            // 
            this.ToolBtnOperate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBtnClear,
            this.ToolBtnMonoclome,
            this.ToolBtnSizeCutS});
            this.ToolBtnOperate.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnOperate.Image")));
            this.ToolBtnOperate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnOperate.Name = "ToolBtnOperate";
            this.ToolBtnOperate.Size = new System.Drawing.Size(84, 22);
            this.ToolBtnOperate.Text = "Operate";
            // 
            // ToolBtnClear
            // 
            this.ToolBtnClear.Name = "ToolBtnClear";
            this.ToolBtnClear.Size = new System.Drawing.Size(171, 22);
            this.ToolBtnClear.Text = "Clear(&C)";
            this.ToolBtnClear.Click += new System.EventHandler(this.OpClear_Click);
            // 
            // ToolBtnMonoclome
            // 
            this.ToolBtnMonoclome.Name = "ToolBtnMonoclome";
            this.ToolBtnMonoclome.Size = new System.Drawing.Size(171, 22);
            this.ToolBtnMonoclome.Text = "Monochrome(&M)";
            this.ToolBtnMonoclome.Click += new System.EventHandler(this.OpMono_Click);
            // 
            // ToolBtnSizeCutS
            // 
            this.ToolBtnSizeCutS.Name = "ToolBtnSizeCutS";
            this.ToolBtnSizeCutS.Size = new System.Drawing.Size(171, 22);
            this.ToolBtnSizeCutS.Text = "Size Cut(&S)";
            this.ToolBtnSizeCutS.Click += new System.EventHandler(this.OpReduce_Click);
            // 
            // UntitledWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 562);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.ImgPanel);
            this.Controls.Add(this.StatusBar);
            this.Name = "UntitledWindow";
            this.Text = "Untitled";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.UntitledWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ImgPanel.ResumeLayout(false);
            this.ImgPanel.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenImgDialog;
        private System.Windows.Forms.SaveFileDialog SaveImgDialog;
        public System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Panel ImgPanel;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton ToolBtnInit;
        private System.Windows.Forms.ToolStripButton ToolBtnOpen;
        private System.Windows.Forms.ToolStripButton ToolBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSplitButton ToolBtnTool;
        private System.Windows.Forms.ToolStripMenuItem ToolPen;
        private System.Windows.Forms.ToolStripMenuItem ToolEraser;
        private System.Windows.Forms.ToolStripMenuItem ToolSelectArea;
        private System.Windows.Forms.ToolStripDropDownButton ToolBtnOperate;
        private System.Windows.Forms.ToolStripMenuItem ToolBtnClear;
        private System.Windows.Forms.ToolStripMenuItem ToolBtnMonoclome;
        private System.Windows.Forms.ToolStripMenuItem ToolBtnSizeCutS;
    }
}

