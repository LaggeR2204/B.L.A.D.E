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
using WMPLib;

namespace BLADE
{
    public partial class ucPlaylistView : UserControl
    {
        private Playlist _playlist;
        public Playlist Playlist { get => _playlist; set => _playlist = value; }
        public event EventHandler showContent;
        public event EventHandler delPlaylist;
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
            this.MouseClick += ucPlaylistView_MouseClick;
            this.lblPlaylistName.Text = _playlist.PlaylistName;

            lblPlaylistName.MouseHover += ucPlaylistView_MouseHover;
            btnPlaylistMenu.MouseHover += ucPlaylistView_MouseHover;
            btnPlaylistMenu.MouseLeave += ucPlaylistView_MouseLeave;
            lblPlaylistName.MouseLeave += ucPlaylistView_MouseLeave;

            btnPlaylistMenu.MouseClick += BtnPlaylistMenu_MouseClick;

            //addSongToolStripMenuItem.MouseHover += ToolStripMenuItem_Hover;
            //addSongToolStripMenuItem.MouseLeave += ToolStripMenuItem_Leave;

            //renameToolStripMenuItem.MouseHover += ToolStripMenuItem_Hover;
            //renameToolStripMenuItem.MouseLeave += ToolStripMenuItem_Leave;

            //deleteToolStripMenuItem.MouseHover += ToolStripMenuItem_Hover;
            //deleteToolStripMenuItem.MouseLeave += ToolStripMenuItem_Leave;
            _playlist.NameChanged += setLabelName;
        }
        private void setLabelName(object sender, EventArgs e)
        {
            this.lblPlaylistName.Text = _playlist.PlaylistName;
        }

        public void addSongToPlaylistControl(Song src)
        {
            if (!_playlist.IsContains(src))
            {
                _playlist.AddSong(src);
            }
            else
            {
                MessageBox.Show("Bai hat da ton tai trong playlist!!!");
                return;
            }
        }
        public void removeSongFromPlaylistControl(Song src)
        {
            _playlist.Remove(src);
        }

        private Song GetSongInfo(FileInfo file)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia src = wmp.newMedia(file.FullName);
            Song song = new Song();
            song.SongName = src.getItemInfo("Name");
            song.SavedPath = file.FullName;
            song.SongTime = Song.convertToTime(src.getItemInfo("Duration"));
            song.Singer = src.getItemInfo("Artist");
            song.Genre = src.getItemInfo("WM/Genre");
            //song.SongImage = getImage(file.FullName);
            return song;
        }

        #region EVENTHANDLER

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

        private void ucPlaylistView_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            //btnPlaylistMenu.Show();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Regular);
        }

        private void ucPlaylistView_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            //btnPlaylistMenu.Hide();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Regular);
        }

        private void BtnPlaylistMenu_MouseClick(object sender, MouseEventArgs e)
        {
            ctxtmsPlaylist.Show(btnPlaylistMenu, 0, btnPlaylistMenu.Height);
        }

        private void ucPlaylistView_MouseClick(object sender, MouseEventArgs e)
        {
            if (showContent != null)
                showContent(_playlist, e);
        }

        private void AddSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.InitialDirectory = "c:\\";
            openfileDialog.Filter = "Audio (*.mp3)|*.mp3";
            openfileDialog.FilterIndex = 2;
            openfileDialog.RestoreDirectory = true;

            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openfileDialog.FileName);
                Song song;
                if (file.Extension == ".mp3")
                {
                    song = GetSongInfo(file);
                    if (!_playlist.IsContains(song))
                    {
                        _playlist.AddSong(song);
                    }
                    else
                    {
                        MessageBox.Show("Bai hat da ton tai trong playlist!!!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Day khong phai file audio");
                }

            }
            openfileDialog.Dispose();
            if (showContent != null)
                showContent(_playlist, e);
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = string.Copy("");
            InputNamePlaylistBox.Show("Notification", "Enter new name: ", ref name);
            _playlist.PlaylistName = name;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (delPlaylist != null)
                delPlaylist(this, new EventArgs());
        }
        #endregion


    }
}
