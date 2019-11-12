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
        private bool isFavorite;

        //private string songURL;
        //private string lyric;
        //private string downloadURL;
        //private string photoURL;
        //private double duration;
        //private double position;

        public string SongName { get => _songName; set => _songName = value; }
        public string SavedPath { get => _savedPath; set => _savedPath = value; }
        public string SongTime { get => _songTime; set => _songTime = value; }
        public string Singer { get => _singer; set => _singer = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public Image SongImage { get => _songImage; set => _songImage = value; }
        //public string SongURL { get => songURL; set => songURL = value; }
        //public string Lyric { get => lyric; set => lyric = value; }
        //public string DownloadURL { get => downloadURL; set => downloadURL = value; }
        //public string PhotoURL { get => photoURL; set => photoURL = value; }
        //public double Duration { get => duration; set => duration = value; }
        //public double Position { get => position; set => position = value; }
        public bool IsFavorite { get => isFavorite; set => isFavorite = value; }
        public Song()
        {
            isFavorite = false;
        }
        public Song(Song src)
        {
            this._songName = string.Copy(src._songName);
            this._savedPath = string.Copy(src._savedPath);
            this._songTime = string.Copy(src._songTime);
            this._singer = string.Copy(src._singer);
            this._genre = string.Copy(src._genre);
            isFavorite = false;
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
