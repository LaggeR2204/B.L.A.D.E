namespace BLADE
{
    partial class SongItemInQueue
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongItemInQueue));
            this.btnSongPlay = new System.Windows.Forms.Button();
            this.btnSongPause = new System.Windows.Forms.Button();
            this.lblSongNameSVD = new System.Windows.Forms.Label();
            this.lblArtistSVD = new System.Windows.Forms.Label();
            this.lblTimeSVD = new System.Windows.Forms.Label();
            this.btnSongMenu = new System.Windows.Forms.Button();
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSongPlay
            // 
            this.btnSongPlay.FlatAppearance.BorderSize = 0;
            this.btnSongPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnSongPlay.Image")));
            this.btnSongPlay.Location = new System.Drawing.Point(2, 0);
            this.btnSongPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSongPlay.Name = "btnSongPlay";
            this.btnSongPlay.Size = new System.Drawing.Size(30, 32);
            this.btnSongPlay.TabIndex = 1;
            this.btnSongPlay.UseVisualStyleBackColor = true;
            // 
            // btnSongPause
            // 
            this.btnSongPause.FlatAppearance.BorderSize = 0;
            this.btnSongPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongPause.Image = ((System.Drawing.Image)(resources.GetObject("btnSongPause.Image")));
            this.btnSongPause.Location = new System.Drawing.Point(2, 0);
            this.btnSongPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSongPause.Name = "btnSongPause";
            this.btnSongPause.Size = new System.Drawing.Size(30, 32);
            this.btnSongPause.TabIndex = 2;
            this.btnSongPause.UseVisualStyleBackColor = true;
            // 
            // lblSongNameSVD
            // 
            this.lblSongNameSVD.AutoSize = true;
            this.lblSongNameSVD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongNameSVD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSongNameSVD.Location = new System.Drawing.Point(37, 8);
            this.lblSongNameSVD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSongNameSVD.MaximumSize = new System.Drawing.Size(128, 13);
            this.lblSongNameSVD.Name = "lblSongNameSVD";
            this.lblSongNameSVD.Size = new System.Drawing.Size(83, 13);
            this.lblSongNameSVD.TabIndex = 3;
            this.lblSongNameSVD.Text = "Song Name";
            this.lblSongNameSVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtistSVD
            // 
            this.lblArtistSVD.AutoSize = true;
            this.lblArtistSVD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistSVD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblArtistSVD.Location = new System.Drawing.Point(186, 8);
            this.lblArtistSVD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtistSVD.MaximumSize = new System.Drawing.Size(101, 14);
            this.lblArtistSVD.Name = "lblArtistSVD";
            this.lblArtistSVD.Size = new System.Drawing.Size(39, 14);
            this.lblArtistSVD.TabIndex = 4;
            this.lblArtistSVD.Text = "Artist";
            this.lblArtistSVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeSVD
            // 
            this.lblTimeSVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeSVD.AutoSize = true;
            this.lblTimeSVD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSVD.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTimeSVD.Location = new System.Drawing.Point(286, 8);
            this.lblTimeSVD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeSVD.Name = "lblTimeSVD";
            this.lblTimeSVD.Size = new System.Drawing.Size(37, 16);
            this.lblTimeSVD.TabIndex = 5;
            this.lblTimeSVD.Text = "time";
            this.lblTimeSVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSongMenu
            // 
            this.btnSongMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSongMenu.FlatAppearance.BorderSize = 0;
            this.btnSongMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSongMenu.Image")));
            this.btnSongMenu.Location = new System.Drawing.Point(340, 0);
            this.btnSongMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSongMenu.Name = "btnSongMenu";
            this.btnSongMenu.Size = new System.Drawing.Size(30, 32);
            this.btnSongMenu.TabIndex = 6;
            this.btnSongMenu.UseVisualStyleBackColor = true;
            this.btnSongMenu.Click += new System.EventHandler(this.btnSongMenu_Click);
            // 
            // ctxtMenu
            // 
            this.ctxtMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctxtMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromQueueToolStripMenuItem});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.ShowImageMargin = false;
            this.ctxtMenu.ShowItemToolTips = false;
            this.ctxtMenu.Size = new System.Drawing.Size(198, 28);
            // 
            // removeFromQueueToolStripMenuItem
            // 
            this.removeFromQueueToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromQueueToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.removeFromQueueToolStripMenuItem.Name = "removeFromQueueToolStripMenuItem";
            this.removeFromQueueToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.removeFromQueueToolStripMenuItem.Text = "Remove From Queue";
            this.removeFromQueueToolStripMenuItem.Click += new System.EventHandler(this.removeFromQueueToolStripMenuItem_Click);
            // 
            // SongItemInQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnSongMenu);
            this.Controls.Add(this.lblTimeSVD);
            this.Controls.Add(this.lblArtistSVD);
            this.Controls.Add(this.lblSongNameSVD);
            this.Controls.Add(this.btnSongPause);
            this.Controls.Add(this.btnSongPlay);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SongItemInQueue";
            this.Size = new System.Drawing.Size(370, 32);
            this.ctxtMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSongPlay;
        private System.Windows.Forms.Button btnSongPause;
        private System.Windows.Forms.Label lblSongNameSVD;
        private System.Windows.Forms.Label lblArtistSVD;
        private System.Windows.Forms.Label lblTimeSVD;
        private System.Windows.Forms.Button btnSongMenu;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem removeFromQueueToolStripMenuItem;
    }
}
