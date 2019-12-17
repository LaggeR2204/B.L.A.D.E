using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace BLADE
{
    public partial class ucSearch : UserControl
    {
        public event EventHandler SelectSong;

        public ucSearch()
        {
            InitializeComponent();
            //vsbSongSearchView.BindTo(fpnlSongSearchView);
            pnlSearchTitle.Hide();
            fpnlSongSearchView.Hide();
        }

        public void ShowListSearch(List<ucSongSearchDetail> src)
        {
            //int songCount = 0;
            foreach (var item in src)
            {
                fpnlSongSearchView.Controls.Add(item);
                item.Width = fpnlSongSearchView.Width;
                //songCount++;
            }
            vsbSongSearchView.Maximum = fpnlSongSearchView.VerticalScroll.Maximum;
            vsbSongSearchView.ThumbLength = 40;
        }

        private void fpnlSongSearchView_SizeChanged(object sender, EventArgs e)
        {
            foreach  (Control item in fpnlSongSearchView.Controls)
            {
                item.Width = fpnlSongSearchView.Width;
            }
        }

        private void vsbSongSearchView_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            fpnlSongSearchView.AutoScrollPosition = new Point(fpnlSongSearchView.AutoScrollPosition.X, e.Value);
        }
    }
}
