namespace BLADE
{
    partial class ucNowPlaying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNowPlaying));
            this.stereoAudioWavePainter1 = new NAudio_Plotting.StereoAudioWavePainter();
            this.SuspendLayout();
            // 
            // stereoAudioWavePainter1
            // 
            this.stereoAudioWavePainter1.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.stereoAudioWavePainter1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
            this.stereoAudioWavePainter1.DrawMode = NAudio_Plotting.StereoAudioWavePainter.DisplayMode.Line;
            this.stereoAudioWavePainter1.Gradient = false;
            this.stereoAudioWavePainter1.GradientColor = System.Drawing.Color.Empty;
            this.stereoAudioWavePainter1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            resources.ApplyResources(this.stereoAudioWavePainter1, "stereoAudioWavePainter1");
            this.stereoAudioWavePainter1.MiddleLineColor = System.Drawing.Color.Empty;
            this.stereoAudioWavePainter1.Name = "stereoAudioWavePainter1";
            this.stereoAudioWavePainter1.Pinch = NAudio_Plotting.StereoAudioWavePainter.PinchMode.None;
            this.stereoAudioWavePainter1.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Default;
            this.stereoAudioWavePainter1.Plot = NAudio_Plotting.StereoAudioWavePainter.Plotmode.PlusMinus;
            this.stereoAudioWavePainter1.QualityMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.stereoAudioWavePainter1.ShowMidLine = false;
            // 
            // ucNowPlaying
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.stereoAudioWavePainter1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ucNowPlaying";
            this.ResumeLayout(false);

        }

        #endregion

        private NAudio_Plotting.StereoAudioWavePainter stereoAudioWavePainter1;
    }
}
