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
            _default.PlaylistShowed += ucPlaylistView_showContent;
            _default.PlaylistDeleted += DeletePlaylist;
            _default.NewSongAdded += AddingSongHandler;
            _default.RemoveChooseItem();

            _favorites = new ucPlaylistView(new Playlist("Favorites"));
            _favorites.PlaylistShowed += ucPlaylistView_showContent;
            _favorites.PlaylistDeleted += DeletePlaylist;
            _favorites.NewSongAdded += AddingSongHandler;
            _favorites.RemoveChooseItem();
            fpnlPlaylistView.Controls.AddRange(new ucPlaylistView[] { _default, _favorites });

            choosingPlaylist = _default.Playlist;
            
        }
        public void ShowSongOnListArea(Song song)
        {
            ucSongViewDetail songView = new ucSongViewDetail(song);
            songView.SelectedSong += SelectedSongHandler;
            songView.DeletedSong += deleteSong;
            songView.FavoriteStateChanged += SongView_FavoriteStateChanged;
            this.fpnlSongView.Controls.Add(songView);
        }

        private void SongView_FavoriteStateChanged(object sender, EventArgs e)
        {
            ucSongViewDetail src = sender as ucSongViewDetail;
           // src.ChangedIconFavoriteState(src.Song.IsFavorite);
            if (src.Song.IsFavorite)
            {
                _favorites.AddSong(src.Song);
            }
            else
            {
                _favorites.RemoveSong(src.Song);
            }
           
        }

        private void clearSongViewList()
        {
            fpnlSongView.Controls.Clear();
        }
        private void ShowPlaylistInfo(Playlist src)
        {
            ucPlaylistView temp = new ucPlaylistView(src);
            temp.PlaylistShowed += ucPlaylistView_showContent;
            temp.PlaylistDeleted += DeletePlaylist;
            temp.NewSongAdded += AddingSongHandler;
            fpnlPlaylistView.Controls.Add(temp);
        }

        private void ucPlaylistView_showContent(object sender, EventArgs e)
        {
            Playlist pl = sender as Playlist;
            if (choosingPlaylist != pl)
            {
                clearSongViewList();
                foreach (Song song in pl.List)
                {
                    ShowSongOnListArea(song);
                }
                choosingPlaylist = pl;
            }
        }
        #region Event Handler
        private void AddingSongHandler(object sender, EventArgs e)
        {
            Playlist temp = sender as Playlist;
            if (temp == choosingPlaylist)
                ShowSongOnListArea(temp.List[temp.List.Count - 1]);
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
