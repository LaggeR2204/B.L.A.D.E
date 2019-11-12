﻿using System;
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
        public event EventHandler DeletedSong;
        public event EventHandler FavoriteChanged;
        public ucSongViewDetail()
        {
            InitializeComponent();
            btnSongPlay.Hide();
            btnSongPause.Hide();
            _song = new Song();
            Init();

        }
        public ucSongViewDetail(Song src)
        {
            InitializeComponent();
            _song = new Song(src);
            lblSongNameSVD.Text = _song.SongName;
            lblTimeSVD.Text = _song.SongTime;
            lblCategorySVD.Text = _song.Genre;
            lblArtistSVD.Text = _song.Singer;
            Init();
        }

        private void Init()
        {
            lblSongNameSVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
            lblTimeSVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
            lblCategorySVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
            lblArtistSVD.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;
            this.MouseDoubleClick += ucSongViewDetail_MouseDoubleClick;

            btnSongLove.MouseHover += ucSongViewDetail_MouseHover;
            btnSongMenu.MouseHover += ucSongViewDetail_MouseHover;
            btnSongPause.MouseHover += ucSongViewDetail_MouseHover;
            btnSongPlay.MouseHover += ucSongViewDetail_MouseHover;
            lblCategorySVD.MouseHover += ucSongViewDetail_MouseHover;
            lblArtistSVD.MouseHover += ucSongViewDetail_MouseHover;
            lblSongNameSVD.MouseHover += ucSongViewDetail_MouseHover;
            lblTimeSVD.MouseHover += ucSongViewDetail_MouseHover;

            btnSongLove.MouseLeave += ucSongViewDetail_MouseLeave;
            btnSongMenu.MouseLeave += ucSongViewDetail_MouseLeave;
            btnSongPause.MouseLeave += ucSongViewDetail_MouseLeave;
            btnSongPlay.MouseLeave += ucSongViewDetail_MouseLeave;
            lblCategorySVD.MouseLeave += ucSongViewDetail_MouseLeave;
            lblArtistSVD.MouseLeave += ucSongViewDetail_MouseLeave;
            lblSongNameSVD.MouseLeave += ucSongViewDetail_MouseLeave;
            lblTimeSVD.MouseLeave += ucSongViewDetail_MouseLeave;
        }

        #region EVENTHANDLER
        private void ucSongViewDetail_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            btnSongPlay.Show();
            btnSongPause.Show();
        }

        private void ucSongViewDetail_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            btnSongPlay.Hide();
            btnSongPause.Hide();
        }

        private void ucSongViewDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Aquamarine;
            if (SelectedSong != null)
                SelectedSong(_song, e);
        }
        #endregion

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

        private void BtnSongLove_Click(object sender, EventArgs e)
        {
            Song.IsFavorite = !Song.IsFavorite;
            if (FavoriteChanged!= null)
            {
                FavoriteChanged(this.Song, new EventArgs());
            }
        }
    }
}
