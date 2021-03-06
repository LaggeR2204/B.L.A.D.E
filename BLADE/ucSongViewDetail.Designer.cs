﻿namespace BLADE
{
    partial class ucSongViewDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSongViewDetail));
            this.lblSongNameSVD = new System.Windows.Forms.Label();
            this.lblArtistSVD = new System.Windows.Forms.Label();
            this.lblCategorySVD = new System.Windows.Forms.Label();
            this.lblTimeSVD = new System.Windows.Forms.Label();
            this.ctxtmsSong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToPlaybackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLocalFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSongLoveOff = new System.Windows.Forms.Button();
            this.btnSongLove = new System.Windows.Forms.Button();
            this.btnSongMenu = new System.Windows.Forms.Button();
            this.ctxtmsSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSongNameSVD
            // 
            this.lblSongNameSVD.AutoSize = true;
            this.lblSongNameSVD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongNameSVD.Location = new System.Drawing.Point(46, 11);
            this.lblSongNameSVD.MaximumSize = new System.Drawing.Size(171, 16);
            this.lblSongNameSVD.Name = "lblSongNameSVD";
            this.lblSongNameSVD.Size = new System.Drawing.Size(106, 16);
            this.lblSongNameSVD.TabIndex = 1;
            this.lblSongNameSVD.Text = "Song Name";
            this.lblSongNameSVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtistSVD
            // 
            this.lblArtistSVD.AutoSize = true;
            this.lblArtistSVD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistSVD.Location = new System.Drawing.Point(240, 11);
            this.lblArtistSVD.MaximumSize = new System.Drawing.Size(135, 17);
            this.lblArtistSVD.Name = "lblArtistSVD";
            this.lblArtistSVD.Size = new System.Drawing.Size(52, 17);
            this.lblArtistSVD.TabIndex = 1;
            this.lblArtistSVD.Text = "Artist";
            this.lblArtistSVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategorySVD
            // 
            this.lblCategorySVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategorySVD.AutoSize = true;
            this.lblCategorySVD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorySVD.Location = new System.Drawing.Point(380, 11);
            this.lblCategorySVD.MaximumSize = new System.Drawing.Size(93, 17);
            this.lblCategorySVD.Name = "lblCategorySVD";
            this.lblCategorySVD.Size = new System.Drawing.Size(89, 17);
            this.lblCategorySVD.TabIndex = 1;
            this.lblCategorySVD.Text = "Category";
            this.lblCategorySVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeSVD
            // 
            this.lblTimeSVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeSVD.AutoSize = true;
            this.lblTimeSVD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSVD.Location = new System.Drawing.Point(510, 11);
            this.lblTimeSVD.Name = "lblTimeSVD";
            this.lblTimeSVD.Size = new System.Drawing.Size(49, 21);
            this.lblTimeSVD.TabIndex = 1;
            this.lblTimeSVD.Text = "time";
            this.lblTimeSVD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctxtmsSong
            // 
            this.ctxtmsSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctxtmsSong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmsSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToPlaybackToolStripMenuItem,
            this.openLocalFileToolStripMenuItem,
            this.deleteSongToolStripMenuItem});
            this.ctxtmsSong.Name = "ctxtmsSong";
            this.ctxtmsSong.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ctxtmsSong.ShowImageMargin = false;
            this.ctxtmsSong.ShowItemToolTips = false;
            this.ctxtmsSong.Size = new System.Drawing.Size(198, 82);
            // 
            // addToPlaybackToolStripMenuItem
            // 
            this.addToPlaybackToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToPlaybackToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.addToPlaybackToolStripMenuItem.Name = "addToPlaybackToolStripMenuItem";
            this.addToPlaybackToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.addToPlaybackToolStripMenuItem.Text = "Add To Playback";
            this.addToPlaybackToolStripMenuItem.Click += new System.EventHandler(this.addToPlaybackToolStripMenuItem_Click);
            // 
            // openLocalFileToolStripMenuItem
            // 
            this.openLocalFileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLocalFileToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.openLocalFileToolStripMenuItem.Name = "openLocalFileToolStripMenuItem";
            this.openLocalFileToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.openLocalFileToolStripMenuItem.Text = "Open Local File";
            this.openLocalFileToolStripMenuItem.Click += new System.EventHandler(this.openLocalFileToolStripMenuItem_Click);
            // 
            // deleteSongToolStripMenuItem
            // 
            this.deleteSongToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSongToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteSongToolStripMenuItem.Name = "deleteSongToolStripMenuItem";
            this.deleteSongToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.deleteSongToolStripMenuItem.Text = "Remove Song";
            this.deleteSongToolStripMenuItem.Click += new System.EventHandler(this.DeleteSongToolStripMenuItem_Click);
            // 
            // btnSongLoveOff
            // 
            this.btnSongLoveOff.FlatAppearance.BorderSize = 0;
            this.btnSongLoveOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongLoveOff.Image = ((System.Drawing.Image)(resources.GetObject("btnSongLoveOff.Image")));
            this.btnSongLoveOff.Location = new System.Drawing.Point(0, 0);
            this.btnSongLoveOff.Name = "btnSongLoveOff";
            this.btnSongLoveOff.Size = new System.Drawing.Size(40, 40);
            this.btnSongLoveOff.TabIndex = 2;
            this.btnSongLoveOff.UseVisualStyleBackColor = true;
            this.btnSongLoveOff.Click += new System.EventHandler(this.btnSongLoveOff_Click);
            // 
            // btnSongLove
            // 
            this.btnSongLove.FlatAppearance.BorderSize = 0;
            this.btnSongLove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongLove.Image = ((System.Drawing.Image)(resources.GetObject("btnSongLove.Image")));
            this.btnSongLove.Location = new System.Drawing.Point(0, 0);
            this.btnSongLove.Name = "btnSongLove";
            this.btnSongLove.Size = new System.Drawing.Size(40, 40);
            this.btnSongLove.TabIndex = 0;
            this.btnSongLove.UseVisualStyleBackColor = true;
            this.btnSongLove.Click += new System.EventHandler(this.BtnSongLove_Click);
            // 
            // btnSongMenu
            // 
            this.btnSongMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSongMenu.FlatAppearance.BorderSize = 0;
            this.btnSongMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnSongMenu.Image")));
            this.btnSongMenu.Location = new System.Drawing.Point(580, 0);
            this.btnSongMenu.Name = "btnSongMenu";
            this.btnSongMenu.Size = new System.Drawing.Size(40, 40);
            this.btnSongMenu.TabIndex = 0;
            this.btnSongMenu.UseVisualStyleBackColor = true;
            this.btnSongMenu.Click += new System.EventHandler(this.BtnSongMenu_Click);
            // 
            // ucSongViewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnSongLoveOff);
            this.Controls.Add(this.lblTimeSVD);
            this.Controls.Add(this.lblCategorySVD);
            this.Controls.Add(this.lblArtistSVD);
            this.Controls.Add(this.lblSongNameSVD);
            this.Controls.Add(this.btnSongLove);
            this.Controls.Add(this.btnSongMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucSongViewDetail";
            this.Size = new System.Drawing.Size(620, 40);
            this.ctxtmsSong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSongMenu;
        private System.Windows.Forms.Button btnSongLove;
        private System.Windows.Forms.Label lblSongNameSVD;
        private System.Windows.Forms.Label lblArtistSVD;
        private System.Windows.Forms.Label lblCategorySVD;
        private System.Windows.Forms.Label lblTimeSVD;
        private System.Windows.Forms.ContextMenuStrip ctxtmsSong;
        private System.Windows.Forms.ToolStripMenuItem deleteSongToolStripMenuItem;
        private System.Windows.Forms.Button btnSongLoveOff;
        private System.Windows.Forms.ToolStripMenuItem addToPlaybackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLocalFileToolStripMenuItem;
    }
}
