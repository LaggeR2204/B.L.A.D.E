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
        private Playlist choosingPlaylist;
        public Playlist ChoosingPlaylist { get => choosingPlaylist; set => choosingPlaylist = value; }
        public event EventHandler SelectSong;
        public event EventHandler PlaylistUpdated;

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
            _default.addingSong += AddingSongHandler;
            _default.RemoveChooseItem();

            _favorites = new ucPlaylistView(new Playlist("Favorites"));
            _favorites.showContent += ShowPlaylist;
            _favorites.delPlaylist += DeletePlaylist;
            _favorites.addingSong += AddingSongHandler;
            _favorites.RemoveChooseItem();
            fpnlPlaylistView.Controls.AddRange(new ucPlaylistView[] { _default, _favorites });

            choosingPlaylist = _default.Playlist;
            
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
            temp.addingSong += AddingSongHandler;
            fpnlPlaylistView.Controls.Add(temp);
        }
        #region Event Handler
        private void AddingSongHandler(object sender, EventArgs e)
        {
            Playlist temp = sender as Playlist;
            if (temp == choosingPlaylist)
                addSongToPlaylistView(temp.List[temp.List.Count - 1]);
        }
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
            if (SelectSong != null)
            {
                Song song = sender as Song;
                SelectSong(song, e);
            }
        }
        private void BtnAddPlaylist_MouseClick(object sender, MouseEventArgs e)
        {
            string name = string.Copy("");
            if(InputNamePlaylistBox.Show("Notification", "Enter playlist name: ", ref name) == DialogResult.OK)
            {
                Playlist pl1 = new Playlist(name);
                var controls = fpnlPlaylistView.Controls.OfType<Control>();
                foreach (var item in controls)
                {
                    ucPlaylistView temp = item as ucPlaylistView;
                    if (temp.Playlist.PlaylistName == name)
                    {
                        MessageBox.Show("Playlist is existed!!!");
                        return;
                    }
                }
                ShowPlaylistInfo(pl1);
            }
        }
        private void ShowPlaylist(object sender, EventArgs e)
        {
            Playlist pl = sender as Playlist;
            if (choosingPlaylist != pl)
            {
                clearSongViewList();
                List<Song> list = pl.List;
                foreach (Song song in list)
                {
                    addSongToPlaylistView(song);
                }
                choosingPlaylist = pl;
            }
        }
        private void deleteSong(object sender, EventArgs e)
        {
            ucSongViewDetail src = sender as ucSongViewDetail;
            fpnlSongView.Controls.Remove(src);
            src.Dispose();
        }
        #endregion

        private void btnAddPlaylistToPlayback_Click(object sender, EventArgs e)
        {
            if (this.PlaylistUpdated != null)
                PlaylistUpdated(this.ChoosingPlaylist, new EventArgs());

        }
    }
}
