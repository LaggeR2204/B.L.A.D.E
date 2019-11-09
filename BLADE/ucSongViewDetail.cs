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
    public partial class ucSongViewDetail : UserControl
    {
        public ucSongViewDetail()
        {
            InitializeComponent();
            btnSongMenu.Hide();
            btnSongPlay.Hide();
            btnSongPause.Hide();
        }

        private void ucSongViewDetail_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            btnSongMenu.Show();
            btnSongPlay.Show();
            btnSongPause.Show();
        }

        private void ucSongViewDetail_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            btnSongMenu.Hide();
            btnSongPlay.Hide();
            btnSongPause.Hide();
        }
    }
}
