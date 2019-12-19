namespace BLADE
{
    partial class RecentlySongItem
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
            this.labelSongName = new System.Windows.Forms.Label();
            this.picbArtCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSongName
            // 
            this.labelSongName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSongName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelSongName.Location = new System.Drawing.Point(0, 167);
            this.labelSongName.Name = "labelSongName";
            this.labelSongName.Size = new System.Drawing.Size(200, 33);
            this.labelSongName.TabIndex = 1;
            this.labelSongName.Text = "label1";
            this.labelSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbArtCover
            // 
            this.picbArtCover.Location = new System.Drawing.Point(18, 0);
            this.picbArtCover.Name = "picbArtCover";
            this.picbArtCover.Size = new System.Drawing.Size(160, 160);
            this.picbArtCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbArtCover.TabIndex = 0;
            this.picbArtCover.TabStop = false;
            // 
            // RecentlySongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.labelSongName);
            this.Controls.Add(this.picbArtCover);
            this.Name = "RecentlySongItem";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.picbArtCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbArtCover;
        private System.Windows.Forms.Label labelSongName;
    }
}
