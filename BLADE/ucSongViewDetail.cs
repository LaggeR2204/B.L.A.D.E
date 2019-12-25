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
using System.Diagnostics;

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
        public event EventHandler PlaybackAdding;
        public event EventHandler DeletedSong;
        public event EventHandler FavoriteStateChanged;
        public ucSongViewDetail()
        {
            InitializeComponent();
            _song = new Song();
            Init();

        }
        public ucSongViewDetail(Song src)
        {
            InitializeComponent();
            _song = src;
            lblSongNameSVD.Text = _song.SongName;
            lblTimeSVD.Text = _song.SongTime;
            lblCategorySVD.Text = _song.Genre;
            lblArtistSVD.Text = _song.Singer;
            Init();
        }

        private void Init()
        {
            btnSongLove.Show();
            btnSongLoveOff.Hide();

            lblCategorySVD.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);
            lblArtistSVD.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);
            lblSongNameSVD.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);
            lblTimeSVD.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);

            lblCategorySVD.MouseMove += (s, e) => OnMouseMove(e);
            lblArtistSVD.MouseMove += (s, e) => OnMouseMove(e);
            lblSongNameSVD.MouseMove += (s, e) => OnMouseMove(e);
            lblTimeSVD.MouseMove += (s, e) => OnMouseMove(e);

            ChangedIconFavoriteState(_song.IsFavorite);
            _song.FavoriteChanged += _song_FavoriteChanged;
        }

        #region Mouse event handler
        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            base.OnMouseLeave(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
        }
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (SelectedSong != null)
                SelectedSong(_song, e);
            base.OnMouseDoubleClick(e);
        }
        #endregion

        #region button click handler

        private void addToPlaybackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PlaybackAdding != null)
                PlaybackAdding(_song, new EventArgs());
        }
        private void BtnSongMenu_Click(object sender, EventArgs e)
        {
            ctxtmsSong.Show(btnSongMenu, 0, btnSongMenu.Height);
        }

        private void DeleteSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DeletedSong != null)
            {
                DeletedSong(this, new EventArgs());
            }
        }
        private void btnSongLoveOff_Click(object sender, EventArgs e)
        {
            _song.IsFavorite = false;
        }
        private void BtnSongLove_Click(object sender, EventArgs e)
        {
            _song.IsFavorite = true;
        }
        #endregion
        private void _song_FavoriteChanged(object sender, EventArgs e)
        {
            if (FavoriteStateChanged != null)
                FavoriteStateChanged(this, new EventArgs());
            ChangedIconFavoriteState(_song.IsFavorite);
        }
        public void ChangedIconFavoriteState(bool love)
        {
            if (love)
            {
                btnSongLoveOff.Show();
                btnSongLove.Hide();
            }
            else
            {
                btnSongLove.Show();
                btnSongLoveOff.Hide();
            }

        }
        public void RemoveEventHandler()
        {
            _song.FavoriteChanged -= _song_FavoriteChanged;
        }

        private void openLocalFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(_song.SavedPath))
            {
                Process.Start(Directory.GetParent(_song.SavedPath).FullName);
            }
        }
    }
}
