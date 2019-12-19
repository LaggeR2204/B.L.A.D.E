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
using System.Collections.Specialized;

namespace BLADE
{
    public partial class ucPlaylist : UserControl
    {
        private List<Playlist> _playlistCollection;
        public List<Playlist> PlaylistCollection { get => _playlistCollection; set => _playlistCollection = value; }
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
            _playlistCollection = new List<Playlist>();
            _choosingPlaylist = null;
         
        }

        private List<string> GetListPath(string str)
        {
            List<string> result = new List<string>();
            int index = str.IndexOf("\n");
            while (index > 0)
            {
                string cutString = str.Substring(0, index);
                str = str.Remove(0, index + 1);
                cutString = cutString.Replace("\n", "");
                result.Add(cutString);
                index = str.IndexOf("\n");
            }
            return result;
        }
        public void LoadData(StringCollection recently ,StringCollection playbackCollection, StringCollection playlistCollection, StringCollection songCollection, string curSong, int pos,ref Song curMedia, List<Song> curPlaylist, Dictionary<int, Song> recentlyList)
        {
            Playlist pldefault = new Playlist(playlistCollection[0]);
            pldefault.SongAdded += Playlist_SongAdded;
            _default = ShowPlaylistInfo(pldefault);
            _default.RemoveChooseItem();
            _choosingPlaylist = _default;
            _choosingPlaylist.IsChoose = true;

            Playlist plFavo = new Playlist(playlistCollection[1]);
            plFavo.SongAdded += Playlist_SongAdded;
            _favorites = ShowPlaylistInfo(plFavo);
            _favorites.RemoveChooseItem(true);

            List<string> favorite;
            if (songCollection.Count >= 2)
                favorite = GetListPath(songCollection[1]);
            else
                favorite = new List<string>();
            for (int i = 0; i < playlistCollection.Count; i++)
            {
                string str = playlistCollection[i];
                Playlist playlist;
                if (i == 0)
                {
                    playlist = pldefault;
                }
                else
                if (i == 1)
                {
                    playlist = plFavo;
                }
                else
                {
                    playlist = new Playlist(str);
                    playlist.SongAdded += Playlist_SongAdded;
                    ShowPlaylistInfo(playlist);
                }

                List<string> listPath;
                if (i < songCollection.Count)
                {
                    listPath = GetListPath(songCollection[i]);
                    foreach (string path in listPath)
                    {
                        FileInfo fileinfo = new FileInfo(path);
                        Song song = new Song(fileinfo);
                        playlist.AddSong(song);
                        if (recently.Contains(path))
                            recentlyList.Add(recently.IndexOf(path),song);
                        if (favorite.Contains(path))
                            song.IsFavorite = true;
                        if (path == curSong)
                            curMedia = song;
                        if (playbackCollection.Contains(path))
                            curPlaylist.Add(song);
                    }
                }
                _playlistCollection.Add(playlist);
            }
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
        private ucPlaylistView ShowPlaylistInfo(Playlist src)
        {
            ucPlaylistView temp = new ucPlaylistView(src);
            temp.PlaylistShowed += ucPlaylistView_ShowContent;
            temp.PlaylistDeleted += ucPlaylistView_PlaylistDeleted;
            temp.AllMusicPlayed += ucPlaylistView_AllMusicPlayed;
            temp.ChooseStateChanged += ucPlaylistView_ChooseStateChanged;
            fpnlPlaylistView.Controls.Add(temp);
            return temp;
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
                if (_choosingPlaylist != null)
                    _choosingPlaylist.IsChoose = false;
                _choosingPlaylist = pl;
                _choosingPlaylist.IsChoose = true;
            }
        }
        private void Playlist_SongAdded(object sender, EventArgs e)
        {
            Playlist temp = sender as Playlist;
            Song song = temp.List[temp.List.Count - 1];
            song.FavoriteChanged += Song_FavoriteChangedHandler;
            if (_choosingPlaylist.Playlist == temp)
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
                _favorites.AddToFavorite(src);
            }
        }
        private void ucPlaylistView_PlaylistDeleted(object sender, EventArgs e)
        {
            ucPlaylistView src = sender as ucPlaylistView;
            _playlistCollection.Remove(src.Playlist);
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
            if (InputNamePlaylistBox.Show("Notification", "Enter playlist name: ", ref name) == DialogResult.OK)
            {
                Playlist pl1 = new Playlist(name);
                pl1.SongAdded += Playlist_SongAdded;
                foreach (ucPlaylistView item in fpnlPlaylistView.Controls)
                {
                    if (item.Playlist.PlaylistName == name)
                    {
                        MessageBox.Show("Playlist is existed!!!");
                        return;
                    }
                }
                ShowPlaylistInfo(pl1);
                _playlistCollection.Add(pl1);
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

        #region Srcoll bar event
        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            //fpnlSongView.VerticalScroll.Value = e.Value;
        }

        private void bunifuVScrollBar2_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
           // fpnlPlaylistView.VerticalScroll.Value = e.Value;
        }
        #endregion
    }
}
