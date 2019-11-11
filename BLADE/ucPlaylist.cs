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

namespace BLADE
{
    public partial class ucPlaylist : UserControl
    {
        public event EventHandler SelectSong;

        public ucPlaylist()
        {
            InitializeComponent();
            ShowPlaylistInfo(_default);
            Init();
        }
        private void Init()
        {

        }
        public void addSongToPlaylistView(Song song)
        {
            ucSongViewDetail songView = new ucSongViewDetail(song);
            songView.SelectedSong += click;
            songView.DeletedSong += deleteSong;
            this.fpnlSongView.Controls.Add(songView);
        }
        private void clearSongViewList()
        {
            fpnlSongView.Controls.Clear();
        }
        private void ShowPlaylistInfo(Playlist src)
        {
            ucPlaylistView temp = new ucPlaylistView(src);
            temp.showContent += ShowPlaylist;
            temp.delPlaylist += DeletePlaylist;
            fpnlPlaylistView.Controls.Add(temp);
        }
        #region Event Handler
        private void DeletePlaylist(object sender, EventArgs e)
        {
            ucPlaylistView src = sender as ucPlaylistView;
            fpnlPlaylistView.Controls.Remove(src);
            src.Dispose();
        }
        private void click(object sender, EventArgs e)
        {
            if (SelectSong != null)
            {
                SelectSong(sender.ToString(), e);
            }
        }
        private void BtnAddPlaylist_MouseClick(object sender, MouseEventArgs e)
        {
            string name = string.Copy("");
            InputNamePlaylistBox.Show("Notification", "Enter playlist name: ", ref name);
            Playlist pl1 = new Playlist(name);
            ShowPlaylistInfo(pl1);
        }
        private void ShowPlaylist(object sender, EventArgs e)
        {
            clearSongViewList();
            List<Song> list = sender as List<Song>;
            foreach (Song song in list)
            {
                addSongToPlaylistView(song);
            }
        }
        private void deleteSong(object sender, EventArgs e)
        {
            ucSongViewDetail src = sender as ucSongViewDetail;
            fpnlSongView.Controls.Remove(src);
            src.Dispose();
        }
        #endregion
    }
}
