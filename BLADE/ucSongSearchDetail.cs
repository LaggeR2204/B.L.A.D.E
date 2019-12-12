using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Threading;
using BLADE.xDialog;

namespace BLADE
{
    public partial class ucSongSearchDetail : UserControl
    {

        SearchOnline search = new SearchOnline();

        private Song _song;
        public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }
        public event EventHandler SelectedSong;
        public ucSongSearchDetail()
        {
            InitializeComponent();
            _song = new Song();
        }

        public ucSongSearchDetail(Song src)
        {
            InitializeComponent();
            _song = new Song(src);
            lblSongNameSSD.Text = _song.SongName;
            lblArtistSSD.Text = _song.Singer;
            lblNumberPlays.Text = _song.SongTime;
        }

        private void ucSongSearchDetail_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void ucSongSearchDetail_MouseLeave(object sender, EventArgs e)
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

        void DownloadSong()
        {
            search.Download(_song);
            MsgBox.Show("The download is complete", "NOTIFICATION", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
        }
    }
}
