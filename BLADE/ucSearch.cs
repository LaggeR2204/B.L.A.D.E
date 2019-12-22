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
        private bool _isSearch;
        public bool IsSearch
        {
            get => _isSearch;
            set => _isSearch = value;
        }
        public ucSearch()
        {
            InitializeComponent();
            _isSearch = false;
        }
        public void ShowListSearch(List<ucSongSearchDetail> src)
        {
            fpnlSongSearchView.Controls.Clear();
            foreach (var item in src)
            {
                fpnlSongSearchView.Controls.Add(item);
                item.Width = panelContainFpnl.Width;
            }
        }

        private void panelContainFpnl_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control item in fpnlSongSearchView.Controls)
            {
                item.Width = panelContainFpnl.Width;
            }
        }
    }
}
