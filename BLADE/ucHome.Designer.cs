namespace BLADE
{
    partial class ucHome
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
            this.btnNowPlaying = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.pnlSaperator = new System.Windows.Forms.Panel();
            this.pnlSelectedTab = new System.Windows.Forms.Panel();
            this.uc_Chart = new BLADE.ucChart();
            this.uc_NowPlaying = new BLADE.ucNowPlaying();
            this.pnlSaperator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.FlatAppearance.BorderSize = 0;
            this.btnNowPlaying.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNowPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNowPlaying.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowPlaying.Location = new System.Drawing.Point(3, 3);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.Size = new System.Drawing.Size(140, 50);
            this.btnNowPlaying.TabIndex = 0;
            this.btnNowPlaying.Text = "NOW PLAYING";
            this.btnNowPlaying.UseVisualStyleBackColor = true;
            this.btnNowPlaying.Click += new System.EventHandler(this.btnNowPlaying_Click);
            // 
            // btnChart
            // 
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(149, 3);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(140, 50);
            this.btnChart.TabIndex = 0;
            this.btnChart.Text = "CHART";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // pnlSaperator
            // 
            this.pnlSaperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSaperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSaperator.Controls.Add(this.pnlSelectedTab);
            this.pnlSaperator.Location = new System.Drawing.Point(0, 59);
            this.pnlSaperator.Name = "pnlSaperator";
            this.pnlSaperator.Size = new System.Drawing.Size(787, 6);
            this.pnlSaperator.TabIndex = 1;
            // 
            // pnlSelectedTab
            // 
            this.pnlSelectedTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlSelectedTab.Location = new System.Drawing.Point(3, 0);
            this.pnlSelectedTab.Name = "pnlSelectedTab";
            this.pnlSelectedTab.Size = new System.Drawing.Size(140, 6);
            this.pnlSelectedTab.TabIndex = 2;
            // 
            // uc_Chart
            // 
            this.uc_Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Chart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Chart.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Chart.Location = new System.Drawing.Point(0, 65);
            this.uc_Chart.Margin = new System.Windows.Forms.Padding(0);
            this.uc_Chart.Name = "uc_Chart";
            this.uc_Chart.Size = new System.Drawing.Size(787, 500);
            this.uc_Chart.TabIndex = 2;
            // 
            // uc_NowPlaying
            // 
            this.uc_NowPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_NowPlaying.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.uc_NowPlaying.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_NowPlaying.Location = new System.Drawing.Point(0, 65);
            this.uc_NowPlaying.Margin = new System.Windows.Forms.Padding(0);
            this.uc_NowPlaying.Name = "uc_NowPlaying";
            this.uc_NowPlaying.Size = new System.Drawing.Size(787, 500);
            this.uc_NowPlaying.TabIndex = 3;
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.pnlSaperator);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnNowPlaying);
            this.Controls.Add(this.uc_NowPlaying);
            this.Controls.Add(this.uc_Chart);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(787, 565);
            this.pnlSaperator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNowPlaying;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Panel pnlSaperator;
        private System.Windows.Forms.Panel pnlSelectedTab;
        private ucChart uc_Chart;
        private ucNowPlaying uc_NowPlaying;
    }
}
