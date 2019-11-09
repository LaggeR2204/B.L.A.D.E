using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLADE
{
    public partial class ucSongViewDetail : UserControl
    {
        private Song _song;
        public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }
        public event EventHandler SelectedSong;
        public ucSongViewDetail()
        {
            InitializeComponent();
            btnSongMenu.Hide();
            btnSongPlay.Hide();
            btnSongPause.Hide();
            _song = new Song();
        }
        public ucSongViewDetail(Song src)
        {
            InitializeComponent();
            _song = new Song(src);
            lblSongNameSVD.Text = _song.SongName;
            lblTimeSVD.Text = _song.SongTime;
            lblCategorySVD.Text = _song.Genre;
            lblArtistSVD.Text = _song.Singer;

            lblSongNameSVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
            lblTimeSVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
            lblCategorySVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
            lblArtistSVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
        }
        #region EVENTHANDLER
        private void ucSongViewDetail_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            btnSongMenu.Show();
            btnSongPlay.Show();
            btnSongPause.Show();
        }

        private void ucSongViewDetail_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            btnSongMenu.Hide();
            btnSongPlay.Hide();
            btnSongPause.Hide();
        }

        private void ucSongViewDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Aquamarine;
            if (SelectedSong != null)
                SelectedSong(_song.SavedPath, e);
        }
        #endregion
    }
}
