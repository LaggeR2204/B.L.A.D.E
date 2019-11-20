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
            Init();
        }
        private void Init()
        {
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
            this.WMP.MediaChange += SetSongInfor;
            this.WMP.DurationUnitChange += SliderRun;
            this.uc_Playlist.PlaylistUpdated += ReloadPlaylist;
            //slidervolume
            this.SliderVolume.ValueChanged += SliderVolumeChangeHandler;
            this.SliderVolume.LargeChange = 10;
            this.SliderVolume.SmallChange = 5;
            this.SliderVolume.Value = 100;
            //label curduration
            lbCurDuration.Text = "";
            //label duration limit
            lblDurationLimit.Text = "";
            //slider music
            sliderMusic.Scroll += ScrollSliderHandler;
            sliderMusic.Minimum = 0;
            sliderMusic.SmallChange = 1;
            sliderMusic.LargeChange = 1;
            sliderMusic.Value = 0;
            //notifyicon stop timer

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm frmLI = new LoginForm();
            frmLI.LoginSuccess += ShowUserName;
            frmLI.ShowDialog();
           
        }

        private void ShowUserName(object sender, EventArgs e)
        {
            string textUsername = sender.ToString();
            if (textUsername.Length > 10)
            {
                lblUserName.Text = textUsername.Remove(9, textUsername.Length - 9).Insert(9, "...");
            }
            else
            {
                lblUserName.Text = textUsername;
            }
        }
        #region Windows Controls
        private void btnCloseWindows_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textbox = sender as TextBox;
                uc_Search.pnlSearchTitle.Show();
                uc_Search.pnlSearchTitle.BringToFront();
                uc_Search.fpnlSearchSongView.Show();
                uc_Search.fpnlSearchSongView.BringToFront();
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
            SliderVolume.Enabled = true;
            SliderVolume.ElapsedColor = Color.FromArgb(0, 217, 87); 
            btnVolumeOff.Show();
        }

        private void btnVolumeOff_Click(object sender, EventArgs e)
        {
            WMP.settings.mute = true;
            SliderVolume.Enabled = false;
            SliderVolume.ElapsedColor = Color.FromArgb(224, 224, 224);
            btnVolume.Hide();
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
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
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
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
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
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
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
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
            //an pnlSelectedButton di
            pnlSelectedButton.Hide();
            //cho user control ohu hop xuat hien
            uc_Playlist.Hide();
            uc_Home.Hide();
            uc_Info.Hide();
            uc_Search.Show();
            uc_Search.BringToFront();
            uc_Search.fpnlSearchSongView.Controls.Clear();
            uc_Search.pnlSearchTitle.Hide();
            uc_Search.fpnlSearchSongView.Hide();
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
        private void ReloadPlaylist(object sender, EventArgs e)
        {
            Song song = sender as Song;
            IWMPMedia temp;
            temp = WMP.newMedia(song.SavedPath);
            WMP.currentPlaylist.appendItem(temp);
        }
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
            string textSongName = WMP.currentMedia.getItemInfo("Name");
            if (textSongName.Length > 18)
            {
                lblSongName.Text = textSongName.Remove(18, textSongName.Length - 18).Insert(18, "...");
            }
            else
            {
                lblSongName.Text = textSongName;
            }
            
            string textAuthor = WMP.currentMedia.getItemInfo("Author");
            if (textSongName.Length > 18)
            {
                lblArtistName.Text = textSongName.Remove(21, textSongName.Length - 21).Insert(21, "...");
            }
            else
            {
                lblArtistName.Text = textSongName;
            }

            lbCurDuration.Text = TimeSpan.Zero.ToString("mm':'ss");
            lblDurationLimit.Text = TimeSpan.FromSeconds(Convert.ToDouble(WMP.currentMedia.duration)).ToString("mm':'ss");
            sliderMusic.Maximum = Convert.ToInt32(WMP.currentMedia.duration);
        }
        #endregion

        #region StopTimer

        private void btnSetCustomTime_Click(object sender, EventArgs e)
        {
            try
            {
                int h, m, s, all;
                string timeRemain;
                //DIEUKIEN
                h = 0;
                m = 0;
                s = 0;

                if (txtHour.Text != null)
                    h = Convert.ToInt32(txtHour.Text);
                if (txtMinute.Text != null)
                    m = Convert.ToInt32(txtMinute.Text);
                if (txtSecond.Text != null)
                    s = Convert.ToInt32(txtSecond.Text);

                all = h * 60 * 60 + m * 60 + s;
                this.lblCountdown.Visible = true;
                s_Timer = new stopTimer(all);
                this.lblCountdown.Text = "CD: " + all;
                timeRemain = "Application will shut down in " + all.ToString() + " second(s)";
                s_Timer.Tick += TimeOut;
                s_Timer.Tick += OneMinRemaining;

                if (all == 0)
                {
                    this.lblCountdown.Text = "";
                    s_Timer.Stop();
                }

                notifyIcon.ShowBalloonTip(3000, "BLADE SleepTimer", timeRemain, ToolTipIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show("    YOU MUST FILL ALL FIELDS ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
        }

        private void btn10m_Click_1(object sender, EventArgs e)
        {
            int all = 600;
            this.lblCountdown.Visible = true;
            string timeRemain;
            this.lblCountdown.Text = "CD: " + all;
            s_Timer = new stopTimer(all);
            s_Timer.Tick += OneMinRemaining;
            s_Timer.Tick += TimeOut;
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
            timeRemain = "Application will shut down in 10 minutes";
            notifyIcon.ShowBalloonTip(3000, "BLADE SleepTimer", timeRemain, ToolTipIcon.Warning);

        }

        private void btn30m_Click_1(object sender, EventArgs e)
        {
            int all = 1800;
            this.lblCountdown.Visible = true;
            string timeRemain;
            this.lblCountdown.Text = "CD: " + all;
            s_Timer = new stopTimer(all);
            s_Timer.Tick += OneMinRemaining;
            s_Timer.Tick += TimeOut;
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }

            timeRemain = "Application will shut down in 30 minutes";
            notifyIcon.ShowBalloonTip(3000, "BLADE SleepTimer", timeRemain, ToolTipIcon.Warning);

        }

        private void btn1h_Click_1(object sender, EventArgs e)
        {
            int all = 3600;
            this.lblCountdown.Visible = true;
            string timeRemain;
            this.lblCountdown.Text = "CD: " + all;
            s_Timer = new stopTimer(all);
            s_Timer.Tick += OneMinRemaining;
            s_Timer.Tick += TimeOut;
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }

            timeRemain = "Application will shut down in an hour";
            notifyIcon.ShowBalloonTip(3000, "BLADE SleepTimer", timeRemain, ToolTipIcon.Warning);

        }
        private void TimeOut(object sender, EventArgs e)
        {
            if (s_Timer.Second <= 0)
                Application.Exit();
            this.lblCountdown.Text = "CD: " + s_Timer.Second;
        }

        private void OneMinRemaining(object sender, EventArgs e)
        {
            if (s_Timer.Second == 60)
                notifyIcon.ShowBalloonTip(3000, "BLADE SleepTimer Notification", "Application will shut down in less than a minute", ToolTipIcon.Warning);
        }

        #endregion

        #region Slider Volume
        private void SliderVolumeChangeHandler(object sender, EventArgs e)
        {
            if (SliderVolume.Value == 0)
            {
                btnVolumeOff.Hide();
                btnVolume.Show();
            }
            else
            {
                btnVolumeOff.Show();
                btnVolume.Hide();
            }
            WMP.settings.volume = SliderVolume.Value;
        }
        #endregion

        #region Notify Icon
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ShowInTaskbar)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                WindowState = FormWindowState.Minimized;
                minimizeToTrayToolStripMenuItem.Text = "Show BLADE-Player";
            }
            else
            {
                this.Show();
                this.ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
                minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s_Timer.Stop();
            this.lblCountdown.Visible=false;
        }
        #endregion

        #region Slider Music
        private void ScrollSliderHandler(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.currentPosition = sliderMusic.Value;
        }
        private void SliderRun(object sender, AxWMPLib._WMPOCXEvents_DurationUnitChangeEvent e)
        {
            sliderMusic.Value = Convert.ToInt32(WMP.currentMedia.duration);
        }
        #endregion
    }
}
