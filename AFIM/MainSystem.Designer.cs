namespace AFIM
{
    partial class MainSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSystem));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnLandmarker = new System.Windows.Forms.Button();
            this.BtnAligenment = new System.Windows.Forms.Button();
            this.BtnNShape = new System.Windows.Forms.Button();
            this.BtnNTexture = new System.Windows.Forms.Button();
            this.BtnWarping = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewImageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveImageItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseActiveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPanelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LandmarkerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AligenmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NShapeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NTextureItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarpingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FaceDetectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTextureItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeIconItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrangeFormItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFaceDetect = new System.Windows.Forms.Button();
            this.MenuStripAFIM = new System.Windows.Forms.MenuStrip();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.StatusStrip.SuspendLayout();
            this.MenuStripAFIM.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLandmarker
            // 
            this.BtnLandmarker.BackgroundImage = global::AFIM.Properties.Resources.iconLandmaker;
            this.BtnLandmarker.Location = new System.Drawing.Point(3, 3);
            this.BtnLandmarker.Name = "BtnLandmarker";
            this.BtnLandmarker.Size = new System.Drawing.Size(40, 40);
            this.BtnLandmarker.TabIndex = 0;
            this.ToolTip.SetToolTip(this.BtnLandmarker, "特徴点取得");
            this.BtnLandmarker.UseVisualStyleBackColor = true;
            this.BtnLandmarker.Click += new System.EventHandler(this.LandmarkerItem_Click);
            // 
            // BtnAligenment
            // 
            this.BtnAligenment.Location = new System.Drawing.Point(3, 49);
            this.BtnAligenment.Name = "BtnAligenment";
            this.BtnAligenment.Size = new System.Drawing.Size(40, 40);
            this.BtnAligenment.TabIndex = 1;
            this.ToolTip.SetToolTip(this.BtnAligenment, "アライメント");
            this.BtnAligenment.UseVisualStyleBackColor = true;
            this.BtnAligenment.Click += new System.EventHandler(this.AligenmentItem_Click);
            // 
            // BtnNShape
            // 
            this.BtnNShape.Location = new System.Drawing.Point(3, 95);
            this.BtnNShape.Name = "BtnNShape";
            this.BtnNShape.Size = new System.Drawing.Size(40, 40);
            this.BtnNShape.TabIndex = 2;
            this.ToolTip.SetToolTip(this.BtnNShape, "形状正規化");
            this.BtnNShape.UseVisualStyleBackColor = true;
            this.BtnNShape.Click += new System.EventHandler(this.NShapeItem_Click);
            // 
            // BtnNTexture
            // 
            this.BtnNTexture.Location = new System.Drawing.Point(3, 141);
            this.BtnNTexture.Name = "BtnNTexture";
            this.BtnNTexture.Size = new System.Drawing.Size(40, 40);
            this.BtnNTexture.TabIndex = 3;
            this.ToolTip.SetToolTip(this.BtnNTexture, "テクスチャ正規化");
            this.BtnNTexture.UseVisualStyleBackColor = true;
            this.BtnNTexture.Click += new System.EventHandler(this.NTextureItem_Click);
            // 
            // BtnWarping
            // 
            this.BtnWarping.Location = new System.Drawing.Point(3, 187);
            this.BtnWarping.Name = "BtnWarping";
            this.BtnWarping.Size = new System.Drawing.Size(40, 40);
            this.BtnWarping.TabIndex = 4;
            this.ToolTip.SetToolTip(this.BtnWarping, "ワーピング");
            this.BtnWarping.UseVisualStyleBackColor = true;
            this.BtnWarping.Click += new System.EventHandler(this.WarpingItem_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(32, 18);
            this.StatusLabel.Text = "状態";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 539);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(784, 23);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewImageItem,
            this.OpenImageItem,
            this.FileMenuSeparator1,
            this.SaveImageItem,
            this.FileMenuSeparator2,
            this.CloseActiveItem,
            this.CloseAllItem,
            this.ExitItem});
            this.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(57, 22);
            this.FileMenu.Text = "File(&F)";
            // 
            // NewImageItem
            // 
            this.NewImageItem.Image = ((System.Drawing.Image)(resources.GetObject("NewImageItem.Image")));
            this.NewImageItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.NewImageItem.Name = "NewImageItem";
            this.NewImageItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewImageItem.Size = new System.Drawing.Size(212, 22);
            this.NewImageItem.Text = "New(&N)";
            this.NewImageItem.Click += new System.EventHandler(this.NewImageItem_Click);
            // 
            // OpenImageItem
            // 
            this.OpenImageItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenImageItem.Image")));
            this.OpenImageItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.OpenImageItem.Name = "OpenImageItem";
            this.OpenImageItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenImageItem.Size = new System.Drawing.Size(212, 22);
            this.OpenImageItem.Text = "Open(&O)...";
            this.OpenImageItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // FileMenuSeparator1
            // 
            this.FileMenuSeparator1.Name = "FileMenuSeparator1";
            this.FileMenuSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // SaveImageItem
            // 
            this.SaveImageItem.Enabled = false;
            this.SaveImageItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveImageItem.Image")));
            this.SaveImageItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveImageItem.Name = "SaveImageItem";
            this.SaveImageItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveImageItem.Size = new System.Drawing.Size(212, 22);
            this.SaveImageItem.Text = "Save Image(&S)";
            // 
            // FileMenuSeparator2
            // 
            this.FileMenuSeparator2.Name = "FileMenuSeparator2";
            this.FileMenuSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // CloseActiveItem
            // 
            this.CloseActiveItem.Name = "CloseActiveItem";
            this.CloseActiveItem.Size = new System.Drawing.Size(212, 22);
            this.CloseActiveItem.Text = "Close Active Window";
            this.CloseActiveItem.Click += new System.EventHandler(this.CloseActiveItem_Click);
            // 
            // CloseAllItem
            // 
            this.CloseAllItem.Name = "CloseAllItem";
            this.CloseAllItem.Size = new System.Drawing.Size(212, 22);
            this.CloseAllItem.Text = "Close All Windows";
            this.CloseAllItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(212, 22);
            this.ExitItem.Text = "Exit(&X)";
            this.ExitItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarItem,
            this.ToolPanelItem,
            this.StatusBarItem});
            this.ViewMenu.Name = "ViewMenu";
            this.ViewMenu.Size = new System.Drawing.Size(66, 22);
            this.ViewMenu.Text = "View(&V)";
            // 
            // ToolBarItem
            // 
            this.ToolBarItem.CheckOnClick = true;
            this.ToolBarItem.Name = "ToolBarItem";
            this.ToolBarItem.Size = new System.Drawing.Size(156, 22);
            this.ToolBarItem.Text = "Tool Bar(&T)";
            this.ToolBarItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // ToolPanelItem
            // 
            this.ToolPanelItem.Checked = true;
            this.ToolPanelItem.CheckOnClick = true;
            this.ToolPanelItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolPanelItem.Name = "ToolPanelItem";
            this.ToolPanelItem.Size = new System.Drawing.Size(156, 22);
            this.ToolPanelItem.Text = "Tool Panel(&P)";
            this.ToolPanelItem.Click += new System.EventHandler(this.ToolPanel_Click);
            // 
            // StatusBarItem
            // 
            this.StatusBarItem.Checked = true;
            this.StatusBarItem.CheckOnClick = true;
            this.StatusBarItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusBarItem.Name = "StatusBarItem";
            this.StatusBarItem.Size = new System.Drawing.Size(156, 22);
            this.StatusBarItem.Text = "Status Bar(&S)";
            this.StatusBarItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LandmarkerItem,
            this.AligenmentItem,
            this.NShapeItem,
            this.NTextureItem,
            this.WarpingItem,
            this.FaceDetectItem,
            this.ChangeTextureItem});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(62, 22);
            this.ToolsMenu.Text = "Tool(&T)";
            // 
            // LandmarkerItem
            // 
            this.LandmarkerItem.Name = "LandmarkerItem";
            this.LandmarkerItem.Size = new System.Drawing.Size(244, 22);
            this.LandmarkerItem.Text = "Landmarker(&L)";
            this.LandmarkerItem.Click += new System.EventHandler(this.LandmarkerItem_Click);
            // 
            // AligenmentItem
            // 
            this.AligenmentItem.Name = "AligenmentItem";
            this.AligenmentItem.Size = new System.Drawing.Size(244, 22);
            this.AligenmentItem.Text = "Aligenment(&A)";
            this.AligenmentItem.Click += new System.EventHandler(this.AligenmentItem_Click);
            // 
            // NShapeItem
            // 
            this.NShapeItem.Name = "NShapeItem";
            this.NShapeItem.Size = new System.Drawing.Size(244, 22);
            this.NShapeItem.Text = "Normalization for Shape(&S)";
            this.NShapeItem.Click += new System.EventHandler(this.NShapeItem_Click);
            // 
            // NTextureItem
            // 
            this.NTextureItem.Name = "NTextureItem";
            this.NTextureItem.Size = new System.Drawing.Size(244, 22);
            this.NTextureItem.Text = "Normalization for Texture(&T)";
            this.NTextureItem.Click += new System.EventHandler(this.NTextureItem_Click);
            // 
            // WarpingItem
            // 
            this.WarpingItem.Name = "WarpingItem";
            this.WarpingItem.Size = new System.Drawing.Size(244, 22);
            this.WarpingItem.Text = "Warping(&W)";
            this.WarpingItem.Click += new System.EventHandler(this.WarpingItem_Click);
            // 
            // FaceDetectItem
            // 
            this.FaceDetectItem.Name = "FaceDetectItem";
            this.FaceDetectItem.Size = new System.Drawing.Size(244, 22);
            this.FaceDetectItem.Text = "FaceDetect(&D)";
            this.FaceDetectItem.Click += new System.EventHandler(this.FaceDetectItem_Click);
            // 
            // ChangeTextureItem
            // 
            this.ChangeTextureItem.Name = "ChangeTextureItem";
            this.ChangeTextureItem.Size = new System.Drawing.Size(244, 22);
            this.ChangeTextureItem.Text = "ChangeTexture";
            this.ChangeTextureItem.Click += new System.EventHandler(this.ChangeTextureItem_Click);
            // 
            // WindowMenu
            // 
            this.WindowMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeItem,
            this.VerticalItem,
            this.HorizontalItem,
            this.ArrangeIconItem,
            this.ArrangeFormItem});
            this.WindowMenu.Name = "WindowMenu";
            this.WindowMenu.Size = new System.Drawing.Size(88, 22);
            this.WindowMenu.Text = "Window(&W)";
            // 
            // CascadeItem
            // 
            this.CascadeItem.Name = "CascadeItem";
            this.CascadeItem.Size = new System.Drawing.Size(186, 22);
            this.CascadeItem.Text = "Cascade View(&C)";
            this.CascadeItem.Click += new System.EventHandler(this.CascadeItem_Click);
            // 
            // VerticalItem
            // 
            this.VerticalItem.Name = "VerticalItem";
            this.VerticalItem.Size = new System.Drawing.Size(186, 22);
            this.VerticalItem.Text = "Vertical View(&V)";
            this.VerticalItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // HorizontalItem
            // 
            this.HorizontalItem.Name = "HorizontalItem";
            this.HorizontalItem.Size = new System.Drawing.Size(186, 22);
            this.HorizontalItem.Text = "Horizontal View(&H)";
            this.HorizontalItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // ArrangeIconItem
            // 
            this.ArrangeIconItem.Name = "ArrangeIconItem";
            this.ArrangeIconItem.Size = new System.Drawing.Size(186, 22);
            this.ArrangeIconItem.Text = "Arrange Icon(&I)";
            this.ArrangeIconItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // ArrangeFormItem
            // 
            this.ArrangeFormItem.Name = "ArrangeFormItem";
            this.ArrangeFormItem.Size = new System.Drawing.Size(186, 22);
            this.ArrangeFormItem.Text = "Arrange Form(&F)";
            this.ArrangeFormItem.Click += new System.EventHandler(this.ArrangeFormItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContentsItem,
            this.IndexItem,
            this.SearchItem,
            this.HelpMenuSeparator1,
            this.AboutItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(65, 22);
            this.HelpMenu.Text = "Help(&H)";
            // 
            // ContentsItem
            // 
            this.ContentsItem.Enabled = false;
            this.ContentsItem.Name = "ContentsItem";
            this.ContentsItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.ContentsItem.Size = new System.Drawing.Size(199, 22);
            this.ContentsItem.Text = "Contents(&C)";
            // 
            // IndexItem
            // 
            this.IndexItem.Enabled = false;
            this.IndexItem.Image = ((System.Drawing.Image)(resources.GetObject("IndexItem.Image")));
            this.IndexItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.IndexItem.Name = "IndexItem";
            this.IndexItem.Size = new System.Drawing.Size(199, 22);
            this.IndexItem.Text = "Index(&I)";
            // 
            // SearchItem
            // 
            this.SearchItem.Enabled = false;
            this.SearchItem.Image = ((System.Drawing.Image)(resources.GetObject("SearchItem.Image")));
            this.SearchItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Size = new System.Drawing.Size(199, 22);
            this.SearchItem.Text = "Search(&S)";
            // 
            // HelpMenuSeparator1
            // 
            this.HelpMenuSeparator1.Name = "HelpMenuSeparator1";
            this.HelpMenuSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // AboutItem
            // 
            this.AboutItem.Enabled = false;
            this.AboutItem.Name = "AboutItem";
            this.AboutItem.Size = new System.Drawing.Size(199, 22);
            this.AboutItem.Text = "About(&A)... ...";
            // 
            // ImageMenu
            // 
            this.ImageMenu.Name = "ImageMenu";
            this.ImageMenu.Size = new System.Drawing.Size(73, 22);
            this.ImageMenu.Text = "Image(&I)";
            // 
            // BtnFaceDetect
            // 
            this.BtnFaceDetect.Location = new System.Drawing.Point(3, 233);
            this.BtnFaceDetect.Name = "BtnFaceDetect";
            this.BtnFaceDetect.Size = new System.Drawing.Size(40, 40);
            this.BtnFaceDetect.TabIndex = 5;
            this.BtnFaceDetect.UseVisualStyleBackColor = true;
            this.BtnFaceDetect.Click += new System.EventHandler(this.FaceDetectItem_Click);
            // 
            // MenuStripAFIM
            // 
            this.MenuStripAFIM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ImageMenu,
            this.ToolsMenu,
            this.ViewMenu,
            this.WindowMenu,
            this.HelpMenu});
            this.MenuStripAFIM.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStripAFIM.Location = new System.Drawing.Point(0, 0);
            this.MenuStripAFIM.MdiWindowListItem = this.WindowMenu;
            this.MenuStripAFIM.Name = "MenuStripAFIM";
            this.MenuStripAFIM.Size = new System.Drawing.Size(784, 26);
            this.MenuStripAFIM.TabIndex = 0;
            this.MenuStripAFIM.Tag = "";
            this.MenuStripAFIM.Text = "MenuStrip";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Location = new System.Drawing.Point(0, 26);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(784, 25);
            this.ToolStrip.TabIndex = 4;
            this.ToolStrip.Text = "ToolStrip";
            this.ToolStrip.Visible = false;
            // 
            // ToolPanel
            // 
            this.ToolPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToolPanel.Controls.Add(this.BtnLandmarker);
            this.ToolPanel.Controls.Add(this.BtnFaceDetect);
            this.ToolPanel.Controls.Add(this.BtnWarping);
            this.ToolPanel.Controls.Add(this.BtnNTexture);
            this.ToolPanel.Controls.Add(this.BtnNShape);
            this.ToolPanel.Controls.Add(this.BtnAligenment);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToolPanel.Location = new System.Drawing.Point(734, 26);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(50, 513);
            this.ToolPanel.TabIndex = 8;
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.FileName = "OpenImageDialog";
            // 
            // MainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStripAFIM);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStripAFIM;
            this.Name = "MainSystem";
            this.Text = "AFIM";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStripAFIM.ResumeLayout(false);
            this.MenuStripAFIM.PerformLayout();
            this.ToolPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewImageItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageItem;
        private System.Windows.Forms.ToolStripSeparator FileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveImageItem;
        private System.Windows.Forms.ToolStripSeparator FileMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolBarItem;
        private System.Windows.Forms.ToolStripMenuItem StatusBarItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem LandmarkerItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenu;
        private System.Windows.Forms.ToolStripMenuItem CascadeItem;
        private System.Windows.Forms.ToolStripMenuItem VerticalItem;
        private System.Windows.Forms.ToolStripMenuItem HorizontalItem;
        private System.Windows.Forms.ToolStripMenuItem ArrangeIconItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem ContentsItem;
        private System.Windows.Forms.ToolStripMenuItem IndexItem;
        private System.Windows.Forms.ToolStripMenuItem SearchItem;
        private System.Windows.Forms.ToolStripSeparator HelpMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AboutItem;
        private System.Windows.Forms.Button BtnLandmarker;
        private System.Windows.Forms.ToolStripMenuItem ArrangeFormItem;
        private System.Windows.Forms.ToolStripMenuItem ToolPanelItem;
        private System.Windows.Forms.Button BtnAligenment;
        private System.Windows.Forms.ToolStripMenuItem ImageMenu;
        private System.Windows.Forms.Button BtnWarping;
        private System.Windows.Forms.Button BtnNTexture;
        private System.Windows.Forms.Button BtnNShape;
        private System.Windows.Forms.Button BtnFaceDetect;
        private System.Windows.Forms.MenuStrip MenuStripAFIM;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.ToolStripMenuItem AligenmentItem;
        private System.Windows.Forms.ToolStripMenuItem NShapeItem;
        public System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.ToolStripMenuItem CloseActiveItem;
        private System.Windows.Forms.ToolStripMenuItem CloseAllItem;
        private System.Windows.Forms.ToolStripMenuItem NTextureItem;
        private System.Windows.Forms.ToolStripMenuItem WarpingItem;
        private System.Windows.Forms.ToolStripMenuItem FaceDetectItem;
        private System.Windows.Forms.SaveFileDialog SaveImageDialog;
        private System.Windows.Forms.ToolStripMenuItem ChangeTextureItem;
    }
}



