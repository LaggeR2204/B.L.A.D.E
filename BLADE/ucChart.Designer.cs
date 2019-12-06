namespace BLADE
{
    partial class ucChart
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
            this.fpnlVN = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlUSUK = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlKorea = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVN = new System.Windows.Forms.Button();
            this.btnUSUK = new System.Windows.Forms.Button();
            this.btnKorea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fpnlVN
            // 
            this.fpnlVN.Location = new System.Drawing.Point(0, 40);
            this.fpnlVN.Name = "fpnlVN";
            this.fpnlVN.Size = new System.Drawing.Size(787, 460);
            this.fpnlVN.TabIndex = 10;
            // 
            // fpnlUSUK
            // 
            this.fpnlUSUK.Location = new System.Drawing.Point(0, 40);
            this.fpnlUSUK.Name = "fpnlUSUK";
            this.fpnlUSUK.Size = new System.Drawing.Size(787, 460);
            this.fpnlUSUK.TabIndex = 11;
            // 
            // fpnlKorea
            // 
            this.fpnlKorea.Location = new System.Drawing.Point(0, 40);
            this.fpnlKorea.Name = "fpnlKorea";
            this.fpnlKorea.Size = new System.Drawing.Size(787, 460);
            this.fpnlKorea.TabIndex = 12;
            // 
            // btnVN
            // 
            this.btnVN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVN.FlatAppearance.BorderSize = 0;
            this.btnVN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVN.Location = new System.Drawing.Point(3, 3);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(100, 33);
            this.btnVN.TabIndex = 0;
            this.btnVN.Text = "Việt Nam";
            this.btnVN.UseVisualStyleBackColor = false;
            this.btnVN.Click += new System.EventHandler(this.btnVN_Click);
            // 
            // btnUSUK
            // 
            this.btnUSUK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUSUK.FlatAppearance.BorderSize = 0;
            this.btnUSUK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUSUK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUSUK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSUK.Location = new System.Drawing.Point(109, 3);
            this.btnUSUK.Name = "btnUSUK";
            this.btnUSUK.Size = new System.Drawing.Size(100, 33);
            this.btnUSUK.TabIndex = 0;
            this.btnUSUK.Text = "US-UK";
            this.btnUSUK.UseVisualStyleBackColor = false;
            this.btnUSUK.Click += new System.EventHandler(this.btnUSUK_Click);
            // 
            // btnKorea
            // 
            this.btnKorea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnKorea.FlatAppearance.BorderSize = 0;
            this.btnKorea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKorea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnKorea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorea.Location = new System.Drawing.Point(215, 3);
            this.btnKorea.Name = "btnKorea";
            this.btnKorea.Size = new System.Drawing.Size(100, 33);
            this.btnKorea.TabIndex = 0;
            this.btnKorea.Text = "Korea";
            this.btnKorea.UseVisualStyleBackColor = false;
            this.btnKorea.Click += new System.EventHandler(this.btnKorea_Click);
            // 
            // ucChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnKorea);
            this.Controls.Add(this.btnUSUK);
            this.Controls.Add(this.btnVN);
            this.Controls.Add(this.fpnlKorea);
            this.Controls.Add(this.fpnlUSUK);
            this.Controls.Add(this.fpnlVN);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucChart";
            this.Size = new System.Drawing.Size(787, 500);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel fpnlVN;
        public System.Windows.Forms.FlowLayoutPanel fpnlUSUK;
        public System.Windows.Forms.FlowLayoutPanel fpnlKorea;
        private System.Windows.Forms.Button btnVN;
        private System.Windows.Forms.Button btnUSUK;
        private System.Windows.Forms.Button btnKorea;
    }
}
