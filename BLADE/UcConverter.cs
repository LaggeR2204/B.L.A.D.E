using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using System.Threading;
using BLADE.xDialog;

namespace BLADE
{
    public partial class UcConverter : UserControl
    {
        private enum ConvertType { ToMP3, ToWAV, ToAAC, ToWMA };
        private ConvertType type;
        private string desPath;
        private FileInfo fileSource;
        public UcConverter()
        {
            InitializeComponent();
            tltConverter.SetToolTip(btnOpenFile, "Open file");
            type = ConvertType.ToMP3;
            lbTitle.Text = "Convert To MP3";
            btnToMp3.BackColor = Color.FromArgb(0, 192, 192);
            panelInfo.Hide();
        }

        private void btnToMp3_Click(object sender, EventArgs e)
        {
            type = ConvertType.ToMP3;
            lbTitle.Text = "Convert To MP3";
            btnToMp3.BackColor = Color.FromArgb(0, 192, 192);
            btnToAac.BackColor = Color.FromArgb(40, 40, 40);
            btnToWav.BackColor = Color.FromArgb(40, 40, 40);
            btnToWma.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnToWav_Click(object sender, EventArgs e)
        {
            type = ConvertType.ToWAV;
            lbTitle.Text = "Convert To WAV";
            btnToWav.BackColor = Color.FromArgb(0, 192, 192);
            btnToAac.BackColor = Color.FromArgb(40, 40, 40);
            btnToMp3.BackColor = Color.FromArgb(40, 40, 40);
            btnToWma.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnToAac_Click(object sender, EventArgs e)
        {
            type = ConvertType.ToAAC;
            lbTitle.Text = "Convert To AAC";
            btnToAac.BackColor = Color.FromArgb(0, 192, 192);
            btnToMp3.BackColor = Color.FromArgb(40, 40, 40);
            btnToWav.BackColor = Color.FromArgb(40, 40, 40);
            btnToWma.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnToWma_Click(object sender, EventArgs e)
        {
            type = ConvertType.ToWMA;
            lbTitle.Text = "Convert To WMA";
            btnToWma.BackColor = Color.FromArgb(0, 192, 192);
            btnToAac.BackColor = Color.FromArgb(40, 40, 40);
            btnToWav.BackColor = Color.FromArgb(40, 40, 40);
            btnToMp3.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Audio File|*.mp3;*.aac;*.wav;*.wma|Video|*.mp4";
            op.RestoreDirectory = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                fileSource = new FileInfo(op.FileName);
                txbSource.Text = fileSource.FullName;
                Song sourceSong = new Song();
                sourceSong.GetSongInfo(fileSource);
                UpdateInfo(sourceSong);
            }
        }
        private void Convert()
        {
            var reader = new MediaFoundationReader(fileSource.FullName);
            switch (type)
            {
                case ConvertType.ToMP3:
                    MediaFoundationEncoder.EncodeToMp3(reader, desPath);
                    break;
                case ConvertType.ToAAC:
                    MediaFoundationEncoder.EncodeToAac(reader, desPath);
                    break;
                case ConvertType.ToWMA:
                    MediaFoundationEncoder.EncodeToWma(reader, desPath);
                    break;
                case ConvertType.ToWAV:
                    WaveFileWriter.CreateWaveFile(desPath, reader);
                    break;
                default:
                    break;
            }
            MsgBox.Show("Convert Completed!!!", "Notification", MsgBox.Buttons.OK);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (txbSource.Text == "")
            {
                MsgBox.Show("Source is empty!!!", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                return;
            }
            SaveFileDialog save = new SaveFileDialog();
            string ext;
            if (type == ConvertType.ToMP3)
                ext = ".mp3";
            else if (type == ConvertType.ToAAC)
                ext = ".aac";
            else if (type == ConvertType.ToWMA)
                ext = ".wma";
            else
                ext = ".wav";
            if(fileSource.Extension == ext)
            {
                MsgBox.Show("Result file's format must be different from source file!!!", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error);
                return;
            }
            save.Filter = string.Format("Audio|{0}", ext);
            save.FileName = Path.GetFileNameWithoutExtension(fileSource.Name);
            if (save.ShowDialog() == DialogResult.OK)
            {
                desPath = save.FileName;
                Action onCompleted = () =>
                {
                    txbSource.Clear();
                    panelInfo.Hide();
                };

                var thread = new Thread(
                  () =>
                  {
                      try
                      {
                          Convert();
                      }
                      finally
                      {
                          this.Invoke(onCompleted);
                      }
                  });
                thread.Start();
            }

        }

        private void UcConverter_SizeChanged(object sender, EventArgs e)
        {
            lblSongName.Size = new Size(this.Width - 514, lblSongName.Height);
            lblSinger.Size = new Size(this.Width - 514, lblSinger.Height);
            lblCategory.Size = new Size(this.Width - 547, lblCategory.Height);
            txbSource.Size = new Size(this.Width - 417, txbSource.Size.Height);
            pnlButton.Location = new Point((this.Width - pnlButton.Width) / 2, pnlButton.Location.Y);
        }

        private void UpdateInfo(Song song)
        {
            picSong.Image = song.SongImage;
            lblCategory.Text = song.Genre;
            lblSinger.Text = song.Singer;
            lblSongName.Text = song.SongName;
            panelInfo.Show();
        }
    }
}
