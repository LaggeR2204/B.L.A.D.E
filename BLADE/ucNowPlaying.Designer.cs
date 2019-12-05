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
            this.stereo = new NAudio_Plotting.StereoAudioWavePainter();
            this.SuspendLayout();
            // 
            // stereo
            // 
            this.stereo.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.stereo.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
            this.stereo.DrawMode = NAudio_Plotting.StereoAudioWavePainter.DisplayMode.Line;
            this.stereo.Gradient = false;
            this.stereo.GradientColor = System.Drawing.Color.Empty;
            this.stereo.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            resources.ApplyResources(this.stereo, "stereo");
            this.stereo.MiddleLineColor = System.Drawing.Color.Empty;
            this.stereo.Name = "stereo";
            this.stereo.Pinch = NAudio_Plotting.StereoAudioWavePainter.PinchMode.None;
            this.stereo.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Default;
            this.stereo.Plot = NAudio_Plotting.StereoAudioWavePainter.Plotmode.PlusMinus;
            this.stereo.QualityMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.stereo.ShowMidLine = false;
            // 
            // ucNowPlaying
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.stereo);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ucNowPlaying";
            this.ResumeLayout(false);

        }

        #endregion

        private NAudio_Plotting.StereoAudioWavePainter stereo;
    }
}
