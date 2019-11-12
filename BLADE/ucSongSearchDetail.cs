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
            search.Download(_song.SongName, _song.SongURL);            
        }
    }
}
