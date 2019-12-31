namespace BLADE
{
    partial class ucQueue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQueue));
            this.lblTextQueue = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbSongSinger = new System.Windows.Forms.Label();
            this.lbNowPlaying = new System.Windows.Forms.Label();
            this.panelContainFPNL = new System.Windows.Forms.Panel();
            this.fpnlPlayback = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSongLove = new System.Windows.Forms.Button();
            this.btnSongLoveOff = new System.Windows.Forms.Button();
            this.picbArtCover = new System.Windows.Forms.PictureBox();
            this.panelContainFPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextQueue
            // 
            this.lblTextQueue.AutoSize = true;
            this.lblTextQueue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextQueue.Location = new System.Drawing.Point(17, 20);
            this.lblTextQueue.Name = "lblTextQueue";
            this.lblTextQueue.Size = new System.Drawing.Size(153, 32);
            this.lblTextQueue.TabIndex = 0;
            this.lblTextQueue.Text = "PLAYBACK";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(495, 72);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(11, 494);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lbSongName
            // 
            this.lbSongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSongName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.Location = new System.Drawing.Point(510, 397);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(273, 32);
            this.lbSongName.TabIndex = 3;
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSongSinger.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.Location = new System.Drawing.Point(510, 435);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(273, 21);
            this.lbSongSinger.TabIndex = 4;
            // 
            // lbNowPlaying
            // 
            this.lbNowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNowPlaying.AutoSize = true;
            this.lbNowPlaying.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNowPlaying.Location = new System.Drawing.Point(520, 72);
            this.lbNowPlaying.Name = "lbNowPlaying";
            this.lbNowPlaying.Size = new System.Drawing.Size(177, 32);
            this.lbNowPlaying.TabIndex = 6;
            this.lbNowPlaying.Text = "Now Playing";
            // 
            // panelContainFPNL
            // 
            this.panelContainFPNL.Controls.Add(this.fpnlPlayback);
            this.panelContainFPNL.Location = new System.Drawing.Point(3, 72);
            this.panelContainFPNL.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainFPNL.Name = "panelContainFPNL";
            this.panelContainFPNL.Size = new System.Drawing.Size(493, 494);
            this.panelContainFPNL.TabIndex = 8;
            // 
            // fpnlPlayback
            // 
            this.fpnlPlayback.AutoScroll = true;
            this.fpnlPlayback.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlPlayback.Location = new System.Drawing.Point(0, 0);
            this.fpnlPlayback.Name = "fpnlPlayback";
            this.fpnlPlayback.Size = new System.Drawing.Size(784, 493);
            this.fpnlPlayback.TabIndex = 0;
            this.fpnlPlayback.WrapContents = false;
            // 
            // btnSongLove
            // 
            this.btnSongLove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSongLove.FlatAppearance.BorderSize = 0;
            this.btnSongLove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongLove.Image = ((System.Drawing.Image)(resources.GetObject("btnSongLove.Image")));
            this.btnSongLove.Location = new System.Drawing.Point(510, 459);
            this.btnSongLove.Name = "btnSongLove";
            this.btnSongLove.Size = new System.Drawing.Size(40, 40);
            this.btnSongLove.TabIndex = 7;
            this.btnSongLove.UseVisualStyleBackColor = true;
            this.btnSongLove.Click += new System.EventHandler(this.btnSongLove_Click);
            // 
            // btnSongLoveOff
            // 
            this.btnSongLoveOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSongLoveOff.FlatAppearance.BorderSize = 0;
            this.btnSongLoveOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongLoveOff.Image = ((System.Drawing.Image)(resources.GetObject("btnSongLoveOff.Image")));
            this.btnSongLoveOff.Location = new System.Drawing.Point(510, 459);
            this.btnSongLoveOff.Name = "btnSongLoveOff";
            this.btnSongLoveOff.Size = new System.Drawing.Size(40, 40);
            this.btnSongLoveOff.TabIndex = 3;
            this.btnSongLoveOff.UseVisualStyleBackColor = true;
            this.btnSongLoveOff.Click += new System.EventHandler(this.btnSongLoveOff_Click);
            // 
            // picbArtCover
            // 
            this.picbArtCover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbArtCover.Location = new System.Drawing.Point(510, 123);
            this.picbArtCover.Name = "picbArtCover";
            this.picbArtCover.Size = new System.Drawing.Size(273, 264);
            this.picbArtCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbArtCover.TabIndex = 2;
            this.picbArtCover.TabStop = false;
            this.picbArtCover.WaitOnLoad = true;
            // 
            // ucQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panelContainFPNL);
            this.Controls.Add(this.btnSongLove);
            this.Controls.Add(this.btnSongLoveOff);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lbNowPlaying);
            this.Controls.Add(this.lbSongSinger);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.picbArtCover);
            this.Controls.Add(this.lblTextQueue);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucQueue";
            this.Size = new System.Drawing.Size(787, 565);
            this.SizeChanged += new System.EventHandler(this.ucQueue_SizeChanged);
            this.panelContainFPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextQueue;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox picbArtCover;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbSongSinger;
        private System.Windows.Forms.Label lbNowPlaying;
        private System.Windows.Forms.Button btnSongLoveOff;
        private System.Windows.Forms.Button btnSongLove;
        private System.Windows.Forms.Panel panelContainFPNL;
        private System.Windows.Forms.FlowLayoutPanel fpnlPlayback;
    }
}
