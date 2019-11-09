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
        public ucPlaylistView()
        {
            InitializeComponent();
            //btnPlaylistMenu.Hide();
            _playlist = new Playlist();
            setLabelName();

            lblPlaylistName.MouseHover += ucPlaylistView_MouseHover;
            btnPlaylistMenu.MouseHover += ucPlaylistView_MouseHover;
            btnPlaylistMenu.MouseLeave += ucPlaylistView_MouseLeave;
            lblPlaylistName.MouseLeave += ucPlaylistView_MouseLeave;
        }
        public ucPlaylistView(Playlist src)
        {
            InitializeComponent();
            //btnPlaylistMenu.Hide();
            _playlist = src;
            setLabelName();

            lblPlaylistName.MouseHover += ucPlaylistView_MouseHover;
            btnPlaylistMenu.MouseHover += ucPlaylistView_MouseHover;
            btnPlaylistMenu.MouseLeave += ucPlaylistView_MouseLeave;
            lblPlaylistName.MouseLeave += ucPlaylistView_MouseLeave;

        }
        #region EVENTHANDLER
        private void ucPlaylistView_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            //btnPlaylistMenu.Show();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Underline);
        }

        private void ucPlaylistView_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            //btnPlaylistMenu.Hide();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Regular);
        }

        private void BtnPlaylistMenu_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.InitialDirectory = "c:\\";
            openfileDialog.Filter = "Audio (*.mp3)|*.mp3|All File|*.*";
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
                        _playlist.AddSong(song);                    }
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
        }


        #endregion

        void setLabelName()
        {
            this.lblPlaylistName.Text = _playlist.PlaylistName;
        }

        private Song GetSongInfo(FileInfo file)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia src = wmp.newMedia(file.FullName);
            Song song = new Song();
            song.SongName = src.getItemInfo("Name");
            song.SavedPath = file.FullName;
            song.SongTime = src.getItemInfo("Duration");
            song.Singer = src.getItemInfo("Artist");
            song.Genre = src.getItemInfo("WM/Genre");
            //song.SongImage = getImage(file.FullName);
            return song;
        }

        private void ucPlaylistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (showContent != null)
                showContent(_playlist.List, e);
        }


    }
}
