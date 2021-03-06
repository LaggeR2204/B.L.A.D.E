﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace BLADE
{
    public partial class SongItemInQueue : UserControl
    {
        private Song _song;
        public event EventHandler SelectedSong;
        public event EventHandler SongRemoved;
        public event EventHandler SongControled;
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
            btnSongPlay.Show();
            btnSongPause.Hide();
            _song.PlayStateChanged += _song_PlayStateChanged;
            btnSongPause.Click += BtnSongPause_Click;
            btnSongPlay.Click += BtnSongPlay_Click;

            lblArtistSVD.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);
            lblSongNameSVD.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);
            lblTimeSVD.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);

            lblArtistSVD.MouseMove += (s, e) => OnMouseMove(e);
            lblSongNameSVD.MouseMove += (s, e) => OnMouseMove(e);
            lblTimeSVD.MouseMove += (s, e) => OnMouseMove(e);
        }

        public void DisposeSongEvent()
        {
            _song.PlayStateChanged -= _song_PlayStateChanged;
        }
        public void ChangeIconState(bool bo)
        {
            if(bo)
            {
                btnSongPause.Hide();
                btnSongPlay.Show();
            }
            else
            {
                btnSongPause.Show();
                btnSongPlay.Hide();
            }
        }

        #region Mouse event
        protected override void OnMouseLeave(EventArgs e)
        {
            if (_song.IsPlaying == PlaybackState.Stopped)
                this.BackColor = Color.FromArgb(40, 40, 40);
            base.OnMouseLeave(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_song.IsPlaying == PlaybackState.Stopped)
                this.BackColor = Color.FromArgb(50, 50, 50);
            base.OnMouseMove(e);
        }
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            //this.BackColor = Color.FromArgb(0, 192, 192);
            if (SelectedSong != null)
                SelectedSong(_song, e);
            base.OnMouseDoubleClick(e);
        }
        #endregion

        #region Button click event
        private void BtnSongPlay_Click(object sender, EventArgs e)
        {
            if (_song.IsPlaying == PlaybackState.Stopped)
            {
                if (SelectedSong != null)
                    SelectedSong(_song, e);
            }
            else
            {
                if (SongControled != null)
                    SongControled("Play", e);
                ChangeIconState(false);
            }

        }

        private void BtnSongPause_Click(object sender, EventArgs e)
        {
            if (SongControled != null)
                SongControled("Pause", e);
            ChangeIconState(true);
        }
        private void _song_PlayStateChanged(object sender, EventArgs e)
        {
            if (_song.IsPlaying == PlaybackState.Playing )
            {
                ChangeIconState(false);
                this.BackColor = Color.FromArgb(0, 192, 192);
            }
            else if(_song.IsPlaying == PlaybackState.Paused)
            {
                ChangeIconState(true);
                this.BackColor = Color.FromArgb(0, 192, 192);
            }
            else
            {
                ChangeIconState(true);
                this.BackColor = Color.FromArgb(40, 40, 40);
            }

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
