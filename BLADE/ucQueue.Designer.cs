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
            this.picbArtCover = new System.Windows.Forms.PictureBox();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbSongSinger = new System.Windows.Forms.Label();
            this.fpnlQueue = new System.Windows.Forms.FlowLayoutPanel();
            this.lbNowPlaying = new System.Windows.Forms.Label();
            this.btnSongLoveOff = new System.Windows.Forms.Button();
            this.btnSongLove = new System.Windows.Forms.Button();
            this.panelContainFpnlSong = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).BeginInit();
            this.panelContainFpnlSong.SuspendLayout();
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
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(495, 72);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(11, 493);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // picbArtCover
            // 
            this.picbArtCover.Location = new System.Drawing.Point(510, 123);
            this.picbArtCover.Name = "picbArtCover";
            this.picbArtCover.Size = new System.Drawing.Size(273, 264);
            this.picbArtCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbArtCover.TabIndex = 2;
            this.picbArtCover.TabStop = false;
            this.picbArtCover.WaitOnLoad = true;
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.Location = new System.Drawing.Point(510, 397);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(0, 32);
            this.lbSongName.TabIndex = 3;
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.AutoSize = true;
            this.lbSongSinger.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.Location = new System.Drawing.Point(510, 435);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(0, 21);
            this.lbSongSinger.TabIndex = 4;
            // 
            // fpnlQueue
            // 
            this.fpnlQueue.AutoScroll = true;
            this.fpnlQueue.AutoSize = true;
            this.fpnlQueue.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlQueue.Location = new System.Drawing.Point(0, 0);
            this.fpnlQueue.Name = "fpnlQueue";
            this.fpnlQueue.Size = new System.Drawing.Size(474, 302);
            this.fpnlQueue.TabIndex = 5;
            this.fpnlQueue.WrapContents = false;
            // 
            // lbNowPlaying
            // 
            this.lbNowPlaying.AutoSize = true;
            this.lbNowPlaying.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNowPlaying.Location = new System.Drawing.Point(520, 72);
            this.lbNowPlaying.Name = "lbNowPlaying";
            this.lbNowPlaying.Size = new System.Drawing.Size(177, 32);
            this.lbNowPlaying.TabIndex = 6;
            this.lbNowPlaying.Text = "Now Playing";
            // 
            // btnSongLoveOff
            // 
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
            // btnSongLove
            // 
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
            // panelContainFpnlSong
            // 
            this.panelContainFpnlSong.Controls.Add(this.fpnlQueue);
            this.panelContainFpnlSong.Location = new System.Drawing.Point(3, 72);
            this.panelContainFpnlSong.Name = "panelContainFpnlSong";
            this.panelContainFpnlSong.Size = new System.Drawing.Size(493, 490);
            this.panelContainFpnlSong.TabIndex = 8;
            // 
            // ucQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panelContainFpnlSong);
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
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).EndInit();
            this.panelContainFpnlSong.ResumeLayout(false);
            this.panelContainFpnlSong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextQueue;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox picbArtCover;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Label lbSongSinger;
        private System.Windows.Forms.FlowLayoutPanel fpnlQueue;
        private System.Windows.Forms.Label lbNowPlaying;
        private System.Windows.Forms.Button btnSongLoveOff;
        private System.Windows.Forms.Button btnSongLove;
        private System.Windows.Forms.Panel panelContainFpnlSong;
    }
}
