namespace AFIM
{
    partial class Landmarker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landmarker));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plImage = new System.Windows.Forms.Panel();
            this.dgv_tmp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudProperty = new System.Windows.Forms.NumericUpDown();
            this.nudPointCounter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPointSize = new System.Windows.Forms.NumericUpDown();
            this.lblPointSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNextFP = new System.Windows.Forms.Label();
            this.textBoxNFP = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PixelInfoText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolLblImage = new System.Windows.Forms.ToolStripLabel();
            this.ToolBtnOpenImg = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnSaveImg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolLblText = new System.Windows.Forms.ToolStripLabel();
            this.ToolBtnOpenText = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnSaveText = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnInitText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBtnView = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPointNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolAssociation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMesh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolEyeBrows = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolEyes = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolNose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMouth = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolPointColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorEven = new System.Windows.Forms.ToolStripMenuItem();
            this.EvenColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorOdd = new System.Windows.Forms.ToolStripMenuItem();
            this.OddColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorMesh = new System.Windows.Forms.ToolStripMenuItem();
            this.MeshColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveImgDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.pointX,
            this.pointY,
            this.Column});
            this.dataGridView.Location = new System.Drawing.Point(783, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(230, 654);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.Sorted += new System.EventHandler(this.dataGridView_Sorted);
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
            // 
            // Number
            // 
            this.Number.FillWeight = 60F;
            this.Number.HeaderText = "PN";
            this.Number.MaxInputLength = 5;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.Width = 40;
            // 
            // pointX
            // 
            this.pointX.FillWeight = 40F;
            this.pointX.HeaderText = "X";
            this.pointX.MaxInputLength = 5;
            this.pointX.Name = "pointX";
            this.pointX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pointX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pointX.Width = 50;
            // 
            // pointY
            // 
            this.pointY.FillWeight = 40F;
            this.pointY.HeaderText = "Y";
            this.pointY.MaxInputLength = 5;
            this.pointY.Name = "pointY";
            this.pointY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pointY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pointY.Width = 50;
            // 
            // Column
            // 
            this.Column.HeaderText = "";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // plImage
            // 
            this.plImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plImage.AutoScroll = true;
            this.plImage.BackColor = System.Drawing.Color.Black;
            this.plImage.Controls.Add(this.pictureBox1);
            this.plImage.Location = new System.Drawing.Point(5, 61);
            this.plImage.Name = "plImage";
            this.plImage.Size = new System.Drawing.Size(772, 654);
            this.plImage.TabIndex = 5;
            // 
            // dgv_tmp
            // 
            this.dgv_tmp.AllowUserToAddRows = false;
            this.dgv_tmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_tmp.Enabled = false;
            this.dgv_tmp.Location = new System.Drawing.Point(976, 6);
            this.dgv_tmp.Name = "dgv_tmp";
            this.dgv_tmp.RowTemplate.Height = 21;
            this.dgv_tmp.Size = new System.Drawing.Size(37, 18);
            this.dgv_tmp.TabIndex = 24;
            this.dgv_tmp.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // nudProperty
            // 
            this.nudProperty.Location = new System.Drawing.Point(275, 6);
            this.nudProperty.Name = "nudProperty";
            this.nudProperty.ReadOnly = true;
            this.nudProperty.Size = new System.Drawing.Size(53, 19);
            this.nudProperty.TabIndex = 23;
            this.nudProperty.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nudPointCounter
            // 
            this.nudPointCounter.Location = new System.Drawing.Point(161, 6);
            this.nudPointCounter.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudPointCounter.Name = "nudPointCounter";
            this.nudPointCounter.Size = new System.Drawing.Size(53, 19);
            this.nudPointCounter.TabIndex = 22;
            this.nudPointCounter.Value = new decimal(new int[] {
            114,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "プロパティ";
            // 
            // nudPointSize
            // 
            this.nudPointSize.Location = new System.Drawing.Point(43, 6);
            this.nudPointSize.Name = "nudPointSize";
            this.nudPointSize.Size = new System.Drawing.Size(53, 19);
            this.nudPointSize.TabIndex = 14;
            this.nudPointSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPointSize.ValueChanged += new System.EventHandler(this.nudPointSize_ValueChanged);
            // 
            // lblPointSize
            // 
            this.lblPointSize.AutoSize = true;
            this.lblPointSize.Location = new System.Drawing.Point(3, 8);
            this.lblPointSize.Name = "lblPointSize";
            this.lblPointSize.Size = new System.Drawing.Size(34, 12);
            this.lblPointSize.TabIndex = 15;
            this.lblPointSize.Text = "サイズ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "特徴点数";
            // 
            // lblNextFP
            // 
            this.lblNextFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextFP.AutoSize = true;
            this.lblNextFP.Location = new System.Drawing.Point(781, 8);
            this.lblNextFP.Name = "lblNextFP";
            this.lblNextFP.Size = new System.Drawing.Size(87, 12);
            this.lblNextFP.TabIndex = 17;
            this.lblNextFP.Text = "次の特徴点番号";
            // 
            // textBoxNFP
            // 
            this.textBoxNFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNFP.Location = new System.Drawing.Point(874, 5);
            this.textBoxNFP.Name = "textBoxNFP";
            this.textBoxNFP.Size = new System.Drawing.Size(88, 19);
            this.textBoxNFP.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openImageDialog";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PixelInfoText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 718);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 23);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PixelInfoText
            // 
            this.PixelInfoText.Name = "PixelInfoText";
            this.PixelInfoText.Size = new System.Drawing.Size(44, 18);
            this.PixelInfoText.Text = "Ready";
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolLblImage,
            this.ToolBtnOpenImg,
            this.ToolBtnSaveImg,
            this.toolStripSeparator,
            this.ToolLblText,
            this.ToolBtnOpenText,
            this.ToolBtnSaveText,
            this.ToolBtnInitText,
            this.toolStripSeparator2,
            this.ToolBtnView});
            this.ToolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(1016, 26);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Text = "ToolBar";
            // 
            // ToolLblImage
            // 
            this.ToolLblImage.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolLblImage.Name = "ToolLblImage";
            this.ToolLblImage.Size = new System.Drawing.Size(57, 23);
            this.ToolLblImage.Text = "Image";
            // 
            // ToolBtnOpenImg
            // 
            this.ToolBtnOpenImg.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnOpenImg.Image")));
            this.ToolBtnOpenImg.Name = "ToolBtnOpenImg";
            this.ToolBtnOpenImg.Size = new System.Drawing.Size(58, 22);
            this.ToolBtnOpenImg.Text = "Open";
            this.ToolBtnOpenImg.Click += new System.EventHandler(this.FileOpenImage_Click);
            // 
            // ToolBtnSaveImg
            // 
            this.ToolBtnSaveImg.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnSaveImg.Image")));
            this.ToolBtnSaveImg.Name = "ToolBtnSaveImg";
            this.ToolBtnSaveImg.Size = new System.Drawing.Size(57, 22);
            this.ToolBtnSaveImg.Text = "Save";
            this.ToolBtnSaveImg.Click += new System.EventHandler(this.ToolBtnSaveImg_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // ToolLblText
            // 
            this.ToolLblText.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolLblText.Name = "ToolLblText";
            this.ToolLblText.Size = new System.Drawing.Size(41, 23);
            this.ToolLblText.Text = "Text";
            // 
            // ToolBtnOpenText
            // 
            this.ToolBtnOpenText.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnOpenText.Image")));
            this.ToolBtnOpenText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnOpenText.Name = "ToolBtnOpenText";
            this.ToolBtnOpenText.Size = new System.Drawing.Size(58, 22);
            this.ToolBtnOpenText.Text = "Open";
            this.ToolBtnOpenText.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // ToolBtnSaveText
            // 
            this.ToolBtnSaveText.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnSaveText.Image")));
            this.ToolBtnSaveText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnSaveText.Name = "ToolBtnSaveText";
            this.ToolBtnSaveText.Size = new System.Drawing.Size(57, 22);
            this.ToolBtnSaveText.Text = "Save";
            this.ToolBtnSaveText.ToolTipText = "Save Text";
            this.ToolBtnSaveText.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // ToolBtnInitText
            // 
            this.ToolBtnInitText.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnInitText.Image")));
            this.ToolBtnInitText.Name = "ToolBtnInitText";
            this.ToolBtnInitText.Size = new System.Drawing.Size(48, 22);
            this.ToolBtnInitText.Text = "Init";
            this.ToolBtnInitText.ToolTipText = "Init Text";
            this.ToolBtnInitText.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // ToolBtnView
            // 
            this.ToolBtnView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolPoint,
            this.ToolPointNumber,
            this.toolStripSeparator1,
            this.ToolAssociation,
            this.ToolMesh,
            this.toolStripSeparator4,
            this.ToolEyeBrows,
            this.ToolEyes,
            this.ToolNose,
            this.ToolMouth,
            this.ToolLine,
            this.toolStripSeparator3,
            this.ToolPointColor});
            this.ToolBtnView.Image = ((System.Drawing.Image)(resources.GetObject("ToolBtnView.Image")));
            this.ToolBtnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnView.Name = "ToolBtnView";
            this.ToolBtnView.Size = new System.Drawing.Size(65, 22);
            this.ToolBtnView.Text = "View";
            // 
            // ToolPoint
            // 
            this.ToolPoint.Checked = true;
            this.ToolPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolPoint.Name = "ToolPoint";
            this.ToolPoint.Size = new System.Drawing.Size(175, 22);
            this.ToolPoint.Text = "Point(&P)";
            this.ToolPoint.Click += new System.EventHandler(this.DisplayP_Click);
            // 
            // ToolPointNumber
            // 
            this.ToolPointNumber.Checked = true;
            this.ToolPointNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolPointNumber.Name = "ToolPointNumber";
            this.ToolPointNumber.Size = new System.Drawing.Size(175, 22);
            this.ToolPointNumber.Text = "Point Number(&N)";
            this.ToolPointNumber.Click += new System.EventHandler(this.DisplayPN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // ToolAssociation
            // 
            this.ToolAssociation.Name = "ToolAssociation";
            this.ToolAssociation.Size = new System.Drawing.Size(175, 22);
            this.ToolAssociation.Text = "Association(&A)";
            this.ToolAssociation.Click += new System.EventHandler(this.btnAsso_Click);
            // 
            // ToolMesh
            // 
            this.ToolMesh.Enabled = false;
            this.ToolMesh.Name = "ToolMesh";
            this.ToolMesh.Size = new System.Drawing.Size(175, 22);
            this.ToolMesh.Text = "Mesh(&M)";
            this.ToolMesh.CheckedChanged += new System.EventHandler(this.ToolMesh_CheckedChanged);
            this.ToolMesh.Click += new System.EventHandler(this.ToolMesh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // ToolEyeBrows
            // 
            this.ToolEyeBrows.Enabled = false;
            this.ToolEyeBrows.Name = "ToolEyeBrows";
            this.ToolEyeBrows.Size = new System.Drawing.Size(175, 22);
            this.ToolEyeBrows.Text = "EyeBrows";
            this.ToolEyeBrows.Click += new System.EventHandler(this.ToolEyeBrows_Click);
            // 
            // ToolEyes
            // 
            this.ToolEyes.Enabled = false;
            this.ToolEyes.Name = "ToolEyes";
            this.ToolEyes.Size = new System.Drawing.Size(175, 22);
            this.ToolEyes.Text = "Eyes";
            this.ToolEyes.Click += new System.EventHandler(this.ToolEyes_Click);
            // 
            // ToolNose
            // 
            this.ToolNose.Enabled = false;
            this.ToolNose.Name = "ToolNose";
            this.ToolNose.Size = new System.Drawing.Size(175, 22);
            this.ToolNose.Text = "Nose";
            this.ToolNose.Click += new System.EventHandler(this.ToolNose_Click);
            // 
            // ToolMouth
            // 
            this.ToolMouth.Enabled = false;
            this.ToolMouth.Name = "ToolMouth";
            this.ToolMouth.Size = new System.Drawing.Size(175, 22);
            this.ToolMouth.Text = "Mouth";
            this.ToolMouth.Click += new System.EventHandler(this.ToolMouth_Click);
            // 
            // ToolLine
            // 
            this.ToolLine.Enabled = false;
            this.ToolLine.Name = "ToolLine";
            this.ToolLine.Size = new System.Drawing.Size(175, 22);
            this.ToolLine.Text = "Line";
            this.ToolLine.Click += new System.EventHandler(this.ToolLine_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(172, 6);
            // 
            // ToolPointColor
            // 
            this.ToolPointColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeColorEven,
            this.ChangeColorOdd,
            this.ChangeColorSelect,
            this.ChangeColorMesh});
            this.ToolPointColor.Name = "ToolPointColor";
            this.ToolPointColor.Size = new System.Drawing.Size(175, 22);
            this.ToolPointColor.Text = "Change Color(&C)";
            // 
            // ChangeColorEven
            // 
            this.ChangeColorEven.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EvenColorItem});
            this.ChangeColorEven.Name = "ChangeColorEven";
            this.ChangeColorEven.Size = new System.Drawing.Size(112, 22);
            this.ChangeColorEven.Text = "Even";
            this.ChangeColorEven.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // EvenColorItem
            // 
            this.EvenColorItem.BackColor = System.Drawing.Color.Red;
            this.EvenColorItem.Name = "EvenColorItem";
            this.EvenColorItem.Size = new System.Drawing.Size(80, 22);
            this.EvenColorItem.Text = " ";
            // 
            // ChangeColorOdd
            // 
            this.ChangeColorOdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OddColorItem});
            this.ChangeColorOdd.Name = "ChangeColorOdd";
            this.ChangeColorOdd.Size = new System.Drawing.Size(112, 22);
            this.ChangeColorOdd.Text = "Odd";
            this.ChangeColorOdd.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // OddColorItem
            // 
            this.OddColorItem.BackColor = System.Drawing.Color.Blue;
            this.OddColorItem.Name = "OddColorItem";
            this.OddColorItem.Size = new System.Drawing.Size(80, 22);
            this.OddColorItem.Text = " ";
            // 
            // ChangeColorSelect
            // 
            this.ChangeColorSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectColorItem});
            this.ChangeColorSelect.Name = "ChangeColorSelect";
            this.ChangeColorSelect.Size = new System.Drawing.Size(112, 22);
            this.ChangeColorSelect.Text = "Select";
            this.ChangeColorSelect.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // SelectColorItem
            // 
            this.SelectColorItem.BackColor = System.Drawing.Color.Lime;
            this.SelectColorItem.Name = "SelectColorItem";
            this.SelectColorItem.Size = new System.Drawing.Size(80, 22);
            this.SelectColorItem.Text = " ";
            // 
            // ChangeColorMesh
            // 
            this.ChangeColorMesh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeshColorItem});
            this.ChangeColorMesh.Name = "ChangeColorMesh";
            this.ChangeColorMesh.Size = new System.Drawing.Size(112, 22);
            this.ChangeColorMesh.Text = "Mesh";
            this.ChangeColorMesh.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // MeshColorItem
            // 
            this.MeshColorItem.BackColor = System.Drawing.Color.Purple;
            this.MeshColorItem.Name = "MeshColorItem";
            this.MeshColorItem.Size = new System.Drawing.Size(80, 22);
            this.MeshColorItem.Text = " ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_tmp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudPointCounter);
            this.panel1.Controls.Add(this.nudProperty);
            this.panel1.Controls.Add(this.lblPointSize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudPointSize);
            this.panel1.Controls.Add(this.textBoxNFP);
            this.panel1.Controls.Add(this.lblNextFP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 29);
            this.panel1.TabIndex = 19;
            // 
            // Landmarker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.plImage);
            this.Controls.Add(this.dataGridView);
            this.Name = "Landmarker";
            this.Text = "Feature Points Setting Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plImage.ResumeLayout(false);
            this.plImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel plImage;
        private System.Windows.Forms.Label lblPointSize;
        private System.Windows.Forms.NumericUpDown nudPointSize;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblNextFP;
        private System.Windows.Forms.TextBox textBoxNFP;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.NumericUpDown nudProperty;
        private System.Windows.Forms.NumericUpDown nudPointCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PixelInfoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton ToolBtnOpenImg;
        private System.Windows.Forms.ToolStripButton ToolBtnSaveImg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton ToolBtnOpenText;
        private System.Windows.Forms.ToolStripButton ToolBtnSaveText;
        private System.Windows.Forms.ToolStripButton ToolBtnInitText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton ToolBtnView;
        private System.Windows.Forms.ToolStripLabel ToolLblImage;
        private System.Windows.Forms.ToolStripLabel ToolLblText;
        private System.Windows.Forms.ToolStripMenuItem ToolPoint;
        private System.Windows.Forms.ToolStripMenuItem ToolPointNumber;
        private System.Windows.Forms.ToolStripMenuItem ToolMesh;
        private System.Windows.Forms.ToolStripMenuItem ToolPointColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolAssociation;
        private System.Windows.Forms.ToolStripMenuItem ChangeColorEven;
        private System.Windows.Forms.ToolStripMenuItem ChangeColorOdd;
        private System.Windows.Forms.ToolStripMenuItem ChangeColorSelect;
        private System.Windows.Forms.ToolStripMenuItem ChangeColorMesh;
        private System.Windows.Forms.ToolStripMenuItem EvenColorItem;
        private System.Windows.Forms.ToolStripMenuItem OddColorItem;
        private System.Windows.Forms.ToolStripMenuItem SelectColorItem;
        private System.Windows.Forms.ToolStripMenuItem MeshColorItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointX;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridView dgv_tmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripMenuItem ToolEyeBrows;
        private System.Windows.Forms.ToolStripMenuItem ToolEyes;
        private System.Windows.Forms.ToolStripMenuItem ToolNose;
        private System.Windows.Forms.ToolStripMenuItem ToolMouth;
        private System.Windows.Forms.ToolStripMenuItem ToolLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog SaveImgDialog;
    }
}