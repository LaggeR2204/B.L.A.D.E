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
            this.lblTextQueue = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.picbArtCover = new System.Windows.Forms.PictureBox();
            this.lbSongName = new System.Windows.Forms.Label();
            this.lbSongSinger = new System.Windows.Forms.Label();
            this.fpnlQueue = new System.Windows.Forms.FlowLayoutPanel();
            this.lbNowPlaying = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextQueue
            // 
            this.lblTextQueue.AutoSize = true;
            this.lblTextQueue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextQueue.Location = new System.Drawing.Point(17, 20);
            this.lblTextQueue.Name = "lblTextQueue";
            this.lblTextQueue.Size = new System.Drawing.Size(136, 25);
            this.lblTextQueue.TabIndex = 0;
            this.lblTextQueue.Text = "PLAY QUEUE";
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
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.Location = new System.Drawing.Point(510, 397);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(0, 25);
            this.lbSongName.TabIndex = 3;
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.AutoSize = true;
            this.lbSongSinger.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.Location = new System.Drawing.Point(510, 435);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(0, 17);
            this.lbSongSinger.TabIndex = 4;
            // 
            // fpnlQueue
            // 
            this.fpnlQueue.AutoSize = true;
            this.fpnlQueue.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlQueue.Location = new System.Drawing.Point(3, 72);
            this.fpnlQueue.Name = "fpnlQueue";
            this.fpnlQueue.Size = new System.Drawing.Size(493, 501);
            this.fpnlQueue.TabIndex = 5;
            this.fpnlQueue.WrapContents = false;
            // 
            // lbNowPlaying
            // 
            this.lbNowPlaying.AutoSize = true;
            this.lbNowPlaying.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNowPlaying.Location = new System.Drawing.Point(520, 72);
            this.lbNowPlaying.Name = "lbNowPlaying";
            this.lbNowPlaying.Size = new System.Drawing.Size(139, 25);
            this.lbNowPlaying.TabIndex = 6;
            this.lbNowPlaying.Text = "Now Playing";
            // 
            // ucQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lbNowPlaying);
            this.Controls.Add(this.fpnlQueue);
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
    }
}
