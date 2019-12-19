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
    public partial class RecentlySongItem : UserControl
    {
        public event EventHandler PlaySong;
        private Song _song;
        public Song Song { get => _song; set => _song = value; }
        public RecentlySongItem()
        {
            InitializeComponent();
            _song = null;
            labelSongName.Text = "";
            labelSongName.MouseDoubleClick += RecentlySongItem_MouseDoubleClick;
            picbArtCover.MouseDoubleClick += RecentlySongItem_MouseDoubleClick;
            this.MouseDoubleClick += RecentlySongItem_MouseDoubleClick;
        }

        private void RecentlySongItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PlaySong != null)
                PlaySong(this, new EventArgs());
        }
        private void Clear()
        {
            picbArtCover.Image.Dispose();
            labelSongName.Text = "";
        }
        public void ShowInfo()
        {
            if (_song != null)
            {
                picbArtCover.Image = _song.SongImage;
                labelSongName.Text = _song.SongName;
            }  
        }

    }
}
