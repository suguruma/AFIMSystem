namespace AFIM
{
    partial class Warping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warping));
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TabCtrlImage = new System.Windows.Forms.TabControl();
            this.TpOriginal = new System.Windows.Forms.TabPage();
            this.TbResult = new System.Windows.Forms.TabPage();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.Tb3 = new System.Windows.Forms.TabPage();
            this.pbMultiLevel1 = new System.Windows.Forms.PictureBox();
            this.Tb4 = new System.Windows.Forms.TabPage();
            this.pbMultiLevel2 = new System.Windows.Forms.PictureBox();
            this.Tb5 = new System.Windows.Forms.TabPage();
            this.pbMultiLevel3 = new System.Windows.Forms.PictureBox();
            this.Tb6 = new System.Windows.Forms.TabPage();
            this.pbMultiLevel4 = new System.Windows.Forms.PictureBox();
            this.Tb7 = new System.Windows.Forms.TabPage();
            this.pbMultiLevel5 = new System.Windows.Forms.PictureBox();
            this.Tb8 = new System.Windows.Forms.TabPage();
            this.pbOriginalZoom = new System.Windows.Forms.PictureBox();
            this.Tb9 = new System.Windows.Forms.TabPage();
            this.pbResultZoom = new System.Windows.Forms.PictureBox();
            this.NumUDLattice = new System.Windows.Forms.NumericUpDown();
            this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolBtnOpenImage = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnFeaturePoints = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnWarpPoints = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnRun = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBtnHelp = new System.Windows.Forms.ToolStripButton();
            this.NumUDFeaturePoints = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabBarLblLevel = new System.Windows.Forms.Label();
            this.cbBackBlack = new System.Windows.Forms.CheckBox();
            this.NumUDMultiLevel = new System.Windows.Forms.NumericUpDown();
            this.cbDisplayP = new System.Windows.Forms.CheckBox();
            this.gBoxInterpolation = new System.Windows.Forms.GroupBox();
            this.RadioBtnNN = new System.Windows.Forms.RadioButton();
            this.RadioBtnBilinear = new System.Windows.Forms.RadioButton();
            this.TabBarLblRadius = new System.Windows.Forms.Label();
            this.NumUDRadius = new System.Windows.Forms.NumericUpDown();
            this.TopBarLblFeaturePoints = new System.Windows.Forms.Label();
            this.TopBarLbl1 = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusRunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveImgDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.TabCtrlImage.SuspendLayout();
            this.TpOriginal.SuspendLayout();
            this.TbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.Tb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel1)).BeginInit();
            this.Tb4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel2)).BeginInit();
            this.Tb5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel3)).BeginInit();
            this.Tb6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel4)).BeginInit();
            this.Tb7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel5)).BeginInit();
            this.Tb8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalZoom)).BeginInit();
            this.Tb9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDLattice)).BeginInit();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDFeaturePoints)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDMultiLevel)).BeginInit();
            this.gBoxInterpolation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDRadius)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.BackColor = System.Drawing.Color.Black;
            this.pbOriginal.Location = new System.Drawing.Point(0, 0);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(200, 200);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbOriginal_Paint);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // TabCtrlImage
            // 
            this.TabCtrlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCtrlImage.Controls.Add(this.TpOriginal);
            this.TabCtrlImage.Controls.Add(this.TbResult);
            this.TabCtrlImage.Controls.Add(this.Tb3);
            this.TabCtrlImage.Controls.Add(this.Tb4);
            this.TabCtrlImage.Controls.Add(this.Tb5);
            this.TabCtrlImage.Controls.Add(this.Tb6);
            this.TabCtrlImage.Controls.Add(this.Tb7);
            this.TabCtrlImage.Controls.Add(this.Tb8);
            this.TabCtrlImage.Controls.Add(this.Tb9);
            this.TabCtrlImage.Location = new System.Drawing.Point(0, 82);
            this.TabCtrlImage.Name = "TabCtrlImage";
            this.TabCtrlImage.SelectedIndex = 0;
            this.TabCtrlImage.Size = new System.Drawing.Size(824, 455);
            this.TabCtrlImage.TabIndex = 12;
            // 
            // TpOriginal
            // 
            this.TpOriginal.AutoScroll = true;
            this.TpOriginal.BackColor = System.Drawing.Color.Black;
            this.TpOriginal.Controls.Add(this.pbOriginal);
            this.TpOriginal.Location = new System.Drawing.Point(4, 22);
            this.TpOriginal.Name = "TpOriginal";
            this.TpOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.TpOriginal.Size = new System.Drawing.Size(816, 429);
            this.TpOriginal.TabIndex = 0;
            this.TpOriginal.Text = "Original";
            // 
            // TbResult
            // 
            this.TbResult.AutoScroll = true;
            this.TbResult.BackColor = System.Drawing.Color.Black;
            this.TbResult.Controls.Add(this.pbResult);
            this.TbResult.Location = new System.Drawing.Point(4, 22);
            this.TbResult.Name = "TbResult";
            this.TbResult.Padding = new System.Windows.Forms.Padding(3);
            this.TbResult.Size = new System.Drawing.Size(816, 429);
            this.TbResult.TabIndex = 1;
            this.TbResult.Text = "Result";
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.Black;
            this.pbResult.Location = new System.Drawing.Point(0, 0);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(200, 200);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResult.TabIndex = 2;
            this.pbResult.TabStop = false;
            this.pbResult.Paint += new System.Windows.Forms.PaintEventHandler(this.pbResult_Paint);
            // 
            // Tb3
            // 
            this.Tb3.AutoScroll = true;
            this.Tb3.BackColor = System.Drawing.Color.Black;
            this.Tb3.Controls.Add(this.pbMultiLevel1);
            this.Tb3.Location = new System.Drawing.Point(4, 22);
            this.Tb3.Name = "Tb3";
            this.Tb3.Padding = new System.Windows.Forms.Padding(3);
            this.Tb3.Size = new System.Drawing.Size(816, 429);
            this.Tb3.TabIndex = 2;
            this.Tb3.Text = "MultiLevel1";
            // 
            // pbMultiLevel1
            // 
            this.pbMultiLevel1.Location = new System.Drawing.Point(0, 0);
            this.pbMultiLevel1.Name = "pbMultiLevel1";
            this.pbMultiLevel1.Size = new System.Drawing.Size(200, 200);
            this.pbMultiLevel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMultiLevel1.TabIndex = 0;
            this.pbMultiLevel1.TabStop = false;
            this.pbMultiLevel1.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMultiLevel1_Paint);
            // 
            // Tb4
            // 
            this.Tb4.AutoScroll = true;
            this.Tb4.BackColor = System.Drawing.Color.Black;
            this.Tb4.Controls.Add(this.pbMultiLevel2);
            this.Tb4.Location = new System.Drawing.Point(4, 22);
            this.Tb4.Name = "Tb4";
            this.Tb4.Padding = new System.Windows.Forms.Padding(3);
            this.Tb4.Size = new System.Drawing.Size(816, 429);
            this.Tb4.TabIndex = 3;
            this.Tb4.Text = "MultiLevel2";
            // 
            // pbMultiLevel2
            // 
            this.pbMultiLevel2.Location = new System.Drawing.Point(0, 0);
            this.pbMultiLevel2.Name = "pbMultiLevel2";
            this.pbMultiLevel2.Size = new System.Drawing.Size(200, 200);
            this.pbMultiLevel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMultiLevel2.TabIndex = 0;
            this.pbMultiLevel2.TabStop = false;
            this.pbMultiLevel2.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMultiLevel2_Paint);
            // 
            // Tb5
            // 
            this.Tb5.AutoScroll = true;
            this.Tb5.BackColor = System.Drawing.Color.Black;
            this.Tb5.Controls.Add(this.pbMultiLevel3);
            this.Tb5.Location = new System.Drawing.Point(4, 22);
            this.Tb5.Name = "Tb5";
            this.Tb5.Padding = new System.Windows.Forms.Padding(3);
            this.Tb5.Size = new System.Drawing.Size(816, 429);
            this.Tb5.TabIndex = 4;
            this.Tb5.Text = "MultiLevel3";
            // 
            // pbMultiLevel3
            // 
            this.pbMultiLevel3.Location = new System.Drawing.Point(0, 0);
            this.pbMultiLevel3.Name = "pbMultiLevel3";
            this.pbMultiLevel3.Size = new System.Drawing.Size(200, 200);
            this.pbMultiLevel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMultiLevel3.TabIndex = 0;
            this.pbMultiLevel3.TabStop = false;
            this.pbMultiLevel3.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMultiLevel3_Paint);
            // 
            // Tb6
            // 
            this.Tb6.AutoScroll = true;
            this.Tb6.BackColor = System.Drawing.Color.Black;
            this.Tb6.Controls.Add(this.pbMultiLevel4);
            this.Tb6.Location = new System.Drawing.Point(4, 22);
            this.Tb6.Name = "Tb6";
            this.Tb6.Padding = new System.Windows.Forms.Padding(3);
            this.Tb6.Size = new System.Drawing.Size(816, 429);
            this.Tb6.TabIndex = 5;
            this.Tb6.Text = "MultiLevel4";
            // 
            // pbMultiLevel4
            // 
            this.pbMultiLevel4.Location = new System.Drawing.Point(0, 0);
            this.pbMultiLevel4.Name = "pbMultiLevel4";
            this.pbMultiLevel4.Size = new System.Drawing.Size(200, 200);
            this.pbMultiLevel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMultiLevel4.TabIndex = 0;
            this.pbMultiLevel4.TabStop = false;
            this.pbMultiLevel4.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMultiLevel4_Paint);
            // 
            // Tb7
            // 
            this.Tb7.AutoScroll = true;
            this.Tb7.BackColor = System.Drawing.Color.Black;
            this.Tb7.Controls.Add(this.pbMultiLevel5);
            this.Tb7.Location = new System.Drawing.Point(4, 22);
            this.Tb7.Name = "Tb7";
            this.Tb7.Padding = new System.Windows.Forms.Padding(3);
            this.Tb7.Size = new System.Drawing.Size(816, 429);
            this.Tb7.TabIndex = 6;
            this.Tb7.Text = "MultiLevel5";
            // 
            // pbMultiLevel5
            // 
            this.pbMultiLevel5.Location = new System.Drawing.Point(0, 0);
            this.pbMultiLevel5.Name = "pbMultiLevel5";
            this.pbMultiLevel5.Size = new System.Drawing.Size(200, 200);
            this.pbMultiLevel5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMultiLevel5.TabIndex = 0;
            this.pbMultiLevel5.TabStop = false;
            this.pbMultiLevel5.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMultiLevel5_Paint);
            // 
            // Tb8
            // 
            this.Tb8.BackColor = System.Drawing.Color.Black;
            this.Tb8.Controls.Add(this.pbOriginalZoom);
            this.Tb8.Location = new System.Drawing.Point(4, 22);
            this.Tb8.Name = "Tb8";
            this.Tb8.Padding = new System.Windows.Forms.Padding(3);
            this.Tb8.Size = new System.Drawing.Size(816, 429);
            this.Tb8.TabIndex = 7;
            this.Tb8.Text = "Original Zoom";
            // 
            // pbOriginalZoom
            // 
            this.pbOriginalZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginalZoom.Location = new System.Drawing.Point(3, 3);
            this.pbOriginalZoom.Name = "pbOriginalZoom";
            this.pbOriginalZoom.Size = new System.Drawing.Size(810, 423);
            this.pbOriginalZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginalZoom.TabIndex = 0;
            this.pbOriginalZoom.TabStop = false;
            // 
            // Tb9
            // 
            this.Tb9.BackColor = System.Drawing.Color.Black;
            this.Tb9.Controls.Add(this.pbResultZoom);
            this.Tb9.Location = new System.Drawing.Point(4, 22);
            this.Tb9.Name = "Tb9";
            this.Tb9.Padding = new System.Windows.Forms.Padding(3);
            this.Tb9.Size = new System.Drawing.Size(816, 429);
            this.Tb9.TabIndex = 8;
            this.Tb9.Text = "Result Zoom";
            // 
            // pbResultZoom
            // 
            this.pbResultZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbResultZoom.Location = new System.Drawing.Point(3, 3);
            this.pbResultZoom.Name = "pbResultZoom";
            this.pbResultZoom.Size = new System.Drawing.Size(810, 423);
            this.pbResultZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResultZoom.TabIndex = 0;
            this.pbResultZoom.TabStop = false;
            // 
            // NumUDLattice
            // 
            this.NumUDLattice.Location = new System.Drawing.Point(7, 25);
            this.NumUDLattice.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.NumUDLattice.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.NumUDLattice.Name = "NumUDLattice";
            this.NumUDLattice.Size = new System.Drawing.Size(38, 19);
            this.NumUDLattice.TabIndex = 13;
            this.NumUDLattice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUDLattice.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // OpenFileDialog2
            // 
            this.OpenFileDialog2.FileName = "OpenFileDialog2";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBtnOpenImage,
            this.ToolBtnFeaturePoints,
            this.ToolBtnWarpPoints,
            this.ToolBtnRun,
            this.ToolBtnSave,
            this.toolStripSeparator,
            this.ToolBtnHelp});
            this.ToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(824, 25);
            this.ToolBar.TabIndex = 17;
            this.ToolBar.Text = "ToolBar";
            // 
            // ToolBtnOpenImage
            // 
            this.ToolBtnOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnOpenImage.Image")));
            this.ToolBtnOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnOpenImage.Name = "ToolBtnOpenImage";
            this.ToolBtnOpenImage.Size = new System.Drawing.Size(58, 22);
            this.ToolBtnOpenImage.Text = "Open";
            this.ToolBtnOpenImage.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // ToolBtnFeaturePoints
            // 
            this.ToolBtnFeaturePoints.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnFeaturePoints.Image")));
            this.ToolBtnFeaturePoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnFeaturePoints.Name = "ToolBtnFeaturePoints";
            this.ToolBtnFeaturePoints.Size = new System.Drawing.Size(112, 22);
            this.ToolBtnFeaturePoints.Text = "Feature Points";
            this.ToolBtnFeaturePoints.Click += new System.EventHandler(this.BtnPt1_Click);
            // 
            // ToolBtnWarpPoints
            // 
            this.ToolBtnWarpPoints.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnWarpPoints.Image")));
            this.ToolBtnWarpPoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnWarpPoints.Name = "ToolBtnWarpPoints";
            this.ToolBtnWarpPoints.Size = new System.Drawing.Size(97, 22);
            this.ToolBtnWarpPoints.Text = "Warp Points";
            this.ToolBtnWarpPoints.Click += new System.EventHandler(this.BtnPt2_Click);
            // 
            // ToolBtnRun
            // 
            this.ToolBtnRun.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnRun.Image")));
            this.ToolBtnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnRun.Name = "ToolBtnRun";
            this.ToolBtnRun.Size = new System.Drawing.Size(50, 22);
            this.ToolBtnRun.Text = "Run";
            this.ToolBtnRun.Click += new System.EventHandler(this.ToolBtnRun_Click);
            // 
            // ToolBtnSave
            // 
            this.ToolBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnSave.Image")));
            this.ToolBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnSave.Name = "ToolBtnSave";
            this.ToolBtnSave.Size = new System.Drawing.Size(57, 22);
            this.ToolBtnSave.Text = "Save";
            this.ToolBtnSave.Click += new System.EventHandler(this.ToolBtnSave_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // ToolBtnHelp
            // 
            this.ToolBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnHelp.Image")));
            this.ToolBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnHelp.Name = "ToolBtnHelp";
            this.ToolBtnHelp.Size = new System.Drawing.Size(23, 20);
            this.ToolBtnHelp.Text = "Help";
            // 
            // NumUDFeaturePoints
            // 
            this.NumUDFeaturePoints.Location = new System.Drawing.Point(49, 25);
            this.NumUDFeaturePoints.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.NumUDFeaturePoints.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumUDFeaturePoints.Name = "NumUDFeaturePoints";
            this.NumUDFeaturePoints.Size = new System.Drawing.Size(60, 19);
            this.NumUDFeaturePoints.TabIndex = 18;
            this.NumUDFeaturePoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUDFeaturePoints.Value = new decimal(new int[] {
            113,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabBarLblLevel);
            this.panel1.Controls.Add(this.cbBackBlack);
            this.panel1.Controls.Add(this.NumUDMultiLevel);
            this.panel1.Controls.Add(this.cbDisplayP);
            this.panel1.Controls.Add(this.gBoxInterpolation);
            this.panel1.Controls.Add(this.TabBarLblRadius);
            this.panel1.Controls.Add(this.NumUDRadius);
            this.panel1.Controls.Add(this.TopBarLblFeaturePoints);
            this.panel1.Controls.Add(this.TopBarLbl1);
            this.panel1.Controls.Add(this.NumUDLattice);
            this.panel1.Controls.Add(this.NumUDFeaturePoints);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 51);
            this.panel1.TabIndex = 19;
            // 
            // TabBarLblLevel
            // 
            this.TabBarLblLevel.AutoSize = true;
            this.TabBarLblLevel.Location = new System.Drawing.Point(163, 7);
            this.TabBarLblLevel.Name = "TabBarLblLevel";
            this.TabBarLblLevel.Size = new System.Drawing.Size(32, 12);
            this.TabBarLblLevel.TabIndex = 27;
            this.TabBarLblLevel.Text = "Level";
            // 
            // cbBackBlack
            // 
            this.cbBackBlack.AutoSize = true;
            this.cbBackBlack.Location = new System.Drawing.Point(201, 28);
            this.cbBackBlack.Name = "cbBackBlack";
            this.cbBackBlack.Size = new System.Drawing.Size(83, 16);
            this.cbBackBlack.TabIndex = 26;
            this.cbBackBlack.Text = "Back Black";
            this.cbBackBlack.UseVisualStyleBackColor = true;
            // 
            // NumUDMultiLevel
            // 
            this.NumUDMultiLevel.Location = new System.Drawing.Point(165, 25);
            this.NumUDMultiLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumUDMultiLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDMultiLevel.Name = "NumUDMultiLevel";
            this.NumUDMultiLevel.Size = new System.Drawing.Size(30, 19);
            this.NumUDMultiLevel.TabIndex = 25;
            this.NumUDMultiLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUDMultiLevel.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbDisplayP
            // 
            this.cbDisplayP.AutoSize = true;
            this.cbDisplayP.Checked = true;
            this.cbDisplayP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDisplayP.Location = new System.Drawing.Point(201, 7);
            this.cbDisplayP.Name = "cbDisplayP";
            this.cbDisplayP.Size = new System.Drawing.Size(98, 16);
            this.cbDisplayP.TabIndex = 24;
            this.cbDisplayP.Text = "Display Points";
            this.cbDisplayP.UseVisualStyleBackColor = true;
            this.cbDisplayP.CheckedChanged += new System.EventHandler(this.cbDisplayP_CheckedChanged);
            // 
            // gBoxInterpolation
            // 
            this.gBoxInterpolation.Controls.Add(this.RadioBtnNN);
            this.gBoxInterpolation.Controls.Add(this.RadioBtnBilinear);
            this.gBoxInterpolation.Location = new System.Drawing.Point(305, 7);
            this.gBoxInterpolation.Name = "gBoxInterpolation";
            this.gBoxInterpolation.Size = new System.Drawing.Size(200, 37);
            this.gBoxInterpolation.TabIndex = 23;
            this.gBoxInterpolation.TabStop = false;
            this.gBoxInterpolation.Text = "Interpolation";
            // 
            // RadioBtnNN
            // 
            this.RadioBtnNN.AutoSize = true;
            this.RadioBtnNN.Location = new System.Drawing.Point(6, 15);
            this.RadioBtnNN.Name = "RadioBtnNN";
            this.RadioBtnNN.Size = new System.Drawing.Size(112, 16);
            this.RadioBtnNN.TabIndex = 0;
            this.RadioBtnNN.Text = "Nearest Neighbor";
            this.RadioBtnNN.UseVisualStyleBackColor = true;
            // 
            // RadioBtnBilinear
            // 
            this.RadioBtnBilinear.AutoSize = true;
            this.RadioBtnBilinear.Checked = true;
            this.RadioBtnBilinear.Location = new System.Drawing.Point(124, 15);
            this.RadioBtnBilinear.Name = "RadioBtnBilinear";
            this.RadioBtnBilinear.Size = new System.Drawing.Size(62, 16);
            this.RadioBtnBilinear.TabIndex = 1;
            this.RadioBtnBilinear.TabStop = true;
            this.RadioBtnBilinear.Text = "Bilinear";
            this.RadioBtnBilinear.UseVisualStyleBackColor = true;
            // 
            // TabBarLblRadius
            // 
            this.TabBarLblRadius.AutoSize = true;
            this.TabBarLblRadius.Location = new System.Drawing.Point(111, 7);
            this.TabBarLblRadius.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.TabBarLblRadius.Name = "TabBarLblRadius";
            this.TabBarLblRadius.Size = new System.Drawing.Size(46, 12);
            this.TabBarLblRadius.TabIndex = 22;
            this.TabBarLblRadius.Text = "Randius";
            // 
            // NumUDRadius
            // 
            this.NumUDRadius.Location = new System.Drawing.Point(113, 25);
            this.NumUDRadius.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.NumUDRadius.Name = "NumUDRadius";
            this.NumUDRadius.Size = new System.Drawing.Size(44, 19);
            this.NumUDRadius.TabIndex = 21;
            this.NumUDRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUDRadius.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TopBarLblFeaturePoints
            // 
            this.TopBarLblFeaturePoints.AutoSize = true;
            this.TopBarLblFeaturePoints.Location = new System.Drawing.Point(47, 7);
            this.TopBarLblFeaturePoints.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.TopBarLblFeaturePoints.Name = "TopBarLblFeaturePoints";
            this.TopBarLblFeaturePoints.Size = new System.Drawing.Size(62, 12);
            this.TopBarLblFeaturePoints.TabIndex = 20;
            this.TopBarLblFeaturePoints.Text = "Max Points";
            // 
            // TopBarLbl1
            // 
            this.TopBarLbl1.AutoSize = true;
            this.TopBarLbl1.Location = new System.Drawing.Point(5, 7);
            this.TopBarLbl1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.TopBarLbl1.Name = "TopBarLbl1";
            this.TopBarLbl1.Size = new System.Drawing.Size(40, 12);
            this.TopBarLbl1.TabIndex = 19;
            this.TopBarLbl1.Text = "Lattice";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText,
            this.StatusRunTime});
            this.StatusStrip.Location = new System.Drawing.Point(0, 540);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(824, 22);
            this.StatusStrip.TabIndex = 20;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusRunTime
            // 
            this.StatusRunTime.Name = "StatusRunTime";
            this.StatusRunTime.Size = new System.Drawing.Size(0, 17);
            // 
            // Warping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 562);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.TabCtrlImage);
            this.Name = "Warping";
            this.Text = "Warping";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.TabCtrlImage.ResumeLayout(false);
            this.TpOriginal.ResumeLayout(false);
            this.TpOriginal.PerformLayout();
            this.TbResult.ResumeLayout(false);
            this.TbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.Tb3.ResumeLayout(false);
            this.Tb3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel1)).EndInit();
            this.Tb4.ResumeLayout(false);
            this.Tb4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel2)).EndInit();
            this.Tb5.ResumeLayout(false);
            this.Tb5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel3)).EndInit();
            this.Tb6.ResumeLayout(false);
            this.Tb6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel4)).EndInit();
            this.Tb7.ResumeLayout(false);
            this.Tb7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiLevel5)).EndInit();
            this.Tb8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalZoom)).EndInit();
            this.Tb9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResultZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDLattice)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDFeaturePoints)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDMultiLevel)).EndInit();
            this.gBoxInterpolation.ResumeLayout(false);
            this.gBoxInterpolation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDRadius)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.TabControl TabCtrlImage;
        private System.Windows.Forms.TabPage TpOriginal;
        private System.Windows.Forms.NumericUpDown NumUDLattice;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog2;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton ToolBtnOpenImage;
        private System.Windows.Forms.ToolStripButton ToolBtnFeaturePoints;
        private System.Windows.Forms.ToolStripButton ToolBtnWarpPoints;
        private System.Windows.Forms.ToolStripButton ToolBtnRun;
        private System.Windows.Forms.ToolStripButton ToolBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton ToolBtnHelp;
        private System.Windows.Forms.NumericUpDown NumUDFeaturePoints;
        private System.Windows.Forms.TabPage TbResult;
        private System.Windows.Forms.TabPage Tb3;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.TabPage Tb4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.ToolStripStatusLabel StatusRunTime;
        private System.Windows.Forms.Label TopBarLbl1;
        private System.Windows.Forms.Label TopBarLblFeaturePoints;
        private System.Windows.Forms.RadioButton RadioBtnNN;
        private System.Windows.Forms.RadioButton RadioBtnBilinear;
        private System.Windows.Forms.TabPage Tb5;
        private System.Windows.Forms.NumericUpDown NumUDRadius;
        private System.Windows.Forms.Label TabBarLblRadius;
        private System.Windows.Forms.GroupBox gBoxInterpolation;
        private System.Windows.Forms.CheckBox cbDisplayP;
        private System.Windows.Forms.SaveFileDialog SaveImgDialog;
        private System.Windows.Forms.NumericUpDown NumUDMultiLevel;
        private System.Windows.Forms.PictureBox pbMultiLevel1;
        private System.Windows.Forms.PictureBox pbMultiLevel2;
        private System.Windows.Forms.PictureBox pbMultiLevel3;
        private System.Windows.Forms.CheckBox cbBackBlack;
        private System.Windows.Forms.TabPage Tb6;
        private System.Windows.Forms.PictureBox pbMultiLevel4;
        private System.Windows.Forms.TabPage Tb7;
        private System.Windows.Forms.PictureBox pbMultiLevel5;
        private System.Windows.Forms.TabPage Tb8;
        private System.Windows.Forms.TabPage Tb9;
        private System.Windows.Forms.PictureBox pbOriginalZoom;
        private System.Windows.Forms.PictureBox pbResultZoom;
        private System.Windows.Forms.Label TabBarLblLevel;
    }
}