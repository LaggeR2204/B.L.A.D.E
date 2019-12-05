using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio_Plotting;

namespace BLADE
{
    public partial class ucNowPlaying : UserControl
    {
        StereoAudioWavePainter stereo;
        DrawingWaveSound _drawtool;
        public ucNowPlaying()
        {
            InitializeComponent();
            stereo = new StereoAudioWavePainter();
            stereo.Location = new Point(100, 100);
            stereo.Size = new Size(800, 400);
            stereo.DrawMode = StereoAudioWavePainter.DisplayMode.Line;
            stereo.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            stereo.Gradient = true;
            stereo.GradientColor = Color.FromArgb(0, 190, 190);
            stereo.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            stereo.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            stereo.Plot = StereoAudioWavePainter.Plotmode.PlusMinus;
            stereo.ShowMidLine = false;
            stereo.Enabled = true;
            stereo.BackColor = Color.FromArgb(0, 190, 190);
            stereo.Show();
            _drawtool = new DrawingWaveSound();
            _drawtool.NotifySample += _drawtool_NotifySample;
        }

        private void _drawtool_NotifySample(object sender, NAudio.Wave.SampleEventArgs e)
        {
            lock (_drawtool.SampleObject)
            {
                if(_drawtool.Count >= _drawtool.Speed)
                {
                    stereo.AddLeftRight(_drawtool.LeftMax, _drawtool.RightMax);
                    _drawtool.LeftMax = 0;
                    _drawtool.RightMax = 0;
                    _drawtool.Count = 0;
                }
                else
                {
                    if (Math.Abs(e.Left) + Math.Abs(e.Right) > Math.Abs(_drawtool.LeftMax) + Math.Abs(_drawtool.RightMax))
                    {
                        _drawtool.LeftMax = e.Left;
                        _drawtool.RightMax = e.Right;
                    }
                    _drawtool.Count++;
                }
            }
        }
    }
}
