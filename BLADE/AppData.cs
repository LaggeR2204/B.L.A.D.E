using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLADE
{
    public class AppData
    {
        public AppData()
        {
        }
        private StringCollection _recentlty;
        private StringCollection _playlistCollection;
        private StringCollection _songCollection;
        private StringCollection _playback;
        private int _curPossition;
        private string _curSong;
        public StringCollection Recently { get => _recentlty; set => _recentlty = value; }
        public StringCollection PlaylistCollection { get => _playlistCollection; set => _playlistCollection = value; }
        public StringCollection SongCollection { get => _songCollection; set => _songCollection = value; }
        public StringCollection Playback { get => _playback; set => _playback = value; }
        public string CurrentSong { get => _curSong; set => _curSong = value; }
        public int CurrentPossition { get => _curPossition; set => _curPossition = value; }
        public void LoadData()
        {
            _curPossition = Properties.Settings.Default.CurrentPossition;
            _curSong = Properties.Settings.Default.CurrentMedia;
            if (Properties.Settings.Default.PlaylistCollection != null)
                _playlistCollection = Properties.Settings.Default.PlaylistCollection;
            else
                _playlistCollection = new StringCollection();
            if (Properties.Settings.Default.SongCollection != null)
                _songCollection = Properties.Settings.Default.SongCollection;
            else
                _songCollection = new StringCollection();
            if (Properties.Settings.Default.Playback != null)
                _playback = Properties.Settings.Default.Playback;
            else
                _playback = new StringCollection();
            if (Properties.Settings.Default.Recently != null)
                _recentlty = Properties.Settings.Default.Recently;
            else
                _recentlty = new StringCollection();
        }
        public void SaveData()
        {
            Properties.Settings.Default.Recently = _recentlty;
            Properties.Settings.Default.CurrentPossition = _curPossition;
            Properties.Settings.Default.CurrentMedia = _curSong;
            Properties.Settings.Default.PlaylistCollection = _playlistCollection;
            Properties.Settings.Default.SongCollection = _songCollection;
            Properties.Settings.Default.Playback = _playback;
            Properties.Settings.Default.Save();
        }
    }
}
