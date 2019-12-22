namespace BLADE
{
    partial class ucSongChartDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSongChartDetail));
            this.lblSongNameSCD = new System.Windows.Forms.Label();
            this.lblArtistSCD = new System.Windows.Forms.Label();
            this.lblTextPlays = new System.Windows.Forms.Label();
            this.lblNumberPlays = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSongNameSCD
            // 
            this.lblSongNameSCD.AutoSize = true;
            this.lblSongNameSCD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongNameSCD.Location = new System.Drawing.Point(47, 10);
            this.lblSongNameSCD.MaximumSize = new System.Drawing.Size(400, 21);
            this.lblSongNameSCD.Name = "lblSongNameSCD";
            this.lblSongNameSCD.Size = new System.Drawing.Size(86, 16);
            this.lblSongNameSCD.TabIndex = 3;
            this.lblSongNameSCD.Text = "Some Name";
            this.lblSongNameSCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtistSCD
            // 
            this.lblArtistSCD.AutoSize = true;
            this.lblArtistSCD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistSCD.Location = new System.Drawing.Point(380, 10);
            this.lblArtistSCD.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblArtistSCD.Name = "lblArtistSCD";
            this.lblArtistSCD.Size = new System.Drawing.Size(39, 17);
            this.lblArtistSCD.TabIndex = 4;
            this.lblArtistSCD.Text = "Artist";
            this.lblArtistSCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextPlays
            // 
            this.lblTextPlays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextPlays.AutoSize = true;
            this.lblTextPlays.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextPlays.Location = new System.Drawing.Point(684, 10);
            this.lblTextPlays.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblTextPlays.Name = "lblTextPlays";
            this.lblTextPlays.Size = new System.Drawing.Size(57, 16);
            this.lblTextPlays.TabIndex = 5;
            this.lblTextPlays.Text = "streams";
            this.lblTextPlays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberPlays
            // 
            this.lblNumberPlays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberPlays.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPlays.Location = new System.Drawing.Point(594, 10);
            this.lblNumberPlays.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblNumberPlays.Name = "lblNumberPlays";
            this.lblNumberPlays.Size = new System.Drawing.Size(92, 16);
            this.lblNumberPlays.TabIndex = 6;
            this.lblNumberPlays.Text = "Number";
            this.lblNumberPlays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(744, 0);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(40, 40);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(3, 7);
            this.lblNumber.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(38, 22);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "10";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSongChartDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblTextPlays);
            this.Controls.Add(this.lblNumberPlays);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblArtistSCD);
            this.Controls.Add(this.lblSongNameSCD);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "ucSongChartDetail";
            this.Size = new System.Drawing.Size(787, 44);
            this.MouseLeave += new System.EventHandler(this.ucSongChartDetail_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ucSongChartDetail_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSongNameSCD;
        private System.Windows.Forms.Label lblArtistSCD;
        private System.Windows.Forms.Label lblTextPlays;
        private System.Windows.Forms.Label lblNumberPlays;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblNumber;
    }
}
