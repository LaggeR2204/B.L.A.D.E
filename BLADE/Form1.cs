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
using NAudio.Wave;

namespace BLADE
{
    public partial class MainForm : Form
    {
        private MediaPlayer mediaPlayer;
        private SearchOnline search = new SearchOnline();
        private Timer timerSliderMusic;
        public MainForm()
        {
            InitializeComponent();
            Init();
            timerChangeColorBLADE.Enabled = false;
            timerTime.Enabled = false;
        }
        private void Init()
        {            mediaPlayer = new MediaPlayer();
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
            mediaPlayer.MediaChanged += MediaPlayer_MediaChanged;
            mediaPlayer.PlaybackStateChanged += MediaPlayer_PlaybackStateChanged;
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
            this.uc_Playlist.PlaylistUpdated += UpDatePlaylist;
            //slidervolume
            this.SliderVolume.ValueChanged += SliderVolumeChangeHandler;
            this.SliderVolume.LargeChange = 1;
            this.SliderVolume.SmallChange = 1;
            this.SliderVolume.Value = 5;
            //label curduration
            lbCurDuration.Text = "";
            //label duration limit
            lblDurationLimit.Text = "";
            //slider music
            sliderMusic.Scroll += SliderMusic_Scroll; ;
            sliderMusic.Minimum = 0;
            sliderMusic.SmallChange = 1;
            sliderMusic.LargeChange = 1;
            sliderMusic.Value = 0;
            //notifyicon stop timer            //timer slider
            timerSliderMusic = new Timer();
            timerSliderMusic.Interval = 10;
            timerSliderMusic.Tick += TimerSliderMusic_Tick;
        }

        private void MediaPlayer_PlaybackStateChanged(object sender, EventArgs e)
        {
            if (mediaPlayer.MediaState == PlaybackState.Paused)
            {
                btnPlay.Show();
                btnPause.Hide();
            }
            else 
            if (mediaPlayer.MediaState == PlaybackState.Playing)
            {
                btnPlay.Hide();
                btnPause.Show();
            }
            else
            {
                btnPlay.Show();
                btnPause.Hide();
            }
        }

