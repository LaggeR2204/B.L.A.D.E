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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPlaylistView));
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.btnPlaylistMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(3, 12);
            this.lblPlaylistName.MaximumSize = new System.Drawing.Size(135, 17);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(94, 17);
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
            // ucPlaylistView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Button btnPlaylistMenu;
    }
}
