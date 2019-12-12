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
using BLADE.xDialog;

namespace BLADE
{
    public partial class ucMusicCutter : UserControl
    {
        int timeStart;
        int timeEnd;
        string opname;
        Timer timer;
        WaveOutEvent waveOut;
        Mp3FileReader mp3Reader;
        int currentSecond;
        TimeSpan maxTime;
        public event EventHandler OpenFileSucceed;
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
                opname = open.FileName;
                txtTimeStart.Text = "00:00:00";
                maxTime = mp3.TotalTime;
                txtTimeEnd.Text = mp3.TotalTime.ToString("hh':'mm':'ss");
                if (OpenFileSucceed != null)
                    OpenFileSucceed(this, new EventArgs());
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            timeStart = (int)TimeSpan.Parse(txtTimeStart.Text).TotalSeconds;
            timeEnd = (int)TimeSpan.Parse(txtTimeEnd.Text).TotalSeconds;
            if (timeStart >= timeEnd)
                MsgBox.Show("End must be greater than begin", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (opname == null)
                MsgBox.Show("You have to open a file", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            else
            {
                timer = new Timer();
                timer.Interval = 1000;
                timer.Start();
                timer.Tick += Timer_Tick;

                btnPlay.Visible = false;
                btnStop.Visible = true;
                timeStart = (int)TimeSpan.Parse(txtTimeStart.Text).TotalSeconds;
                timeEnd = (int)TimeSpan.Parse(txtTimeEnd.Text).TotalSeconds;
                waveOut = new WaveOutEvent();
                mp3Reader = new Mp3FileReader(opname);
                mp3Reader.CurrentTime = TimeSpan.FromSeconds(timeStart);

                currentSecond = (int)mp3Reader.CurrentTime.TotalSeconds;
                waveOut.Init(mp3Reader);
                waveOut.Play();
                if (OpenFileSucceed != null)
                    OpenFileSucceed(this, new EventArgs());
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentSecond = (int)mp3Reader.CurrentTime.TotalSeconds;
            if (currentSecond >= timeEnd)
            {
                btnPlay.Visible = true;
                btnStop.Visible = false;
                waveOut.Stop();
                mp3Reader.Position = 0;
                mp3Reader.Dispose();
                waveOut.Dispose();
                timer.Stop();
            }
        }
        public void Pause()
        {
            waveOut.Stop();
            waveOut.Dispose();
            btnStop.Visible = false;
            btnPlay.Visible = true;
            timer.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Pause();
            mp3Reader.Position = 0;
            mp3Reader.Dispose();
        }

        private void btnGetStartTime_Click(object sender, EventArgs e)
        {
            if (mp3Reader != null)
                txtTimeStart.Text = mp3Reader.CurrentTime.ToString("hh':'mm':'ss");
        }

        private void btnGetEndTime_Click(object sender, EventArgs e)
        {
            if (mp3Reader != null)
                txtTimeEnd.Text = mp3Reader.CurrentTime.ToString("hh':'mm':'ss");
        }

        private void txtTimeEnd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TimeSpan.Parse(txtTimeEnd.Text) > maxTime)
                {
                    txtTimeEnd.Text = maxTime.ToString("hh':'mm':'ss");
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show("You must enter time span", "Error", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                txtTimeEnd.Text = maxTime.ToString("hh':'mm':'ss");
            }

        }
    }

}

