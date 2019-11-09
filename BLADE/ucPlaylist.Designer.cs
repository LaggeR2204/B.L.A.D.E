﻿namespace BLADE
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
            this.pnlTitle.SuspendLayout();
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
            this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitle.Controls.Add(this.lblTimeColumn);
            this.pnlTitle.Controls.Add(this.lblCategoryColumn);
            this.pnlTitle.Controls.Add(this.lblArtistColumn);
            this.pnlTitle.Controls.Add(this.lblTitleColumn);
            this.pnlTitle.Location = new System.Drawing.Point(167, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(620, 40);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTimeColumn
            // 
            this.lblTimeColumn.AutoSize = true;
            this.lblTimeColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeColumn.Location = new System.Drawing.Point(525, 12);
            this.lblTimeColumn.Name = "lblTimeColumn";
            this.lblTimeColumn.Size = new System.Drawing.Size(37, 16);
            this.lblTimeColumn.TabIndex = 2;
            this.lblTimeColumn.Text = "TIME";
            this.lblTimeColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoryColumn
            // 
            this.lblCategoryColumn.AutoSize = true;
            this.lblCategoryColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryColumn.Location = new System.Drawing.Point(420, 12);
            this.lblCategoryColumn.MaximumSize = new System.Drawing.Size(93, 17);
            this.lblCategoryColumn.Name = "lblCategoryColumn";
            this.lblCategoryColumn.Size = new System.Drawing.Size(79, 16);
            this.lblCategoryColumn.TabIndex = 3;
            this.lblCategoryColumn.Text = "CATEGORY";
            this.lblCategoryColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtistColumn
            // 
            this.lblArtistColumn.AutoSize = true;
            this.lblArtistColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistColumn.Location = new System.Drawing.Point(270, 12);
            this.lblArtistColumn.MaximumSize = new System.Drawing.Size(135, 17);
            this.lblArtistColumn.Name = "lblArtistColumn";
            this.lblArtistColumn.Size = new System.Drawing.Size(49, 16);
            this.lblArtistColumn.TabIndex = 4;
            this.lblArtistColumn.Text = "ARTIST";
            this.lblArtistColumn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleColumn
            // 
            this.lblTitleColumn.AutoSize = true;
            this.lblTitleColumn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleColumn.Location = new System.Drawing.Point(86, 12);
            this.lblTitleColumn.MaximumSize = new System.Drawing.Size(171, 16);
            this.lblTitleColumn.Name = "lblTitleColumn";
            this.lblTitleColumn.Size = new System.Drawing.Size(37, 16);
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
            this.lblPlaylists.Size = new System.Drawing.Size(96, 23);
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
            // 
            // ucPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.lblPlaylists);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.Slider);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPlaylist";
            this.Size = new System.Drawing.Size(787, 565);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
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
    }
}
