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
    public partial class ucPlaylistView : UserControl
    {
        public ucPlaylistView()
        {
            InitializeComponent();
            btnPlaylistMenu.Hide();
        }

        private void ucPlaylistView_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            btnPlaylistMenu.Show();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Underline);
        }

        private void ucPlaylistView_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            btnPlaylistMenu.Hide();
            lblPlaylistName.Font = new Font(lblPlaylistName.Font.Name, lblPlaylistName.Font.SizeInPoints, FontStyle.Regular);
        }
    }
}
