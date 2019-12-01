using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using WMPLib;
using System.IO;
namespace BLADE
{
    public partial class ucMusicCutter : UserControl
    {
        string opname;
        public ucMusicCutter()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Mp3 File|*.mp3;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                WindowsMediaPlayer WMP = new WindowsMediaPlayer();
                IWMPMedia src = WMP.newMedia(open.FileName);
                lblSongName.Text = src.getItemInfo("Name");

                Mp3FileReader mp3 = new Mp3FileReader(open.FileName);
                WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(mp3);
                waveViewer1.WaveStream = pcm;
                lblDurationLimit.Text = mp3.TotalTime.ToString("mm':'ss");
                opname = open.FileName;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int timeStart = (int)TimeSpan.Parse(txtTimeStart.Text).TotalSeconds;
            int timeEnd = (int)TimeSpan.Parse(txtTimeEnd.Text).TotalSeconds;
            if (timeStart >= timeEnd)
                MessageBox.Show("    END SHOULD BE GREATER THAN BEGIN ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string name = string.Copy("");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Mp3 File|*.mp3;";

                if (save.ShowDialog() != DialogResult.OK) return;
                var mp3Path = opname;
                var outputPath = Path.ChangeExtension(save.FileName, ".mp3");

                Mp3Cutter.TrimMp3(mp3Path, outputPath, timeStart, timeEnd);
            }
        }
    }

}

//private void btnPlay_Click(object sender, EventArgs e)
//{
//    WavFileUtils.TrimWavFile(inname, outname, e)
//}

