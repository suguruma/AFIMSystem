namespace AFIM
{
    partial class NewWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblFileName = new System.Windows.Forms.Label();
            this.TbFilename = new System.Windows.Forms.TextBox();
            this.GbImageSize = new System.Windows.Forms.GroupBox();
            this.CnbBoxHeight = new System.Windows.Forms.ComboBox();
            this.CnbBoxWidth = new System.Windows.Forms.ComboBox();
            this.TbHeight = new System.Windows.Forms.TextBox();
            this.TbWidth = new System.Windows.Forms.TextBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.GbImageSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(189, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Location = new System.Drawing.Point(10, 23);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(83, 12);
            this.LblFileName.TabIndex = 2;
            this.LblFileName.Text = "File Name (&N) :";
            // 
            // TbFilename
            // 
            this.TbFilename.Location = new System.Drawing.Point(103, 20);
            this.TbFilename.Name = "TbFilename";
            this.TbFilename.Size = new System.Drawing.Size(186, 19);
            this.TbFilename.TabIndex = 3;
            this.TbFilename.Text = "Untitled";
            // 
            // GbImageSize
            // 
            this.GbImageSize.Controls.Add(this.CnbBoxHeight);
            this.GbImageSize.Controls.Add(this.CnbBoxWidth);
            this.GbImageSize.Controls.Add(this.TbHeight);
            this.GbImageSize.Controls.Add(this.TbWidth);
            this.GbImageSize.Controls.Add(this.LblHeight);
            this.GbImageSize.Controls.Add(this.LblWidth);
            this.GbImageSize.Location = new System.Drawing.Point(14, 45);
            this.GbImageSize.Name = "GbImageSize";
            this.GbImageSize.Size = new System.Drawing.Size(275, 95);
            this.GbImageSize.TabIndex = 4;
            this.GbImageSize.TabStop = false;
            this.GbImageSize.Text = "Image Size";
            // 
            // CnbBoxHeight
            // 
            this.CnbBoxHeight.FormattingEnabled = true;
            this.CnbBoxHeight.Location = new System.Drawing.Point(178, 53);
            this.CnbBoxHeight.Name = "CnbBoxHeight";
            this.CnbBoxHeight.Size = new System.Drawing.Size(91, 20);
            this.CnbBoxHeight.TabIndex = 5;
            this.CnbBoxHeight.Text = "pixcel";
            // 
            // CnbBoxWidth
            // 
            this.CnbBoxWidth.FormattingEnabled = true;
            this.CnbBoxWidth.Location = new System.Drawing.Point(178, 27);
            this.CnbBoxWidth.Name = "CnbBoxWidth";
            this.CnbBoxWidth.Size = new System.Drawing.Size(91, 20);
            this.CnbBoxWidth.TabIndex = 4;
            this.CnbBoxWidth.Text = "pixcel";
            // 
            // TbHeight
            // 
            this.TbHeight.Location = new System.Drawing.Point(89, 53);
            this.TbHeight.Name = "TbHeight";
            this.TbHeight.Size = new System.Drawing.Size(83, 19);
            this.TbHeight.TabIndex = 3;
            this.TbHeight.Text = "480";
            // 
            // TbWidth
            // 
            this.TbWidth.Location = new System.Drawing.Point(89, 27);
            this.TbWidth.Name = "TbWidth";
            this.TbWidth.Size = new System.Drawing.Size(83, 19);
            this.TbWidth.TabIndex = 2;
            this.TbWidth.Text = "600";
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(15, 56);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(64, 12);
            this.LblHeight.TabIndex = 1;
            this.LblHeight.Text = "Height (&H) :";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(19, 30);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(60, 12);
            this.LblWidth.TabIndex = 0;
            this.LblWidth.Text = "Width (&W) :";
            // 
            // NewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 181);
            this.Controls.Add(this.GbImageSize);
            this.Controls.Add(this.TbFilename);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.GbImageSize.ResumeLayout(false);
            this.GbImageSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.GroupBox GbImageSize;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.ComboBox CnbBoxHeight;
        private System.Windows.Forms.ComboBox CnbBoxWidth;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox TbFilename;
        public System.Windows.Forms.TextBox TbHeight;
        public System.Windows.Forms.TextBox TbWidth;
    }
}