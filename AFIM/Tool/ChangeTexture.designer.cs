namespace AFIM
{
    partial class ChangeTexture
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
            this.components = new System.ComponentModel.Container();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnRun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gbMorphingLevel = new System.Windows.Forms.GroupBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbValue = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbTextureAnalysis = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textureFP = new System.Windows.Forms.Button();
            this.textrueImg = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbMorphingLevel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbTextureAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(108, 18);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Feature Points";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Imagefile";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(11, 18);
            this.hScrollBar1.Maximum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(116, 23);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Value = 5;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(6, 18);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(756, 714);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Location = new System.Drawing.Point(2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 718);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.gbMorphingLevel);
            this.panel5.Location = new System.Drawing.Point(15, 625);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 90);
            this.panel5.TabIndex = 3;
            // 
            // gbMorphingLevel
            // 
            this.gbMorphingLevel.BackColor = System.Drawing.SystemColors.Control;
            this.gbMorphingLevel.Controls.Add(this.btnAuto);
            this.gbMorphingLevel.Controls.Add(this.btnSave);
            this.gbMorphingLevel.Controls.Add(this.hScrollBar1);
            this.gbMorphingLevel.Controls.Add(this.txtbValue);
            this.gbMorphingLevel.Enabled = false;
            this.gbMorphingLevel.Location = new System.Drawing.Point(5, 7);
            this.gbMorphingLevel.Name = "gbMorphingLevel";
            this.gbMorphingLevel.Size = new System.Drawing.Size(210, 80);
            this.gbMorphingLevel.TabIndex = 1;
            this.gbMorphingLevel.TabStop = false;
            this.gbMorphingLevel.Text = "Morphing Level";
            // 
            // btnAuto
            // 
            this.btnAuto.Enabled = false;
            this.btnAuto.Location = new System.Drawing.Point(27, 47);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(86, 23);
            this.btnAuto.TabIndex = 5;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(136, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbValue
            // 
            this.txtbValue.Location = new System.Drawing.Point(136, 22);
            this.txtbValue.Name = "txtbValue";
            this.txtbValue.Size = new System.Drawing.Size(62, 19);
            this.txtbValue.TabIndex = 3;
            this.txtbValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.gbTextureAnalysis);
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Location = new System.Drawing.Point(15, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 398);
            this.panel4.TabIndex = 1;
            // 
            // gbTextureAnalysis
            // 
            this.gbTextureAnalysis.Controls.Add(this.btnCancel);
            this.gbTextureAnalysis.Controls.Add(this.pictureBox3);
            this.gbTextureAnalysis.Controls.Add(this.btnRun);
            this.gbTextureAnalysis.Enabled = false;
            this.gbTextureAnalysis.Location = new System.Drawing.Point(5, 214);
            this.gbTextureAnalysis.Name = "gbTextureAnalysis";
            this.gbTextureAnalysis.Size = new System.Drawing.Size(210, 184);
            this.gbTextureAnalysis.TabIndex = 1;
            this.gbTextureAnalysis.TabStop = false;
            this.gbTextureAnalysis.Text = "Texture Analysis";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(6, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.textureFP);
            this.groupBox3.Controls.Add(this.textrueImg);
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 205);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Texture";
            // 
            // textureFP
            // 
            this.textureFP.Location = new System.Drawing.Point(108, 18);
            this.textureFP.Name = "textureFP";
            this.textureFP.Size = new System.Drawing.Size(96, 23);
            this.textureFP.TabIndex = 10;
            this.textureFP.Text = "Feature Points";
            this.textureFP.UseVisualStyleBackColor = true;
            this.textureFP.Click += new System.EventHandler(this.textureFP_Click);
            // 
            // textrueImg
            // 
            this.textrueImg.Location = new System.Drawing.Point(6, 18);
            this.textrueImg.Name = "textrueImg";
            this.textrueImg.Size = new System.Drawing.Size(96, 23);
            this.textrueImg.TabIndex = 9;
            this.textrueImg.Text = "Imagefile";
            this.textrueImg.UseVisualStyleBackColor = true;
            this.textrueImg.Click += new System.EventHandler(this.textrueImg_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(15, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 200);
            this.panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnRead);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Data";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(256, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 718);
            this.panel1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus1,
            this.StatusProgressBar,
            this.lblStatus2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 723);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 23);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus1
            // 
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(46, 18);
            this.lblStatus1.Text = "Status";
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(100, 17);
            // 
            // lblStatus2
            // 
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(0, 18);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(6, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(198, 152);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // ChangeTexture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 746);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "ChangeTexture";
            this.Text = "Texture Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.gbMorphingLevel.ResumeLayout(false);
            this.gbMorphingLevel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.gbTextureAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtbValue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox gbMorphingLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbTextureAnalysis;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar StatusProgressBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus2;
        private System.Windows.Forms.Button textureFP;
        private System.Windows.Forms.Button textrueImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

