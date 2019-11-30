namespace BLADE
{
    partial class ucQueue
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
            this.lblTextQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextQueue
            // 
            this.lblTextQueue.AutoSize = true;
            this.lblTextQueue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextQueue.Location = new System.Drawing.Point(17, 20);
            this.lblTextQueue.Name = "lblTextQueue";
            this.lblTextQueue.Size = new System.Drawing.Size(136, 25);
            this.lblTextQueue.TabIndex = 0;
            this.lblTextQueue.Text = "PLAY QUEUE";
            // 
            // ucQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lblTextQueue);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucQueue";
            this.Size = new System.Drawing.Size(787, 565);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextQueue;
    }
}
