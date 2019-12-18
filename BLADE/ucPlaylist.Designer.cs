namespace BLADE
{
    partial class ucPlaylist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPlaylist));
            this.Slider = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTimeColumn = new System.Windows.Forms.Label();
            this.lblCategoryColumn = new System.Windows.Forms.Label();
            this.lblArtistColumn = new System.Windows.Forms.Label();
            this.lblTitleColumn = new System.Windows.Forms.Label();
            this.lblPlaylists = new System.Windows.Forms.Label();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.fpnlSongView = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlPlaylistView = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlListSong = new System.Windows.Forms.Panel();
            this.panelContainSongView = new System.Windows.Forms.Panel();
            this.vsbarSongView = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.vsbarPlaylistView = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.panelContainPlaylistView = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlListSong.SuspendLayout();
            this.panelContainSongView.SuspendLayout();
            this.panelContainPlaylistView.SuspendLayout();
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Slider.BackColor = System.Drawing.Color.Transparent;
            this.Slider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Slider.LineThickness = 1;
            this.Slider.Location = new System.Drawing.Point(165, 0);
            this.Slider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(1, 565);
            this.Slider.TabIndex = 0;
            this.Slider.Transparency = 255;
            this.Slider.Vertical = true;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblTimeColumn);
            this.pnlTitle.Controls.Add(this.lblCategoryColumn);
            this.pnlTitle.Controls.Add(this.lblArtistColumn);
            this.pnlTitle.Controls.Add(this.lblTitleColumn);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(620, 40);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTimeColumn
            // 
            this.lblTimeColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeColumn.AutoSize = true;
            this.lblTimeColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeColumn.Location = new System.Drawing.Point(490, 12);
            this.lblTimeColumn.Name = "lblTimeColumn";
            this.lblTimeColumn.Size = new System.Drawing.Size(45, 19);
            this.lblTimeColumn.TabIndex = 2;
            this.lblTimeColumn.Text = "TIME";
            this.lblTimeColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoryColumn
            // 
            this.lblCategoryColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoryColumn.AutoSize = true;
            this.lblCategoryColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryColumn.Location = new System.Drawing.Point(380, 12);
            this.lblCategoryColumn.MaximumSize = new System.Drawing.Size(93, 17);
            this.lblCategoryColumn.Name = "lblCategoryColumn";
            this.lblCategoryColumn.Size = new System.Drawing.Size(89, 17);
            this.lblCategoryColumn.TabIndex = 3;
            this.lblCategoryColumn.Text = "CATEGORY";
            this.lblCategoryColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtistColumn
            // 
            this.lblArtistColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtistColumn.AutoSize = true;
            this.lblArtistColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistColumn.Location = new System.Drawing.Point(240, 12);
            this.lblArtistColumn.MaximumSize = new System.Drawing.Size(135, 17);
            this.lblArtistColumn.Name = "lblArtistColumn";
            this.lblArtistColumn.Size = new System.Drawing.Size(60, 17);
            this.lblArtistColumn.TabIndex = 4;
            this.lblArtistColumn.Text = "ARTIST";
            this.lblArtistColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleColumn
            // 
            this.lblTitleColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleColumn.AutoSize = true;
            this.lblTitleColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleColumn.Location = new System.Drawing.Point(40, 12);
            this.lblTitleColumn.MaximumSize = new System.Drawing.Size(171, 16);
            this.lblTitleColumn.Name = "lblTitleColumn";
            this.lblTitleColumn.Size = new System.Drawing.Size(44, 16);
            this.lblTitleColumn.TabIndex = 5;
            this.lblTitleColumn.Text = "TITLE";
            this.lblTitleColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlaylists
            // 
            this.lblPlaylists.AutoSize = true;
            this.lblPlaylists.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylists.Location = new System.Drawing.Point(3, 7);
            this.lblPlaylists.Name = "lblPlaylists";
            this.lblPlaylists.Size = new System.Drawing.Size(121, 28);
            this.lblPlaylists.TabIndex = 6;
            this.lblPlaylists.Text = "PLAYLISTS";
            this.lblPlaylists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.FlatAppearance.BorderSize = 0;
            this.btnAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPlaylist.Image")));
            this.btnAddPlaylist.Location = new System.Drawing.Point(121, 0);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(40, 40);
            this.btnAddPlaylist.TabIndex = 7;
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAddPlaylist_MouseClick);
            // 
            // fpnlSongView
            // 
            this.fpnlSongView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnlSongView.AutoScroll = true;
            this.fpnlSongView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlSongView.Location = new System.Drawing.Point(0, 0);
            this.fpnlSongView.Name = "fpnlSongView";
            this.fpnlSongView.Size = new System.Drawing.Size(636, 519);
            this.fpnlSongView.TabIndex = 8;
            this.fpnlSongView.WrapContents = false;
            // 
            // fpnlPlaylistView
            // 
            this.fpnlPlaylistView.AutoScroll = true;
            this.fpnlPlaylistView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlPlaylistView.Location = new System.Drawing.Point(0, 0);
            this.fpnlPlaylistView.Name = "fpnlPlaylistView";
            this.fpnlPlaylistView.Size = new System.Drawing.Size(204, 525);
            this.fpnlPlaylistView.TabIndex = 0;
            this.fpnlPlaylistView.WrapContents = false;
            // 
            // pnlListSong
            // 
            this.pnlListSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListSong.AutoSize = true;
            this.pnlListSong.Controls.Add(this.panelContainSongView);
            this.pnlListSong.Controls.Add(this.vsbarSongView);
            this.pnlListSong.Controls.Add(this.pnlTitle);
            this.pnlListSong.Location = new System.Drawing.Point(167, 0);
            this.pnlListSong.Name = "pnlListSong";
            this.pnlListSong.Size = new System.Drawing.Size(620, 565);
            this.pnlListSong.TabIndex = 9;
            // 
            // panelContainSongView
            // 
            this.panelContainSongView.Controls.Add(this.fpnlSongView);
            this.panelContainSongView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainSongView.Location = new System.Drawing.Point(0, 40);
            this.panelContainSongView.Name = "panelContainSongView";
            this.panelContainSongView.Size = new System.Drawing.Size(600, 525);
            this.panelContainSongView.TabIndex = 10;
            // 
            // vsbarSongView
            // 
            this.vsbarSongView.AllowCursorChanges = true;
            this.vsbarSongView.AllowHomeEndKeysDetection = false;
            this.vsbarSongView.AllowIncrementalClickMoves = true;
            this.vsbarSongView.AllowMouseDownEffects = true;
            this.vsbarSongView.AllowMouseHoverEffects = true;
            this.vsbarSongView.AllowScrollingAnimations = true;
            this.vsbarSongView.AllowScrollKeysDetection = true;
            this.vsbarSongView.AllowScrollOptionsMenu = true;
            this.vsbarSongView.AllowShrinkingOnFocusLost = false;
            this.vsbarSongView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vsbarSongView.BackgroundImage")));
            this.vsbarSongView.BindingContainer = this.fpnlSongView;
            this.vsbarSongView.BorderRadius = 1;
            this.vsbarSongView.BorderThickness = 1;
            this.vsbarSongView.Dock = System.Windows.Forms.DockStyle.Right;
            this.vsbarSongView.DurationBeforeShrink = 2000;
            this.vsbarSongView.LargeChange = 20;
            this.vsbarSongView.Location = new System.Drawing.Point(600, 40);
            this.vsbarSongView.Margin = new System.Windows.Forms.Padding(5);
            this.vsbarSongView.Maximum = 100;
            this.vsbarSongView.Minimum = 0;
            this.vsbarSongView.MinimumThumbLength = 18;
            this.vsbarSongView.Name = "vsbarSongView";
            this.vsbarSongView.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.vsbarSongView.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.vsbarSongView.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.vsbarSongView.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.vsbarSongView.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.vsbarSongView.ShrinkSizeLimit = 3;
            this.vsbarSongView.Size = new System.Drawing.Size(20, 525);
            this.vsbarSongView.SmallChange = 5;
            this.vsbarSongView.TabIndex = 9;
            this.vsbarSongView.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.vsbarSongView.ThumbLength = 103;
            this.vsbarSongView.ThumbMargin = 1;
            this.vsbarSongView.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.vsbarSongView.Value = 0;
            this.vsbarSongView.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.bunifuVScrollBar1_Scroll);
            // 
            // vsbarPlaylistView
            // 
            this.vsbarPlaylistView.AllowCursorChanges = true;
            this.vsbarPlaylistView.AllowHomeEndKeysDetection = false;
            this.vsbarPlaylistView.AllowIncrementalClickMoves = true;
            this.vsbarPlaylistView.AllowMouseDownEffects = true;
            this.vsbarPlaylistView.AllowMouseHoverEffects = true;
            this.vsbarPlaylistView.AllowScrollingAnimations = true;
            this.vsbarPlaylistView.AllowScrollKeysDetection = true;
            this.vsbarPlaylistView.AllowScrollOptionsMenu = true;
            this.vsbarPlaylistView.AllowShrinkingOnFocusLost = false;
            this.vsbarPlaylistView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vsbarPlaylistView.BackgroundImage")));
            this.vsbarPlaylistView.BindingContainer = this.fpnlPlaylistView;
            this.vsbarPlaylistView.BorderRadius = 1;
            this.vsbarPlaylistView.BorderThickness = 1;
            this.vsbarPlaylistView.DurationBeforeShrink = 2000;
            this.vsbarPlaylistView.LargeChange = 10;
            this.vsbarPlaylistView.Location = new System.Drawing.Point(140, 40);
            this.vsbarPlaylistView.Margin = new System.Windows.Forms.Padding(5);
            this.vsbarPlaylistView.Maximum = 100;
            this.vsbarPlaylistView.Minimum = 0;
            this.vsbarPlaylistView.MinimumThumbLength = 18;
            this.vsbarPlaylistView.Name = "vsbarPlaylistView";
            this.vsbarPlaylistView.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.vsbarPlaylistView.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.vsbarPlaylistView.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.vsbarPlaylistView.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.vsbarPlaylistView.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.vsbarPlaylistView.ShrinkSizeLimit = 3;
            this.vsbarPlaylistView.Size = new System.Drawing.Size(20, 525);
            this.vsbarPlaylistView.SmallChange = 1;
            this.vsbarPlaylistView.TabIndex = 10;
            this.vsbarPlaylistView.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.vsbarPlaylistView.ThumbLength = 51;
            this.vsbarPlaylistView.ThumbMargin = 1;
            this.vsbarPlaylistView.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.vsbarPlaylistView.Value = 0;
            this.vsbarPlaylistView.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.bunifuVScrollBar2_Scroll);
            // 
            // panelContainPlaylistView
            // 
            this.panelContainPlaylistView.Controls.Add(this.fpnlPlaylistView);
            this.panelContainPlaylistView.Location = new System.Drawing.Point(0, 40);
            this.panelContainPlaylistView.Name = "panelContainPlaylistView";
            this.panelContainPlaylistView.Size = new System.Drawing.Size(140, 525);
            this.panelContainPlaylistView.TabIndex = 11;
            // 
            // ucPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panelContainPlaylistView);
            this.Controls.Add(this.vsbarPlaylistView);
            this.Controls.Add(this.pnlListSong);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.lblPlaylists);
            this.Controls.Add(this.Slider);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPlaylist";
            this.Size = new System.Drawing.Size(787, 565);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlListSong.ResumeLayout(false);
            this.panelContainSongView.ResumeLayout(false);
            this.panelContainPlaylistView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator Slider;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTimeColumn;
        private System.Windows.Forms.Label lblCategoryColumn;
        private System.Windows.Forms.Label lblArtistColumn;
        private System.Windows.Forms.Label lblTitleColumn;
        private System.Windows.Forms.Label lblPlaylists;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.FlowLayoutPanel fpnlSongView;
        private System.Windows.Forms.FlowLayoutPanel fpnlPlaylistView;
        private System.Windows.Forms.Panel pnlListSong;
        private System.Windows.Forms.Panel panelContainSongView;
        private Bunifu.UI.WinForms.BunifuVScrollBar vsbarSongView;
        private Bunifu.UI.WinForms.BunifuVScrollBar vsbarPlaylistView;
        private System.Windows.Forms.Panel panelContainPlaylistView;
    }
}
