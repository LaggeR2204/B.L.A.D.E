namespace TestNaudio
{
    partial class UcConverter
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
            this.btnToMp3 = new System.Windows.Forms.Button();
            this.btnToWav = new System.Windows.Forms.Button();
            this.btnToAac = new System.Windows.Forms.Button();
            this.btnToWma = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSource = new System.Windows.Forms.Label();
            this.txbSource = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToMp3
            // 
            this.btnToMp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnToMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToMp3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMp3.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToMp3.Location = new System.Drawing.Point(138, 259);
            this.btnToMp3.Name = "btnToMp3";
            this.btnToMp3.Size = new System.Drawing.Size(120, 38);
            this.btnToMp3.TabIndex = 0;
            this.btnToMp3.Text = "To MP3";
            this.btnToMp3.UseVisualStyleBackColor = true;
            this.btnToMp3.Click += new System.EventHandler(this.btnToMp3_Click);
            // 
            // btnToWav
            // 
            this.btnToWav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnToWav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToWav.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToWav.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToWav.Location = new System.Drawing.Point(274, 259);
            this.btnToWav.Name = "btnToWav";
            this.btnToWav.Size = new System.Drawing.Size(107, 38);
            this.btnToWav.TabIndex = 1;
            this.btnToWav.Text = "To WAV";
            this.btnToWav.UseVisualStyleBackColor = true;
            this.btnToWav.Click += new System.EventHandler(this.btnToWav_Click);
            // 
            // btnToAac
            // 
            this.btnToAac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnToAac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToAac.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToAac.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToAac.Location = new System.Drawing.Point(406, 259);
            this.btnToAac.Name = "btnToAac";
            this.btnToAac.Size = new System.Drawing.Size(101, 38);
            this.btnToAac.TabIndex = 2;
            this.btnToAac.Text = "To AAC";
            this.btnToAac.UseVisualStyleBackColor = true;
            this.btnToAac.Click += new System.EventHandler(this.btnToAac_Click);
            // 
            // btnToWma
            // 
            this.btnToWma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnToWma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToWma.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToWma.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnToWma.Location = new System.Drawing.Point(535, 259);
            this.btnToWma.Name = "btnToWma";
            this.btnToWma.Size = new System.Drawing.Size(107, 38);
            this.btnToWma.TabIndex = 3;
            this.btnToWma.Text = "ToWma";
            this.btnToWma.UseVisualStyleBackColor = true;
            this.btnToWma.Click += new System.EventHandler(this.btnToWma_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTitle.Location = new System.Drawing.Point(344, 59);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(99, 34);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "label1";
            // 
            // lbSource
            // 
            this.lbSource.AutoSize = true;
            this.lbSource.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSource.Location = new System.Drawing.Point(191, 137);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(60, 21);
            this.lbSource.TabIndex = 5;
            this.lbSource.Text = "label2";
            // 
            // txbSource
            // 
            this.txbSource.Location = new System.Drawing.Point(290, 137);
            this.txbSource.Name = "txbSource";
            this.txbSource.Size = new System.Drawing.Size(232, 22);
            this.txbSource.TabIndex = 6;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFile.Location = new System.Drawing.Point(567, 137);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 36);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConvert.Location = new System.Drawing.Point(321, 417);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(159, 91);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // UcConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txbSource);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnToWma);
            this.Controls.Add(this.btnToAac);
            this.Controls.Add(this.btnToWav);
            this.Controls.Add(this.btnToMp3);
            this.Name = "UcConverter";
            this.Size = new System.Drawing.Size(787, 565);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToMp3;
        private System.Windows.Forms.Button btnToWav;
        private System.Windows.Forms.Button btnToAac;
        private System.Windows.Forms.Button btnToWma;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSource;
        private System.Windows.Forms.TextBox txbSource;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnConvert;
    }
}
