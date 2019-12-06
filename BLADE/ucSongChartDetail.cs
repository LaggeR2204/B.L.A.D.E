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
        public event EventHandler SelectedSong;
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
            ThreadStart st = new ThreadStart(DownloadSong);
            Thread thrd = new Thread(st);
            thrd.IsBackground = true;
            thrd.Start();
        }

        private void DownloadSong()
        {
            chart.Download(_song.SongName, _song.SongURL);
            MessageBox.Show("Down xong nhạc trong BXH");
        }
    }
}
