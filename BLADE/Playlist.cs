using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLADE
{
    public class Playlist
    {
        private string _plName;
        private List<Song> _listSong;
        private int _count;
        private DateTime _createdDay;
        public string PlaylistName
        {
            get => _plName;
            set
            {
                if (value != "" && value != _plName)
                {
                    _plName = value;
                    if (NameChanged != null)
                        NameChanged(this, new EventArgs());
                }
            }
        }
        public int Count { get => _count; set => _count = value; }
        public List<Song> List { get => _listSong; set => _listSong = value; }
        public DateTime CreatedDay { get => _createdDay; set => _createdDay = value; }

        public event EventHandler NameChanged;

        public Playlist()
        {
            Init();
        }
        public Playlist(string name)
        {
            Init();
            _plName = string.Copy(name);

        }

        private void Init()
        {
            _plName = string.Copy("");
            _count = 0;
            _createdDay = DateTime.Now;
            _listSong = new List<Song>();
        }

        public bool AddSong(Song src)
        {
            if (_listSong.Contains(src))
                return false;
            _listSong.Add(src);
            _count++;
            return true;
        }

        public bool Remove(Song src)
        {
            if (!_listSong.Contains(src))
                return false;
            _listSong.Remove(src);
            _count--;
            return true;
        }
        public bool IsContains(Song src)
        {
            return _listSong.Contains(src);
        }
    }
}
