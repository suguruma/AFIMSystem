namespace AFIM
{
    partial class Aligenment
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
            this.OutputList = new System.Windows.Forms.ListBox();
            this.BtnFolderImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFolderPoints = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFileTarget = new System.Windows.Forms.Button();
            this.FileTargetLocation = new System.Windows.Forms.TextBox();
            this.FilenameBefore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFileAssociation = new System.Windows.Forms.Button();
            this.FileAssociationLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExecutableMode = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ViewImagesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewPointsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FolderImagesLocation = new System.Windows.Forms.TextBox();
            this.ComboImages = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FolderPointsLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboPoints = new System.Windows.Forms.ComboBox();
            this.BtnFolderSave = new System.Windows.Forms.Button();
            this.FolderSaveLocation = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FilenameAfter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.FolderBrowserDialogImages = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderBrowserDialogPoints = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderBrowserDialogSave = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialogTarget = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileDialogAssociation = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnFileRead = new System.Windows.Forms.Button();
            this.BtnFileAdd = new System.Windows.Forms.Button();
            this.BtnFileInit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ImageCounterBox = new System.Windows.Forms.ListBox();
            this.PointCounterBox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.RunFileCount = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbImageOutput = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputList
            // 
            this.OutputList.FormattingEnabled = true;
            this.OutputList.IntegralHeight = false;
            this.OutputList.ItemHeight = 12;
            this.OutputList.Location = new System.Drawing.Point(394, 385);
            this.OutputList.Name = "OutputList";
            this.OutputList.Size = new System.Drawing.Size(264, 124);
            this.OutputList.TabIndex = 0;
            // 
            // BtnFolderImages
            // 
            this.BtnFolderImages.Location = new System.Drawing.Point(257, 18);
            this.BtnFolderImages.Name = "BtnFolderImages";
            this.BtnFolderImages.Size = new System.Drawing.Size(50, 23);
            this.BtnFolderImages.TabIndex = 2;
            this.BtnFolderImages.Text = "選択";
            this.BtnFolderImages.UseVisualStyleBackColor = true;
            this.BtnFolderImages.Click += new System.EventHandler(this.BtnFolderImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "フォルダ場所：";
            // 
            // BtnFolderPoints
            // 
            this.BtnFolderPoints.Location = new System.Drawing.Point(266, 18);
            this.BtnFolderPoints.Name = "BtnFolderPoints";
            this.BtnFolderPoints.Size = new System.Drawing.Size(48, 23);
            this.BtnFolderPoints.TabIndex = 4;
            this.BtnFolderPoints.Text = "選択";
            this.BtnFolderPoints.UseVisualStyleBackColor = true;
            this.BtnFolderPoints.Click += new System.EventHandler(this.BtnFolderPoints_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "フォルダ場所：";
            // 
            // BtnFileTarget
            // 
            this.BtnFileTarget.Location = new System.Drawing.Point(547, 23);
            this.BtnFileTarget.Name = "BtnFileTarget";
            this.BtnFileTarget.Size = new System.Drawing.Size(91, 23);
            this.BtnFileTarget.TabIndex = 9;
            this.BtnFileTarget.Text = "読み込み";
            this.BtnFileTarget.UseVisualStyleBackColor = true;
            this.BtnFileTarget.Click += new System.EventHandler(this.BtnFileTarget_Click);
            // 
            // FileTargetLocation
            // 
            this.FileTargetLocation.Location = new System.Drawing.Point(107, 25);
            this.FileTargetLocation.Name = "FileTargetLocation";
            this.FileTargetLocation.Size = new System.Drawing.Size(434, 19);
            this.FileTargetLocation.TabIndex = 10;
            // 
            // FilenameBefore
            // 
            this.FilenameBefore.Location = new System.Drawing.Point(13, 24);
            this.FilenameBefore.Name = "FilenameBefore";
            this.FilenameBefore.Size = new System.Drawing.Size(113, 19);
            this.FilenameBefore.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFileAssociation);
            this.groupBox1.Controls.Add(this.FileAssociationLocation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnFileTarget);
            this.groupBox1.Controls.Add(this.FileTargetLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 85);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "正規化の設定";
            // 
            // BtnFileAssociation
            // 
            this.BtnFileAssociation.Enabled = false;
            this.BtnFileAssociation.Location = new System.Drawing.Point(547, 52);
            this.BtnFileAssociation.Name = "BtnFileAssociation";
            this.BtnFileAssociation.Size = new System.Drawing.Size(91, 23);
            this.BtnFileAssociation.TabIndex = 14;
            this.BtnFileAssociation.Text = "読み込み";
            this.BtnFileAssociation.UseVisualStyleBackColor = true;
            this.BtnFileAssociation.Click += new System.EventHandler(this.BtnFileAssociation_Click);
            // 
            // FileAssociationLocation
            // 
            this.FileAssociationLocation.Enabled = false;
            this.FileAssociationLocation.Location = new System.Drawing.Point(107, 54);
            this.FileAssociationLocation.Name = "FileAssociationLocation";
            this.FileAssociationLocation.Size = new System.Drawing.Size(434, 19);
            this.FileAssociationLocation.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(11, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "関連付けファイル：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "ターゲットポイント：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExecutableMode,
            this.ViewImagesName,
            this.ViewPointsName,
            this.empty});
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(645, 130);
            this.dataGridView1.TabIndex = 11;
            // 
            // ExecutableMode
            // 
            this.ExecutableMode.FillWeight = 50F;
            this.ExecutableMode.Frozen = true;
            this.ExecutableMode.HeaderText = "実行";
            this.ExecutableMode.Name = "ExecutableMode";
            this.ExecutableMode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExecutableMode.Width = 50;
            // 
            // ViewImagesName
            // 
            this.ViewImagesName.FillWeight = 250F;
            this.ViewImagesName.Frozen = true;
            this.ViewImagesName.HeaderText = "イメージファイル名";
            this.ViewImagesName.Name = "ViewImagesName";
            this.ViewImagesName.ReadOnly = true;
            this.ViewImagesName.Width = 250;
            // 
            // ViewPointsName
            // 
            this.ViewPointsName.FillWeight = 250F;
            this.ViewPointsName.Frozen = true;
            this.ViewPointsName.HeaderText = "ポイントファイル名";
            this.ViewPointsName.Name = "ViewPointsName";
            this.ViewPointsName.ReadOnly = true;
            this.ViewPointsName.Width = 250;
            // 
            // empty
            // 
            this.empty.FillWeight = 300F;
            this.empty.Frozen = true;
            this.empty.HeaderText = "";
            this.empty.Name = "empty";
            this.empty.ReadOnly = true;
            this.empty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.empty.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FolderImagesLocation);
            this.groupBox2.Controls.Add(this.ComboImages);
            this.groupBox2.Controls.Add(this.BtnFolderImages);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 80);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "イメージファイル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "ファイルの種類：";
            // 
            // FolderImagesLocation
            // 
            this.FolderImagesLocation.Location = new System.Drawing.Point(96, 20);
            this.FolderImagesLocation.Name = "FolderImagesLocation";
            this.FolderImagesLocation.Size = new System.Drawing.Size(155, 19);
            this.FolderImagesLocation.TabIndex = 5;
            // 
            // ComboImages
            // 
            this.ComboImages.Enabled = false;
            this.ComboImages.FormattingEnabled = true;
            this.ComboImages.Items.AddRange(new object[] {
            "JPG/JPEG -JPGファイル-",
            "BMP -ビットマップファイル-",
            "PNG -Portable Network Graphics-"});
            this.ComboImages.Location = new System.Drawing.Point(96, 52);
            this.ComboImages.Name = "ComboImages";
            this.ComboImages.Size = new System.Drawing.Size(211, 20);
            this.ComboImages.TabIndex = 4;
            this.ComboImages.Text = "JPG/JPEG -JPGファイル-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FolderPointsLocation);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ComboPoints);
            this.groupBox3.Controls.Add(this.BtnFolderPoints);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(336, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 80);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ポイントファイル";
            // 
            // FolderPointsLocation
            // 
            this.FolderPointsLocation.Location = new System.Drawing.Point(100, 20);
            this.FolderPointsLocation.Name = "FolderPointsLocation";
            this.FolderPointsLocation.Size = new System.Drawing.Size(160, 19);
            this.FolderPointsLocation.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "ファイルの種類：";
            // 
            // ComboPoints
            // 
            this.ComboPoints.Enabled = false;
            this.ComboPoints.FormattingEnabled = true;
            this.ComboPoints.Items.AddRange(new object[] {
            "PTS -ポイントテキストファイル-",
            "TXT -テキストファイル-"});
            this.ComboPoints.Location = new System.Drawing.Point(100, 52);
            this.ComboPoints.Name = "ComboPoints";
            this.ComboPoints.Size = new System.Drawing.Size(214, 20);
            this.ComboPoints.TabIndex = 6;
            this.ComboPoints.Text = "PTS -ポイントテキストファイル-";
            // 
            // BtnFolderSave
            // 
            this.BtnFolderSave.Location = new System.Drawing.Point(257, 20);
            this.BtnFolderSave.Name = "BtnFolderSave";
            this.BtnFolderSave.Size = new System.Drawing.Size(109, 23);
            this.BtnFolderSave.TabIndex = 13;
            this.BtnFolderSave.Text = "参照";
            this.BtnFolderSave.UseVisualStyleBackColor = true;
            this.BtnFolderSave.Click += new System.EventHandler(this.BtnFolderSave_Click);
            // 
            // FolderSaveLocation
            // 
            this.FolderSaveLocation.Location = new System.Drawing.Point(13, 22);
            this.FolderSaveLocation.Name = "FolderSaveLocation";
            this.FolderSaveLocation.Size = new System.Drawing.Size(238, 19);
            this.FolderSaveLocation.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.FilenameAfter);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.FilenameBefore);
            this.groupBox4.Location = new System.Drawing.Point(12, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 58);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "保存ファイル名の設定(※同じファイル名は自動的に上書き保存)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = ".png";
            // 
            // FilenameAfter
            // 
            this.FilenameAfter.Location = new System.Drawing.Point(226, 24);
            this.FilenameAfter.Name = "FilenameAfter";
            this.FilenameAfter.Size = new System.Drawing.Size(112, 19);
            this.FilenameAfter.TabIndex = 15;
            this.FilenameAfter.Text = "_n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "イメージファイル名";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnFolderSave);
            this.groupBox5.Controls.Add(this.FolderSaveLocation);
            this.groupBox5.Location = new System.Drawing.Point(12, 425);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 53);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "保存フォルダ";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(12, 506);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(251, 32);
            this.BtnRun.TabIndex = 19;
            this.BtnRun.Text = "正規化実行";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(454, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(143, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "進捗度：";
            // 
            // BtnFileRead
            // 
            this.BtnFileRead.Location = new System.Drawing.Point(208, 98);
            this.BtnFileRead.Name = "BtnFileRead";
            this.BtnFileRead.Size = new System.Drawing.Size(111, 30);
            this.BtnFileRead.TabIndex = 24;
            this.BtnFileRead.Text = "読み込み";
            this.BtnFileRead.UseVisualStyleBackColor = true;
            this.BtnFileRead.Click += new System.EventHandler(this.BtnFileRead_Click);
            // 
            // BtnFileAdd
            // 
            this.BtnFileAdd.Enabled = false;
            this.BtnFileAdd.Location = new System.Drawing.Point(504, 98);
            this.BtnFileAdd.Name = "BtnFileAdd";
            this.BtnFileAdd.Size = new System.Drawing.Size(70, 30);
            this.BtnFileAdd.TabIndex = 25;
            this.BtnFileAdd.Text = "追加";
            this.BtnFileAdd.UseVisualStyleBackColor = true;
            this.BtnFileAdd.Click += new System.EventHandler(this.BtnFileAdd_Click);
            // 
            // BtnFileInit
            // 
            this.BtnFileInit.Enabled = false;
            this.BtnFileInit.Location = new System.Drawing.Point(580, 98);
            this.BtnFileInit.Name = "BtnFileInit";
            this.BtnFileInit.Size = new System.Drawing.Size(70, 30);
            this.BtnFileInit.TabIndex = 26;
            this.BtnFileInit.Text = "初期化";
            this.BtnFileInit.UseVisualStyleBackColor = true;
            this.BtnFileInit.Click += new System.EventHandler(this.BtnFileInit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "イメージファイル名 = ポイントファイル名：";
            // 
            // ImageCounterBox
            // 
            this.ImageCounterBox.FormattingEnabled = true;
            this.ImageCounterBox.HorizontalScrollbar = true;
            this.ImageCounterBox.ItemHeight = 12;
            this.ImageCounterBox.Location = new System.Drawing.Point(667, 27);
            this.ImageCounterBox.Name = "ImageCounterBox";
            this.ImageCounterBox.Size = new System.Drawing.Size(98, 232);
            this.ImageCounterBox.TabIndex = 28;
            // 
            // PointCounterBox
            // 
            this.PointCounterBox.FormattingEnabled = true;
            this.PointCounterBox.HorizontalScrollbar = true;
            this.PointCounterBox.ItemHeight = 12;
            this.PointCounterBox.Location = new System.Drawing.Point(668, 285);
            this.PointCounterBox.Name = "PointCounterBox";
            this.PointCounterBox.Size = new System.Drawing.Size(98, 256);
            this.PointCounterBox.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(665, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "イメージファイル一覧";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(666, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "ポイントファイル一覧";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(481, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 12);
            this.label14.TabIndex = 32;
            this.label14.Text = "処理ファイル一覧";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(337, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 12);
            this.label15.TabIndex = 33;
            this.label15.Text = "選択したファイル数：";
            // 
            // RunFileCount
            // 
            this.RunFileCount.Location = new System.Drawing.Point(442, 104);
            this.RunFileCount.Name = "RunFileCount";
            this.RunFileCount.Size = new System.Drawing.Size(50, 19);
            this.RunFileCount.TabIndex = 34;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(269, 486);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(109, 52);
            this.BtnCancel.TabIndex = 35;
            this.BtnCancel.Text = "中断";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(604, 519);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 19);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "0/0";
            // 
            // cbImageOutput
            // 
            this.cbImageOutput.AutoSize = true;
            this.cbImageOutput.Location = new System.Drawing.Point(14, 484);
            this.cbImageOutput.Name = "cbImageOutput";
            this.cbImageOutput.Size = new System.Drawing.Size(90, 16);
            this.cbImageOutput.TabIndex = 37;
            this.cbImageOutput.Text = "画像書き出し";
            this.cbImageOutput.UseVisualStyleBackColor = true;
            // 
            // Aligenment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 552);
            this.Controls.Add(this.cbImageOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.RunFileCount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PointCounterBox);
            this.Controls.Add(this.ImageCounterBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnFileInit);
            this.Controls.Add(this.BtnFileAdd);
            this.Controls.Add(this.BtnFileRead);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OutputList);
            this.MaximizeBox = false;
            this.Name = "Aligenment";
            this.Text = "アライメント";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputList;
        private System.Windows.Forms.Button BtnFolderImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFolderPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFileTarget;
        private System.Windows.Forms.TextBox FileTargetLocation;
        private System.Windows.Forms.TextBox FilenameBefore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComboImages;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FolderImagesLocation;
        private System.Windows.Forms.TextBox FolderPointsLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFolderSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FolderSaveLocation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox FilenameAfter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnFileAssociation;
        private System.Windows.Forms.TextBox FileAssociationLocation;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogImages;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogPoints;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogSave;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogTarget;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogAssociation;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnFileRead;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExecutableMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewImagesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewPointsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empty;
        private System.Windows.Forms.Button BtnFileAdd;
        private System.Windows.Forms.Button BtnFileInit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox ImageCounterBox;
        private System.Windows.Forms.ListBox PointCounterBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RunFileCount;
        private System.Windows.Forms.Button BtnCancel;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbImageOutput;
    }
}

