﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLADE.xDialog;

namespace BLADE
{
    public partial class ucPlaylistView : UserControl
    {
        private bool _isChoose;
        public bool IsChoose
        {
            get => _isChoose;
            set
            {
                if (_isChoose != value)
                {
                    _isChoose = value;
                    if (ChooseStateChanged != null)
                        ChooseStateChanged(this, new EventArgs());
                }
            }
        }
        private Playlist _playlist;
        public Playlist Playlist { get => _playlist; set => _playlist = value; }
        public event EventHandler ChooseStateChanged;
        public event EventHandler PlaylistShowed;
        public event EventHandler PlaylistDeleted;
        public event EventHandler AllMusicPlayed;

        #region Constructor
        public ucPlaylistView()
        {
            InitializeComponent();
            Init();
            //btnPlaylistMenu.Hide();
            _playlist = new Playlist();
        }
        public ucPlaylistView(Playlist src)
        {
            InitializeComponent();
            //btnPlaylistMenu.Hide();
            _playlist = src;
            Init();
        }
        void Init()
        {
            this.lblPlaylistName.Click += ucPlaylistView_MouseClick;
            this.MouseClick += ucPlaylistView_MouseClick;
            this.lblPlaylistName.Text = _playlist.PlaylistName;

            btnPlaylistMenu.MouseClick += BtnPlaylistMenu_MouseClick;

            _playlist.NameChanged += setLabelName;
            _isChoose = false;

            lblPlaylistName.MouseMove += (s, e) => OnMouseMove(e);
        }


        #endregion

        #region Normal Function
        public void AddSong(Song src)
        {
            bool result = _playlist.AddSong(src);
            if (!result)
                MsgBox.Show("This song is existed in current playlist!!!", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
        }
        public void AddToFavorite(Song src)
        {
            _playlist.AddToFavorite(src);
        }
        public void RemoveSong(Song src)
        {
            if (src != null)
            {
                _playlist.Remove(src);
            }

        }
        public void RemoveChooseItem(bool mode = false)
        {
            ctxtmsPlaylist.Items.RemoveAt(3);
            ctxtmsPlaylist.Items.RemoveAt(2);
            if (mode)
                ctxtmsPlaylist.Items.RemoveAt(0);
        }
        #endregion

        #region Mouse event
        //private void ToolStripMenuItem_Hover (object sender, EventArgs e)
        //{
        //    ToolStripMenuItem item = sender as ToolStripMenuItem;
        //    item.BackColor = Color.FromArgb(65, 65, 65);
        //}

        //private void ToolStripMenuItem_Leave(object sender, EventArgs e)
        //{
        //    ToolStripMenuItem item = sender as ToolStripMenuItem;
        //    item.BackColor = Color.FromArgb(35, 35, 35);
        //}
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.IsChoose == false)
                this.BackColor = Color.FromArgb(50, 50, 50);
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.IsChoose == false)
                this.BackColor = Color.FromArgb(40, 40, 40);
            base.OnMouseLeave(e);
        }
        private void BtnPlaylistMenu_MouseClick(object sender, MouseEventArgs e)
        {
            ctxtmsPlaylist.Show(btnPlaylistMenu, 0, btnPlaylistMenu.Height);
        }

        private void ucPlaylistView_MouseClick(object sender, EventArgs e)
        {
            if (PlaylistShowed != null)
                PlaylistShowed(this, e);
        }
        #endregion

        #region Button event
        private void setLabelName(object sender, EventArgs e)
        {
            this.lblPlaylistName.Text = _playlist.PlaylistName;
        }
        private void playAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_playlist.Count == 0)
            {
                MsgBox.Show("This playlist is empty!!!", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                return;
            }
            if (this.AllMusicPlayed != null)
                AllMusicPlayed(this, new EventArgs());
        }

        private void AddSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.InitialDirectory = "c:\\";
            openfileDialog.Filter = "Video|*.mp4|Audio|*.mp3;*.wav;*.aac;*.wma";
            openfileDialog.FilterIndex = 2;
            openfileDialog.RestoreDirectory = true;
            openfileDialog.Multiselect = true;

            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openfileDialog.FileNames)
                {
                    FileInfo fileinfo = new FileInfo(file);
                    if (fileinfo.Extension == ".mp3" || fileinfo.Extension == ".wav" || fileinfo.Extension == ".aac" || fileinfo.Extension == ".wma")
                    {
                        Song song = new Song(fileinfo);
                        if (!_playlist.AddSong(song))
                        {
                            MsgBox.Show("This song is existed in current playlist", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                            return;
                        }
                    }
                    else
                    {
                        MsgBox.Show("This file is not audio file!!!", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                    }
                }
            }
            openfileDialog.Dispose();

        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = string.Copy("");
            if (InputNamePlaylistBox.Show("Notification", "Enter new name: ", ref name) == DialogResult.OK)
            {
                _playlist.PlaylistName = name;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PlaylistDeleted != null)
                PlaylistDeleted(this, new EventArgs());
        }
        #endregion
    }
}
