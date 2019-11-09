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
            btnPlaylistMenu.Hide();
            _playlist = new Playlist();
            setLabelName();
        }
        public ucPlaylistView(Playlist src)
        {
            InitializeComponent();
            btnPlaylistMenu.Hide();
            _playlist = src;
            setLabelName();
        }
        #region EVENTHANDLER
        private void ucPlaylistView_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            btnPlaylistMenu.Show();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Underline);
        }

        private void ucPlaylistView_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            btnPlaylistMenu.Hide();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Regular);
        }
        private void BtnPlaylistMenu_MouseClick(object sender, MouseEventArgs e)
        {

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
