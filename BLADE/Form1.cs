using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace BLADE
{
    public partial class MainForm : Form
    {
        SearchOnline search = new SearchOnline();
        public MainForm()
        {
            InitializeComponent();
            //set vi tri mac dinh cho pnlSelectedButton
            pnlSelectedButton.Height = btnHome.Height;
            pnlSelectedButton.Top = btnHome.Top;
            //cho trang mac dinh la Home
            uc_Info.Hide();
            uc_Playlist.Hide();
            uc_Search.Hide();
            uc_Home.Show();
            uc_Home.BringToFront();
            this.uc_Playlist.SelectSong += PlayMusic;
            this.WMP.MediaChange += SetSongInfor ;
        }
        #region Windows Controls
        private void btnCloseWindows_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseWindows_MouseHover(object sender, EventArgs e)
        {
            btnCloseWindows.BackColor = Color.Red;
        }
        private void btnCloseWindows_MouseLeave(object sender, EventArgs e)
        {
            btnCloseWindows.BackColor = Color.FromArgb(40, 40, 40);
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textbox = sender as TextBox;
                uc_Search.pnlSearchTitle.Show();
                uc_Search.fpnlSearchSongView.Show();
                uc_Search.lblTextSearch.Text = textbox.Text;
                uc_Search.ShowListSearch(search.Search(textbox.Text));
            }
        }


        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Music Controls
        private void btnPlay_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.play();
            btnPlay.Hide();
            btnPause.Show();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.pause();
            btnPause.Hide();
            btnPlay.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.next();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.previous();
        }

        private void btnRepeatOff_Click(object sender, EventArgs e)
        {
            WMP.settings.setMode("loop", false);
            btnRepeatOff.Hide();
            btnRepeat.Show();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            WMP.settings.setMode("loop", true);
            btnRepeat.Hide();
            btnRepeatOff.Show();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            btnShuffle.Hide();
            btnShuffleOff.Show();
        }

        private void btnShuffleOff_Click(object sender, EventArgs e)
        {
            btnShuffleOff.Hide();
            btnShuffle.Show();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            WMP.settings.mute = false;
            btnVolume.Hide();
            btnVolumeOff.Show();
        }

        private void btnVolumeOff_Click(object sender, EventArgs e)
        {
            WMP.settings.mute = true;
            btnVolumeOff.Hide();
            btnVolume.Show();
        }
        #endregion

        #region UC button events
        private bool isCollapsed;
        private void DropdownTime_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlTimerControl.Height += 10;
                if (pnlTimerControl.Size == pnlTimerControl.MaximumSize)
                {
                    DropdownTime.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                pnlTimerControl.Height -= 10;
                if (pnlTimerControl.Size == pnlTimerControl.MinimumSize)
                {
                    DropdownTime.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            //set vi tri cho pnlSelectedButton
            pnlSelectedButton.Show();
            pnlSelectedButton.Height = btnTimer.Height;
            pnlSelectedButton.Top = pnlTimerControl.Top;

            DropdownTime.Start();
            if (isCollapsed)
            {
                btnInfo.Top = 389;
            }
            else
                btnInfo.Top = 241;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //set vi tri cho pnlSelectedButton
            pnlSelectedButton.Show();
            pnlSelectedButton.Height = btnHome.Height;
            pnlSelectedButton.Top = btnHome.Top;
            //cho user control ohu hop xuat hien
            uc_Info.Hide();
            uc_Playlist.Hide();
            uc_Search.Hide();
            uc_Home.Show();
            uc_Home.BringToFront();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            //set vi tri cho pnlSelectedButton
            pnlSelectedButton.Show();
            pnlSelectedButton.Height = btnPlaylist.Height;
            pnlSelectedButton.Top = btnPlaylist.Top;
            //cho user control ohu hop xuat hien
            uc_Info.Hide();
            uc_Home.Hide();
            uc_Search.Hide();
            uc_Playlist.Show();
            uc_Playlist.BringToFront();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //set vi tri cho pnlSelectedButton
            pnlSelectedButton.Show();
            pnlSelectedButton.Height = btnInfo.Height;
            pnlSelectedButton.Top = btnInfo.Top;
            //cho user control ohu hop xuat hien
            uc_Playlist.Hide();
            uc_Home.Hide();
            uc_Search.Hide();
            uc_Info.Show();
            uc_Info.BringToFront();
        }

        private void txtSearch_Click(object sender, MouseEventArgs e)
        {
            //an pnlSelectedButton di
            pnlSelectedButton.Hide();
            //cho user control ohu hop xuat hien
            uc_Playlist.Hide();
            uc_Home.Hide();
            uc_Info.Hide();
            uc_Search.Show();
            uc_Search.BringToFront();
            uc_Search.fpnlSearchSongView.Controls.Clear();
        }

        private void timerChangeColorBLADE_Tick(object sender, EventArgs e)
        {
            if (lblTextBLADE.ForeColor == Color.White)
            {
                lblTextBLADE.ForeColor = Color.FromArgb(0, 217, 87);
            }
            else
                lblTextBLADE.ForeColor = Color.White;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        #endregion

        #region Buttons in menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCloseWindows.PerformClick();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPlay.PerformClick();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPause.PerformClick();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNext.PerformClick();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPrev.PerformClick();
        }

        private void shuffleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnShuffle.CanFocus == true)
            {
                btnShuffleOff.PerformClick();
            }
            else
                btnShuffle.PerformClick();
        }

        private void repeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btnRepeat.CanFocus == true)
            {
                btnRepeatOff.PerformClick();
            }
            else
                btnRepeat.PerformClick();
        }
        #endregion

        #region WindowMediaPlayer
        private void ReloadPlaylist()
        {
            WMP.currentPlaylist.clear();
            List<Song> listsong = uc_Playlist.CurrentPlaylist.List;
            foreach (Song song in listsong)
            {
                IWMPMedia src;
                src = WMP.newMedia(song.SavedPath);
                WMP.currentPlaylist.appendItem(src);
            }
        }
        private void PlayMusic(object sender, EventArgs e)
        {
            ReloadPlaylist();
            WMP.Ctlcontrols.playItem(WMP.currentPlaylist.Item[Convert.ToInt32(sender)]);
            btnPause.Show();
            btnPlay.Hide();
        }

        private void SetSongInfor(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            lblSongName.Text = WMP.currentMedia.getItemInfo("Name");
            lblArtistName.Text = WMP.currentMedia.getItemInfo("Author");
        }
        #endregion

        

    }
}