        #region Account Actions
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm frmCP = new ChangePasswordForm();
            frmCP.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void changeYourPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePasswordToolStripMenuItem.PerformClick();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOutToolStripMenuItem1.PerformClick();
        }
        #endregion
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
            mediaPlayer.Play();
            btnPlay.Hide();
            btnPause.Show();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mediaPlayer.Pause();
            btnPlay.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mediaPlayer.Next();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            mediaPlayer.Previous();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            SliderVolume.Enabled = true;
            mediaPlayer.SetVolume((float)SliderVolume.Value / 10f);
            SliderVolume.ElapsedColor = Color.FromArgb(0, 217, 87);
            btnVolumeOff.Show();
        }

        private void btnVolumeOff_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetVolume(0f);
            SliderVolume.Enabled = false;
            SliderVolume.ElapsedColor = Color.FromArgb(224, 224, 224);
            btnVolume.Hide();
            btnVolumeOff.Hide();
            btnVolume.Show();
        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            mediaPlayer.SetPlaybackMode(false, true, false);
            btnShuffle.Show();
            btnRepeat.Hide();
            btnLoop.Hide();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            btnShuffle.Hide();
            btnRepeat.Show();
            btnLoop.Hide();
            mediaPlayer.SetPlaybackMode(false, false, true);
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            btnShuffle.Hide();
            btnRepeat.Hide();
            btnLoop.Show();
            mediaPlayer.SetPlaybackMode(true, false, false);
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
            lblTextBLADE.Show();
            DropdownTime.Start();
            if (isCollapsed)
            {
                btnInfo.Top = 440;
            }
            else
                btnInfo.Top = 292;
        }

        private void btnMusicCutter_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
            //set vi tri cho pnlSelectedButton
            pnlSelectedButton.Show();
            pnlSelectedButton.Height = btnMusicCutter.Height;
            pnlSelectedButton.Top = btnMusicCutter.Top;
            //cho user control ohu hop xuat hien
            uc_Info.Hide();
            uc_Playlist.Hide();
            uc_Search.Hide();
            uc_Home.Hide();
            uc_Queue.Hide();
            uc_MusicCutter.Show();
            uc_MusicCutter.BringToFront();
            lblTextBLADE.Show();
        }

        private bool isShowQueue = false;
        private void btnQueue_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
            //set vi tri cho pnlSelectedButton
            pnlSelectedButton.Hide();
            //cho user control ohu hop xuat hien
            if (!isShowQueue)
            {
                uc_Queue.Show();
                uc_Queue.BringToFront();
                isShowQueue = true;
            }
            else
            {
                uc_Queue.Hide();
                uc_Queue.SendToBack();
                isShowQueue = false;
            }
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
            uc_MusicCutter.Hide();
            uc_Queue.Hide();
            lblTextBLADE.Show();
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
            uc_Queue.Hide();
            uc_Search.Hide();
            uc_MusicCutter.Hide();
            lblTextBLADE.Show();
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
            uc_Queue.Hide();
            uc_MusicCutter.Hide();
            lblTextBLADE.Hide();
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
            uc_MusicCutter.Hide();
            lblTextBLADE.Show();
            uc_Search.Show();
            uc_Queue.Hide();
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


        #endregion
        #region Media Player
        private void UpDatePlaylist(object sender, EventArgs e)
        {
            Playlist playlist = sender as Playlist;            mediaPlayer.CurrentPlaylist.Clear();            for(int i = 0; i < playlist.Count; i++)
            {
                mediaPlayer.CurrentPlaylist.Add(playlist.List[i]);
            }
            mediaPlayer.PlayInIndex(0);
        }
       
        private void PlayMusic(object sender, EventArgs e)
        {
            Song song = sender as Song;
            mediaPlayer.AddSongToCurrentPlaylist(song);
            mediaPlayer.PlayInIndex(mediaPlayer.CurrentPlaylist.IndexOf(song));
            btnPause.Show();
            btnPlay.Hide();
        }
        private void MediaPlayer_MediaChanged(object sender, EventArgs e)
        {
            sliderMusic.Maximum = (int)mediaPlayer.GetDurationInSecond() * 1000;
            sliderMusic.Value = 0;
            WindowsMediaPlayer WMP = new WindowsMediaPlayer();
            IWMPMedia src = WMP.newMedia(mediaPlayer.CurrentMedia.SavedPath);
            string textSongName = src.getItemInfo("Name");
            if (textSongName.Length > 18)
            {
                lblSongName.Text = textSongName.Remove(18, textSongName.Length - 18).Insert(18, "...");
            }
            else
            {
                lblSongName.Text = textSongName;
            }
            string textAuthor = src.getItemInfo("Author");
            if (textAuthor.Length > 21)
            {
                lblArtistName.Text = textAuthor.Remove(21, textAuthor.Length - 21).Insert(21, "...");
            }
            else
            {
                lblArtistName.Text = textAuthor;
            }
            lblDurationLimit.Text = TimeSpan.FromSeconds(mediaPlayer.GetDurationInSecond()).ToString("mm':'ss");
            timerSliderMusic.Start();
        }
        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            mediaPlayer.Next();
            timerSliderMusic.Stop();
        }
        #endregion
        #region StopTimer
        private void btnSetCustomTime_Click(object sender, EventArgs e)
        {            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
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
                    Application.Exit();
                }                else
                {
                    btnTimer.Hide();
                    btnStopTimer.Show();
                    notifyIcon.ShowBalloonTip(3000, "BLADE SleepTimer", timeRemain, ToolTipIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("    YOU MUST FILL ALL FIELDS ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }            btnTimer.Hide();
            btnStopTimer.Show();
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
            btnTimer.Hide();
            btnStopTimer.Show();
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
            }            btnTimer.Hide();
            btnStopTimer.Show();
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
        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            s_Timer.Stop();
            this.lblCountdown.Visible = false;
            btnStopTimer.Hide();
            btnTimer.Show();
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
            mediaPlayer.SetVolume((float)SliderVolume.Value / 5f);
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
            this.lblCountdown.Visible = false;
        }


        #endregion
        #region Slider Music         private void SliderMusic_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            mediaPlayer.SetPossition(sliderMusic.Value / 1000 - (int)mediaPlayer.GetCurrentPossiton());
        }
        private void TimerSliderMusic_Tick(object sender, EventArgs e)
        {
            sliderMusic.Value += 1000;
            lblCurDuration.Text = TimeSpan.FromSeconds(mediaPlayer.GetCurrentPossiton()).ToString("mm':'ss");
        }

        #endregion

        private void txtSecond_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
