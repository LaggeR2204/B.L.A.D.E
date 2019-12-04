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
        public ucQueue()
        {
            InitializeComponent();
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

    }
}
