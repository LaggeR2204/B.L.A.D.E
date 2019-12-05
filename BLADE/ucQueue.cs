using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLADE
{
    public partial class ucQueue : UserControl
    {
        private bool _isShow;
        public bool IsShow
        {
            get => _isShow;
            set
            {
                if (value != _isShow)
                {
                    _isShow = value;
                    if (ShowStateChanged != null)
                        ShowStateChanged(this, new EventArgs());
                }
            }
        }
        public event EventHandler ShowStateChanged;
        public event EventHandler SongSelected;
        public event EventHandler SongRemoved;
        public ucQueue()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            
        }
        public void SetArtCover(Bitmap src)
        {
            picbArtCover.Image = src;
        }

        public void SetInfor(string name, string singer)
        {
            lbSongName.Text = name;
            lbSongSinger.Text = singer;
        }

        private void SongSelected_Handler(object sender, EventArgs e)
        {
            if (SongSelected != null)
                SongSelected(sender, e);
        }
        private void SongRemoved_Handler(object sender, EventArgs e)
        {
            SongItemInQueue src = sender as SongItemInQueue;
            fpnlQueue.Controls.Remove(src);
            if (SongRemoved != null)
                SongRemoved(src.Song, e);
        }
        public void UpdateQueue(List<Song> src)
        {
            fpnlQueue.Controls.Clear();
            for(int i = 0; i<src.Count; i++)
            {
                ShowSongQueue(src[i]);
            }
        }
        public void ShowSongQueue(Song song)
        {
            SongItemInQueue songItem = new SongItemInQueue(song);
            songItem.SelectedSong += SongSelected_Handler;
            songItem.SongRemoved += SongRemoved_Handler;
            this.fpnlQueue.Controls.Add(songItem);
        }
    }
}
