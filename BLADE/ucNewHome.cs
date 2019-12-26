using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLADE.xDialog;

namespace BLADE
{
    public partial class ucNewHome : UserControl
    {
        public RecentlySongItem RecentlyItem1 { get => recItem1st; }
        public RecentlySongItem RecentlyItem2 { get => recItem2nd; }
        public RecentlySongItem RecentlyItem3 { get => recItem3rd; }
        public event EventHandler RecentlySelected;
        public ucNewHome()
        {
            InitializeComponent();
            recItem1st.PlaySong += RecItem_PlaySong;
            recItem2nd.PlaySong += RecItem_PlaySong;
            recItem3rd.PlaySong += RecItem_PlaySong;
        }

        private void RecItem_PlaySong(object sender, EventArgs e)
        {
            if (RecentlySelected != null)
                RecentlySelected(sender, e);
        }

        public void UpdateRecentlySong(Song src)
        {
            if (src != recItem1st.Song && src != recItem2nd.Song && src != recItem3rd.Song)
            {
                recItem3rd.Song = recItem2nd.Song;
                recItem2nd.Song = recItem1st.Song;
                recItem1st.Song = src;
            }
            else
            {
                if(src == RecentlyItem2.Song)
                {
                    recItem2nd.Song = recItem1st.Song;
                    recItem1st.Song = src;
                }
                else if (src == recItem3rd.Song)
                {
                    recItem3rd.Song = recItem1st.Song;
                    recItem1st.Song = src;
                }
            }
            recItem1st.ShowInfo();
            recItem2nd.ShowInfo();
            recItem3rd.ShowInfo();
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            if (uc_Chart.isInternet)
            {
                if (uc_Chart.isCompletedChart)
                {
                    this.Controls.Add(uc_Chart);
                    uc_Chart.Show();
                    uc_Chart.BringToFront();
                }
                else
                {
                    MsgBox.Show("Please wait while the application is updating the data", "SORRY", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                }
            }
            else
            {
                MsgBox.Show("Check your Internet connection and try again", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
        }
    }
}
