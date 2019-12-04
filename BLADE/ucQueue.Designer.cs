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
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextQueue
            // 
            this.lblTextQueue.AutoSize = true;
            this.lblTextQueue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextQueue.Location = new System.Drawing.Point(17, 20);
            this.lblTextQueue.Name = "lblTextQueue";
            this.lblTextQueue.Size = new System.Drawing.Size(174, 32);
            this.lblTextQueue.TabIndex = 0;
            this.lblTextQueue.Text = "PLAY QUEUE";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(490, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(23, 565);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // picbArtCover
            // 
            this.picbArtCover.Location = new System.Drawing.Point(511, 72);
            this.picbArtCover.Name = "picbArtCover";
            this.picbArtCover.Size = new System.Drawing.Size(273, 246);
            this.picbArtCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbArtCover.TabIndex = 2;
            this.picbArtCover.TabStop = false;
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.Location = new System.Drawing.Point(507, 370);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(0, 31);
            this.lbSongName.TabIndex = 3;
            // 
            // lbSongSinger
            // 
            this.lbSongSinger.AutoSize = true;
            this.lbSongSinger.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongSinger.Location = new System.Drawing.Point(507, 438);
            this.lbSongSinger.Name = "lbSongSinger";
            this.lbSongSinger.Size = new System.Drawing.Size(0, 21);
            this.lbSongSinger.TabIndex = 4;
            // 
            // ucQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lbSongSinger);
            this.Controls.Add(this.lbSongName);
            this.Controls.Add(this.picbArtCover);
            this.Controls.Add(this.bunifuSeparator1);
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
    }
}
