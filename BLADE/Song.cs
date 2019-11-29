using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLADE
{
    public class Song
    {
        private string _songName;
        private string _savedPath;
        private string _songTime;
        private string _singer;
        private string _genre;
        private Image _songImage;

        private bool _isFavorite;

        //private string songURL;
        //private string lyric;

        private string _songURL;

        //private string downloadURL;
        //private string _photoURL;
        //private double duration;
        //private double position;

        public string SongName { get => _songName; set => _songName = value; }
        public string SavedPath { get => _savedPath; set => _savedPath = value; }
        public string SongTime { get => _songTime; set => _songTime = value; }
        public string Singer { get => _singer; set => _singer = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public Image SongImage { get => _songImage; set => _songImage = value; }
        public string SongURL { get => _songURL; set => _songURL = value; }
        //public string DownloadURL { get => downloadURL; set => downloadURL = value; }
        //public string PhotoURL { get => _photoURL; set => _photoURL = value; }
        //public double Duration { get => duration; set => duration = value; }
        //public double Position { get => position; set => position = value; }
        public bool IsFavorite
        {
            get => _isFavorite; 
            set
            {
                if (_isFavorite != value)
                {
                    _isFavorite = value;
                }
            }
        }
        public Song()
        {
            _isFavorite = false;
            this._songName = "";
            this._savedPath = "";
            this._songTime = "";
            this._singer = "";
            this._genre = "";
            this._songURL = "";

        }
        public Song(Song src)
        {
            this._songName = string.Copy(src._songName);
            this._savedPath = string.Copy(src._savedPath);
            this._songTime = string.Copy(src._songTime);
            this._singer = string.Copy(src._singer);
            this._genre = string.Copy(src._genre);

            _isFavorite = src.IsFavorite;

            this._songURL = string.Copy(src._songURL);

        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Song objAsSong = obj as Song;
            if (objAsSong == null)
                return false;
            else
                return Equals(objAsSong);
        }

        private bool Equals(Song src)
        {
            if (src == null)
                return false;
            return (src._savedPath == this._savedPath);
        }

        public static string convertToTime(string src)
        {
            double sec = Convert.ToDouble(src);
            string result;
            TimeSpan temp = TimeSpan.FromSeconds(sec);
            result = temp.ToString("mm':'ss");
            return result;
        }

        #region SORT SONG
        private class sortNameAscending : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Song s1 = (Song)x;
                Song s2 = (Song)y;
                return string.Compare(s1._songName, s2._songName);
            }
        }

        private class sortNameDescending : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Song s1 = (Song)x;
                Song s2 = (Song)y;
                return string.Compare(s2._songName, s1._songName);
            }
        }

        public static IComparer SortNameAscending()
        {
            return (IComparer)new sortNameAscending();
        }

        public static IComparer SortNameDescending()
        {
            return (IComparer)new sortNameDescending();
        }
        #endregion

    }
}
