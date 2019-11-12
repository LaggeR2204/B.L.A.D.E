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
        private ucPlaylistView _default;
        private ucPlaylistView _favorites;
        private Playlist currentPlaylist;
        private Playlist choosingPlaylist;

        public Playlist CurrentPlaylist { get => currentPlaylist; set => currentPlaylist = value; }
        public Playlist ChoosingPlaylist { get => choosingPlaylist; set => choosingPlaylist = value; }
        public event EventHandler SelectSong;

        public ucPlaylist()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            _default = new ucPlaylistView(new Playlist("Default"));
            _default.showContent += ShowPlaylist;
            _default.delPlaylist += DeletePlaylist;

            _favorites = new ucPlaylistView(new Playlist("Favorites"));
            _favorites.showContent += ShowPlaylist;
            _favorites.delPlaylist += DeletePlaylist;
            fpnlPlaylistView.Controls.AddRange(new ucPlaylistView[] { _default, _favorites });
        }
        public void addSongToPlaylistView(Song song)
        {
            ucSongViewDetail songView = new ucSongViewDetail(song);
            songView.SelectedSong += SelectedSongHandler;
            songView.DeletedSong += deleteSong;
            songView.FavoriteChanged += FavoriteChangedHandler;
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
        private void FavoriteChangedHandler(object sender, EventArgs e)
        {
            Song src = sender as Song;
            if (src.IsFavorite)
            {
                _favorites.addSongToPlaylistControl(src);
            }
            else
            {
                _favorites.removeSongFromPlaylistControl(src);
            }
        }
        private void DeletePlaylist(object sender, EventArgs e)
        {
            ucPlaylistView src = sender as ucPlaylistView;
            fpnlPlaylistView.Controls.Remove(src);
            if (src.Playlist == choosingPlaylist)
                fpnlSongView.Controls.Clear();
            src.Dispose();
        }
        private void SelectedSongHandler(object sender, EventArgs e)
        {
            if (currentPlaylist != choosingPlaylist && choosingPlaylist != null)
                currentPlaylist = choosingPlaylist;
            if (SelectSong != null)
            {
                Song song = sender as Song;
                SelectSong(currentPlaylist.List.IndexOf(song), e);
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
            Playlist pl = sender as Playlist;
            List<Song> list = pl.List;
            foreach (Song song in list)
            {
                addSongToPlaylistView(song);
            }
            choosingPlaylist = pl;
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
