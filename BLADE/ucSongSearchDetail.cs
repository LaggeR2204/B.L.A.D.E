using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Threading;
using BLADE.xDialog;

namespace BLADE
{
    public partial class ucSongSearchDetail : UserControl
    {

        SearchOnline search = new SearchOnline();

        private Song _song;
        public Song Song
        {
            get { return _song; }
            set { _song = value; }
        }
        public ucSongSearchDetail()
        {
            InitializeComponent();
            _song = new Song();
            Init();
        }

        public ucSongSearchDetail(Song src)
        {
            InitializeComponent();
            _song = new Song(src);
            lblSongNameSSD.Text = _song.SongName;
            lblArtistSSD.Text = _song.Singer;
            lblNumberPlays.Text = _song.SongTime;
            Init();

        }
        private void Init()
        {
            lblArtistSSD.MouseMove += (s, e) => OnMouseMove(e);
            lblNumberPlays.MouseMove += (s, e) => OnMouseMove(e);
            lblSongNameSSD.MouseMove += (s, e) => OnMouseMove(e);
            lblTextPlays.MouseMove += (s, e) => OnMouseMove(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(50, 50, 50);
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 40, 40);
            base.OnMouseLeave(e);
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (IsConnectedToInternet())
            {
                search.Download(_song);
            }
            else
            {
                MsgBox.Show("Check your Internet connection and try again", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
        }

        public bool IsConnectedToInternet()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
