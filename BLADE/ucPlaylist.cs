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
        private ucPlaylistView _choosingPlaylist;
        public event EventHandler SelectSong;
        public event EventHandler ChangePlayback;
        public event EventHandler UpdatePlayback;

        public ucPlaylist()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            _default = new ucPlaylistView(new Playlist("Default"));
            _default.PlaylistShowed += ucPlaylistView_ShowContent;
            _default.PlaylistDeleted += ucPlaylistView_PlaylistDeleted;
            _default.NewSongAdded += ucPlaylistView_NewSongAdded;
            _default.AllMusicPlayed += ucPlaylistView_AllMusicPlayed;
            _default.ChooseStateChanged += ucPlaylistView_ChooseStateChanged;
            _default.RemoveChooseItem();

            _favorites = new ucPlaylistView(new Playlist("Favorites"));
            _favorites.PlaylistShowed += ucPlaylistView_ShowContent;
            _favorites.PlaylistDeleted += ucPlaylistView_PlaylistDeleted;
            _favorites.NewSongAdded += ucPlaylistView_NewSongAdded;
            _favorites.AllMusicPlayed += ucPlaylistView_AllMusicPlayed;
            _favorites.ChooseStateChanged += ucPlaylistView_ChooseStateChanged;
            _favorites.RemoveChooseItem(true);
            fpnlPlaylistView.Controls.AddRange(new ucPlaylistView[] { _default, _favorites });
            _default.IsChoose = true;
            _choosingPlaylist = _default;
        }

        #region Normal Function
        public void ShowSongOnListArea(Song song)
        {
            ucSongViewDetail songView = new ucSongViewDetail(song);
            songView.SelectedSong += SelectedSongHandler;
            songView.DeletedSong += SongView_SongDeleted;
            songView.FavoriteStateChanged += SongView_FavoriteStateChanged;
            songView.PlaybackAdding += SongView_PlaybackAdding;
            songView.ChangedIconFavoriteState(song.IsFavorite);
            this.fpnlSongView.Controls.Add(songView);
        }

        private void clearSongViewList()
        {
            foreach (ucSongViewDetail ctrl in fpnlSongView.Controls)
            {
                ctrl.RemoveEventHandler();
            }
            fpnlSongView.Controls.Clear();
        }
        private void ShowPlaylistInfo(Playlist src)
        {
            ucPlaylistView temp = new ucPlaylistView(src);
            temp.PlaylistShowed += ucPlaylistView_ShowContent;
            temp.PlaylistDeleted += ucPlaylistView_PlaylistDeleted;
            temp.NewSongAdded += ucPlaylistView_NewSongAdded;
            temp.AllMusicPlayed += ucPlaylistView_AllMusicPlayed;
            temp.ChooseStateChanged += ucPlaylistView_ChooseStateChanged;
            fpnlPlaylistView.Controls.Add(temp);
        }
        #endregion


        #region Event Handler
        private void SongView_PlaybackAdding(object sender, EventArgs e)
        {
            if (UpdatePlayback != null)
                UpdatePlayback(sender, e);
        }
        private void ucPlaylistView_ChooseStateChanged(object sender, EventArgs e)
        {
            ucPlaylistView src = sender as ucPlaylistView;
            if (src.IsChoose)
                src.BackColor = Color.FromArgb(0, 192, 192);
            else
                src.BackColor = Color.FromArgb(40, 40, 40);
        }
        private void ucPlaylistView_AllMusicPlayed(object sender, EventArgs e)
        {
            ucPlaylistView src = sender as ucPlaylistView;
            if (this.ChangePlayback != null)
                ChangePlayback(src.Playlist, new EventArgs());
        }
        private void SongView_FavoriteStateChanged(object sender, EventArgs e)
        {
            ucSongViewDetail src = sender as ucSongViewDetail;
            // src.ChangedIconFavoriteState(src.Song.IsFavorite);
            if (!src.Song.IsFavorite)
            {
                if (_favorites.IsChoose)
                {
                    fpnlSongView.Controls.Remove(src);
                    src.RemoveEventHandler();
                }
                _favorites.RemoveSong(src.Song);
            }
        }
        private void ucPlaylistView_ShowContent(object sender, EventArgs e)
        {
            ucPlaylistView pl = sender as ucPlaylistView;
            if (!pl.IsChoose)
            {
                clearSongViewList();
                foreach (Song song in pl.Playlist.List)
                {
                    ShowSongOnListArea(song);
                }
                pl.IsChoose = true;
                _choosingPlaylist.IsChoose = false;
                _choosingPlaylist = pl;
            }
        }
        private void ucPlaylistView_NewSongAdded(object sender, EventArgs e)
        {
            ucPlaylistView temp = sender as ucPlaylistView;
            Song song = temp.Playlist.List[temp.Playlist.List.Count - 1];
            song.FavoriteChanged += Song_FavoriteChangedHandler;
            if (temp.IsChoose )
                ShowSongOnListArea(song);
        }
        private void Song_FavoriteChangedHandler(object sender, EventArgs e)
        {
            Song src = sender as Song;
            // src.ChangedIconFavoriteState(src.Song.IsFavorite);
            if (src.IsFavorite)
            {
                if (_favorites.IsChoose)
                {
                    ShowSongOnListArea(src);
                }
                _favorites.AddSong(src);
            }
        }
        private void ucPlaylistView_PlaylistDeleted(object sender, EventArgs e)
        {
            ucPlaylistView src = sender as ucPlaylistView;
            fpnlPlaylistView.Controls.Remove(src);
            if (src.IsChoose)
            {
                fpnlSongView.Controls.Clear();
                _choosingPlaylist = null;
            }
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
       
        private void SongView_SongDeleted(object sender, EventArgs e)
        {
            ucSongViewDetail src = sender as ucSongViewDetail;
            if (_favorites.IsChoose)
                src.Song.IsFavorite = false;
            this._choosingPlaylist.RemoveSong(src.Song);
            fpnlSongView.Controls.Remove(src);
            src.RemoveEventHandler();
            src.Dispose();
        }
        #endregion
    }
}
