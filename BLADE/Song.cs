using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace BLADE
{
    public class Song
    {
        public event EventHandler FavoriteChanged;
        public event EventHandler PlayStateChanged;
        private bool _isPlaying;
        private string _songName;
        private string _savedPath;
        private string _songTime;
        private string _singer;
        private string _genre;
        private int _songNumber;
        private Bitmap _songImage;
        private bool _isFavorite;
        private string _songURL;
        private AudioFileReader _audioFile;
        //private string downloadURL;
        //private string _photoURL;
        //private double duration;
        //private double position;
        public AudioFileReader AudioFile { get => _audioFile; set => _audioFile = value; }
        public int SongNumber { get => _songNumber; set => _songNumber = value; }
        public string SongName { get => _songName; set => _songName = value; }
        public string SavedPath { get => _savedPath; set => _savedPath = value; }
        public string SongTime { get => _songTime; set => _songTime = value; }
        public string Singer { get => _singer; set => _singer = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public Bitmap SongImage { get => _songImage; set => _songImage = value; }
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
                    if (FavoriteChanged != null)
                    {
                        FavoriteChanged(this, new EventArgs());
                    }
                       
                }
            }
        }
        public bool IsPlaying
        {
            get => _isPlaying;
            set
            {
                if (_isPlaying != value)
                {
                    _isPlaying = value;
                    if (PlayStateChanged != null)
                        PlayStateChanged(this, new EventArgs());
                }
            }
        }
        public Song(FileInfo fileinfo)
        {
            this.GetSongInfo(fileinfo);
            this._isFavorite = false;
            this._isPlaying = false;
        }
        public Song()
        {
            _isPlaying = false;
            _isFavorite = false;
            this._songNumber = 0;
            this._songName = "";
            this._savedPath = "";
            this._songTime = "";
            this._singer = "";
            this._genre = "";
            this._songURL = "";

        }
        public Song(Song src)
        {
            this._isPlaying = src._isPlaying;
            this._songNumber = src._songNumber;
            this._songName = string.Copy(src._songName);
            this._savedPath = string.Copy(src._savedPath);
            this._songTime = string.Copy(src._songTime);
            this._singer = string.Copy(src._singer);
            this._genre = string.Copy(src._genre);
            this._audioFile = src.AudioFile;
            _isFavorite = src._isFavorite;

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

        public void GetImageFromFile(string path)
        {
            TagLib.File file = TagLib.File.Create(path);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                try
                {
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    _songImage = new Bitmap(mStream, false);
                    mStream.Dispose();
                }
                catch (Exception e)
                {
                    _songImage = new Bitmap(Properties.Resources.music);
                }
            }
            else
            {
                _songImage = new Bitmap(Properties.Resources.music);
            }
        }
        public void GetSongInfo(FileInfo file)
        {
            TagLib.File tabFile = TagLib.File.Create(file.FullName);
            _savedPath = file.FullName;
            if (tabFile.Tag.Title != null && tabFile.Tag.Title != "")
                _songName = tabFile.Tag.Title;
            else
                _songName = Path.GetFileNameWithoutExtension(file.Name);
            _songTime = tabFile.Properties.Duration.ToString("mm':'ss");
            if (tabFile.Tag.FirstPerformer != null && tabFile.Tag.FirstPerformer != "")
                _singer = tabFile.Tag.FirstPerformer;
            else
                _singer = " ";
            if (tabFile.Tag.FirstGenre != null && tabFile.Tag.FirstGenre != "")
                _genre = tabFile.Tag.FirstGenre;
            else
                _genre = " ";
            GetImageFromFile(file.FullName);
            AudioFile = new AudioFileReader(file.FullName);
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
