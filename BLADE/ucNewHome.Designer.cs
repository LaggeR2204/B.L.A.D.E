namespace BLADE
{
    partial class ucNewHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNewHome));
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.lblTextRecently = new System.Windows.Forms.Label();
            this.uc_Chart = new BLADE.ucChart();
            this.btnChart = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackGround
            // 
            this.picBackGround.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBackGround.Image = ((System.Drawing.Image)(resources.GetObject("picBackGround.Image")));
            this.picBackGround.Location = new System.Drawing.Point(0, 0);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(787, 239);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 0;
            this.picBackGround.TabStop = false;
            // 
            // lblTextRecently
            // 
            this.lblTextRecently.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextRecently.Location = new System.Drawing.Point(3, 242);
            this.lblTextRecently.Name = "lblTextRecently";
            this.lblTextRecently.Size = new System.Drawing.Size(203, 41);
            this.lblTextRecently.TabIndex = 1;
            this.lblTextRecently.Text = "RECENTLY PLAYED";
            this.lblTextRecently.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_Chart
            // 
            this.uc_Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Chart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Chart.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Chart.Location = new System.Drawing.Point(0, 0);
            this.uc_Chart.Margin = new System.Windows.Forms.Padding(0);
            this.uc_Chart.Name = "uc_Chart";
            this.uc_Chart.Size = new System.Drawing.Size(787, 565);
            this.uc_Chart.TabIndex = 1;
            // 
            // btnChart
            // 
            this.btnChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            this.btnChart.Location = new System.Drawing.Point(685, 245);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(99, 41);
            this.btnChart.TabIndex = 2;
            this.btnChart.Text = "Chart";
            this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.picBackGround);
            this.pnlHome.Controls.Add(this.btnChart);
            this.pnlHome.Controls.Add(this.lblTextRecently);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(787, 565);
            this.pnlHome.TabIndex = 3;
            // 
            // ucNewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.pnlHome);
            //if (uc_Chart.isCompletedChart)
            //{
            //    this.Controls.Add(this.uc_Chart);
            //}
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucNewHome";
            this.Size = new System.Drawing.Size(787, 565);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.Label lblTextRecently;
        private ucChart uc_Chart;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Panel pnlHome;
    }
}
