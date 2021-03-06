﻿namespace BLADE
{
    partial class ucSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSearchTitle = new System.Windows.Forms.Panel();
            this.lblTextSearch = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.fpnlSongSearchView = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContainFpnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSearchTitle.SuspendLayout();
            this.panelContainFpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find your favorite songs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(320, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlSearchTitle
            // 
            this.pnlSearchTitle.Controls.Add(this.lblTextSearch);
            this.pnlSearchTitle.Controls.Add(this.lblResult);
            this.pnlSearchTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchTitle.Name = "pnlSearchTitle";
            this.pnlSearchTitle.Size = new System.Drawing.Size(787, 40);
            this.pnlSearchTitle.TabIndex = 2;
            // 
            // lblTextSearch
            // 
            this.lblTextSearch.AutoSize = true;
            this.lblTextSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSearch.ForeColor = System.Drawing.Color.White;
            this.lblTextSearch.Location = new System.Drawing.Point(157, 12);
            this.lblTextSearch.MaximumSize = new System.Drawing.Size(135, 17);
            this.lblTextSearch.Name = "lblTextSearch";
            this.lblTextSearch.Size = new System.Drawing.Size(103, 17);
            this.lblTextSearch.TabIndex = 4;
            this.lblTextSearch.Text = "Text Search";
            this.lblTextSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(20, 12);
            this.lblResult.MaximumSize = new System.Drawing.Size(171, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(166, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Showing Songs For ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fpnlSongSearchView
            // 
            this.fpnlSongSearchView.AutoScroll = true;
            this.fpnlSongSearchView.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpnlSongSearchView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlSongSearchView.Location = new System.Drawing.Point(0, 0);
            this.fpnlSongSearchView.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlSongSearchView.Name = "fpnlSongSearchView";
            this.fpnlSongSearchView.Size = new System.Drawing.Size(1016, 525);
            this.fpnlSongSearchView.TabIndex = 3;
            this.fpnlSongSearchView.WrapContents = false;
            // 
            // panelContainFpnl
            // 
            this.panelContainFpnl.Controls.Add(this.fpnlSongSearchView);
            this.panelContainFpnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainFpnl.Location = new System.Drawing.Point(0, 40);
            this.panelContainFpnl.Name = "panelContainFpnl";
            this.panelContainFpnl.Size = new System.Drawing.Size(787, 525);
            this.panelContainFpnl.TabIndex = 5;
            this.panelContainFpnl.SizeChanged += new System.EventHandler(this.panelContainFpnl_SizeChanged);
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.panelContainFpnl);
            this.Controls.Add(this.pnlSearchTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(787, 565);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSearchTitle.ResumeLayout(false);
            this.pnlSearchTitle.PerformLayout();
            this.panelContainFpnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlSearchTitle;
        private System.Windows.Forms.Label lblResult;
        public System.Windows.Forms.Label lblTextSearch;
        public System.Windows.Forms.FlowLayoutPanel fpnlSongSearchView;
        public System.Windows.Forms.Panel panelContainFpnl;
    }
}
