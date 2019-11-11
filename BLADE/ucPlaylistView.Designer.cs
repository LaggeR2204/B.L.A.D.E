namespace BLADE
{
    partial class ucPlaylistView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPlaylistView));
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.btnPlaylistMenu = new System.Windows.Forms.Button();
            this.ctxtmsPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmsPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(3, 12);
            this.lblPlaylistName.MaximumSize = new System.Drawing.Size(135, 17);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(119, 17);
            this.lblPlaylistName.TabIndex = 2;
            this.lblPlaylistName.Text = "Playlist Name";
            this.lblPlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlaylistMenu
            // 
            this.btnPlaylistMenu.FlatAppearance.BorderSize = 0;
            this.btnPlaylistMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylistMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylistMenu.Image")));
            this.btnPlaylistMenu.Location = new System.Drawing.Point(120, 0);
            this.btnPlaylistMenu.Name = "btnPlaylistMenu";
            this.btnPlaylistMenu.Size = new System.Drawing.Size(40, 40);
            this.btnPlaylistMenu.TabIndex = 3;
            this.btnPlaylistMenu.UseVisualStyleBackColor = true;
            // 
            // ctxtmsPlaylist
            // 
            this.ctxtmsPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctxtmsPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctxtmsPlaylist.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctxtmsPlaylist.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmsPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ctxtmsPlaylist.Name = "ctxtmsPlaylist";
            this.ctxtmsPlaylist.ShowImageMargin = false;
            this.ctxtmsPlaylist.ShowItemToolTips = false;
            this.ctxtmsPlaylist.Size = new System.Drawing.Size(186, 110);
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.addSongToolStripMenuItem.Text = "Add song";
            this.addSongToolStripMenuItem.Click += new System.EventHandler(this.AddSongToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ucPlaylistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnPlaylistMenu);
            this.Controls.Add(this.lblPlaylistName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucPlaylistView";
            this.Size = new System.Drawing.Size(160, 40);
            this.MouseLeave += new System.EventHandler(this.ucPlaylistView_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ucPlaylistView_MouseHover);
            this.ctxtmsPlaylist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Button btnPlaylistMenu;
        private System.Windows.Forms.ContextMenuStrip ctxtmsPlaylist;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
