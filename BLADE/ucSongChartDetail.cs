using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BLADE.xDialog;

namespace BLADE
{
    public partial class ucSongChartDetail : UserControl
    {
        CrawlChart chart = new CrawlChart();

        private Song _song;
        public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }
        public ucSongChartDetail()
        {
            InitializeComponent();
            _song = new Song();
        }

        public ucSongChartDetail(Song src)
        {
            InitializeComponent();
            _song = new Song(src);
            lblSongNameSCD.Text = _song.SongName;
            lblArtistSCD.Text = _song.Singer;
            lblNumberPlays.Text = _song.SongTime;
            lblNumber.Text = _song.SongNumber.ToString();
            if (lblNumber.Text == "1")
            {
                lblNumber.ForeColor = Color.Orange;
            }
            else if (lblNumber.Text == "2")
            {
                lblNumber.ForeColor = Color.Green;
            }
            else if (lblNumber.Text == "3")
            {
                lblNumber.ForeColor = Color.Blue;
            }
        }

        private void ucSongChartDetail_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void ucSongChartDetail_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (IsConnectedToInternet())
            {
                ThreadStart st = new ThreadStart(DownloadSong);
                Thread thrd = new Thread(st);
                thrd.IsBackground = true;
                thrd.Start();
            }
            else
            {
                MsgBox.Show("Check your Internet connection and try again", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
        }

        public bool IsConnectedToInternet()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void DownloadSong()
        {
            chart.Download(_song.SongName, _song.SongURL);
            MsgBox.Show("The download is complete", "NOTIFICATION" , MsgBox.Buttons.OK,MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
        }
    }
}
