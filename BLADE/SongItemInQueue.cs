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
    public partial class SongItemInQueue : UserControl
    {
        private Song _song;
        public event EventHandler SelectedSong;
        public event EventHandler SongRemoved;
        public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }
        public SongItemInQueue()
        {
            InitializeComponent();
            _song = new Song();
            Init();
        }
     
        public SongItemInQueue(Song src)
        {
            InitializeComponent();
            _song = src;
            lblSongNameSVD.Text = _song.SongName;
            lblTimeSVD.Text = _song.SongTime;
            lblArtistSVD.Text = _song.Singer;
            Init();
        }

        private void Init()
        {
            btnSongPlay.Hide();
            btnSongPause.Hide();
            _song.PlayStateChanged += _song_PlayStateChanged;
            this.MouseDoubleClick += SongItemInQueue_MouseDoubleClick;
        }
        public void DisposeSongEvent()
        {
            _song.PlayStateChanged -= _song_PlayStateChanged;
        }

        private void SongItemInQueue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 192, 192);
            if (SelectedSong != null)
                SelectedSong(_song, e);
        }

        #region Button click event
        private void _song_PlayStateChanged(object sender, EventArgs e)
        {
            if (_song.IsPlaying)
                this.BackColor = Color.FromArgb(0, 192, 192);
            else
                this.BackColor = Color.FromArgb(40, 40, 40);
        }
        private void btnSongMenu_Click(object sender, EventArgs e)
        {
            ctxtMenu.Show(btnSongMenu, 0, btnSongMenu.Height);
        }

        private void removeFromQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SongRemoved != null)
                SongRemoved(this, new EventArgs());
        }
        #endregion
    }
}
