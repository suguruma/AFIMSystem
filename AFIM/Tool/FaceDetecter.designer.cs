namespace AFIM
{
    partial class FaceDetecter
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cmbHaarcascade = new System.Windows.Forms.ComboBox();
            this.chkFaceDetect = new System.Windows.Forms.CheckBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnImage = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openImageDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 244);
            this.panel1.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // cmbHaarcascade
            // 
            this.cmbHaarcascade.FormattingEnabled = true;
            this.cmbHaarcascade.Location = new System.Drawing.Point(154, 52);
            this.cmbHaarcascade.Name = "cmbHaarcascade";
            this.cmbHaarcascade.Size = new System.Drawing.Size(236, 20);
            this.cmbHaarcascade.TabIndex = 4;
            // 
            // chkFaceDetect
            // 
            this.chkFaceDetect.AutoSize = true;
            this.chkFaceDetect.Checked = true;
            this.chkFaceDetect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFaceDetect.Location = new System.Drawing.Point(12, 54);
            this.chkFaceDetect.Name = "chkFaceDetect";
            this.chkFaceDetect.Size = new System.Drawing.Size(84, 16);
            this.chkFaceDetect.TabIndex = 5;
            this.chkFaceDetect.Text = "顔検出位置";
            this.chkFaceDetect.UseVisualStyleBackColor = true;
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(93, 19);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 6;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.Run_Click);
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(12, 19);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(75, 23);
            this.BtnImage.TabIndex = 7;
            this.BtnImage.Text = "Image";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.Image_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Location = new System.Drawing.Point(315, 19);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(75, 23);
            this.BtnUndo.TabIndex = 8;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(234, 19);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(396, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 19);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(397, 49);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(523, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 59);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openImageDialog1
            // 
            this.openImageDialog1.FileName = "openFileDialog1";
            // 
            // FaceDetecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.chkFaceDetect);
            this.Controls.Add(this.cmbHaarcascade);
            this.Controls.Add(this.panel1);
            this.Name = "FaceDetecter";
            this.Text = "FaceDetecter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ComboBox cmbHaarcascade;
        private System.Windows.Forms.CheckBox chkFaceDetect;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openImageDialog1;
    }
}

