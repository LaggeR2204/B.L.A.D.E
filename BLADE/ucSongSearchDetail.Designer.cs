namespace BLADE
{
    partial class ucSongSearchDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSongSearchDetail));
            this.lblSongNameSSD = new System.Windows.Forms.Label();
            this.lblArtistSSD = new System.Windows.Forms.Label();
            this.lblNumberPlays = new System.Windows.Forms.Label();
            this.lblTextPlays = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSongNameSSD
            // 
            this.lblSongNameSSD.AutoSize = true;
            this.lblSongNameSSD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongNameSSD.Location = new System.Drawing.Point(25, 10);
            this.lblSongNameSSD.MaximumSize = new System.Drawing.Size(400, 21);
            this.lblSongNameSSD.Name = "lblSongNameSSD";
            this.lblSongNameSSD.Size = new System.Drawing.Size(86, 16);
            this.lblSongNameSSD.TabIndex = 2;
            this.lblSongNameSSD.Text = "Some Name";
            this.lblSongNameSSD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtistSSD
            // 
            this.lblArtistSSD.AutoSize = true;
            this.lblArtistSSD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistSSD.Location = new System.Drawing.Point(20, 30);
            this.lblArtistSSD.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblArtistSSD.Name = "lblArtistSSD";
            this.lblArtistSSD.Size = new System.Drawing.Size(39, 17);
            this.lblArtistSSD.TabIndex = 3;
            this.lblArtistSSD.Text = "Artist";
            this.lblArtistSSD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberPlays
            // 
            this.lblNumberPlays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberPlays.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPlays.Location = new System.Drawing.Point(545, 20);
            this.lblNumberPlays.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblNumberPlays.Name = "lblNumberPlays";
            this.lblNumberPlays.Size = new System.Drawing.Size(95, 16);
            this.lblNumberPlays.TabIndex = 4;
            this.lblNumberPlays.Text = "Number";
            this.lblNumberPlays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextPlays
            // 
            this.lblTextPlays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextPlays.AutoSize = true;
            this.lblTextPlays.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextPlays.Location = new System.Drawing.Point(641, 20);
            this.lblTextPlays.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblTextPlays.Name = "lblTextPlays";
            this.lblTextPlays.Size = new System.Drawing.Size(57, 16);
            this.lblTextPlays.TabIndex = 4;
            this.lblTextPlays.Text = "streams";
            this.lblTextPlays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(724, 10);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(40, 40);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // ucSongSearchDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblTextPlays);
            this.Controls.Add(this.lblNumberPlays);
            this.Controls.Add(this.lblArtistSSD);
            this.Controls.Add(this.lblSongNameSSD);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "ucSongSearchDetail";
            this.Size = new System.Drawing.Size(767, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongNameSSD;
        private System.Windows.Forms.Label lblArtistSSD;
        private System.Windows.Forms.Label lblNumberPlays;
        private System.Windows.Forms.Label lblTextPlays;
        private System.Windows.Forms.Button btnDownload;
    }
}
