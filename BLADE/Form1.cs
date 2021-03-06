﻿using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLADE.xDialog;
using System.Collections.Generic;
using System.Threading;
using System.Collections.Specialized;

namespace BLADE
{
    public partial class MainForm : Form
    {
        AppData _appData;
        GifImage gifImage = null;
        private MediaPlayer mediaPlayer;
        private SearchOnline search = new SearchOnline();
        private System.Windows.Forms.Timer timerSliderMusic;
        private bool isDrag = false;
        private System.Windows.Forms.Timer gifTimer;
        public enum ShowingUC { UcHome, UcPlaylist, UcQueue, UcInfo, UcMusicCutter, UcSearch, UcConverter }
        private event EventHandler ShowingStateChanged;
        private ShowingUC _showingUC;
        private ShowingUC _lastShowingUc;
        public ShowingUC ShowingUc
        {
            set
            {
                if (_showingUC != value)
                {
                    _showingUC = value;
                    if (ShowingStateChanged != null)
                        ShowingStateChanged(this, new EventArgs());
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            tltMainform.SetToolTip(btnPlay, "Play");
            tltMainform.SetToolTip(btnPause, "Pause");
            tltMainform.SetToolTip(btnNext, "Next");
            tltMainform.SetToolTip(btnPrev, "Previous");
            tltMainform.SetToolTip(btnQueue, "Playback");
            tltMainform.SetToolTip(btnVolume, "Unmute");
            tltMainform.SetToolTip(btnVolumeOff, "Mute");
            tltMainform.SetToolTip(btnShuffle, "Shuffle");
            tltMainform.SetToolTip(btnRepeat, "Loop");
            tltMainform.SetToolTip(btnLoop, "Repeat");
            tltMainform.SetToolTip(lblUserName, "Profile");
            Init();
        }
        private void Init()
        {
            //
            picboxGif.Hide();
            // UcHome
            uc_NewHome.RecentlySelected += Uc_NewHome_RecentlySelected;
            //
            //gifTimer
            gifTimer = new System.Windows.Forms.Timer();
            gifTimer.Enabled = true;
            gifTimer.Interval = 2000;
            gifTimer.Tick += GifTimer_Tick;
            gifTimer.Start();
            //
            //App data
            _appData = new AppData();
            //
            //
            this.FormClosing += MainForm_FormClosing;
            //
            this.ShowingStateChanged += MainForm_ShowingStateChanged;            _showingUC = ShowingUC.UcHome;
            //
            mediaPlayer = new MediaPlayer();
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
            mediaPlayer.MediaChanged += MediaPlayer_MediaChanged;
            mediaPlayer.PlaybackStateChanged += MediaPlayer_PlaybackStateChanged;
            mediaPlayer.CurrentMediaNullable += MediaPlayer_CurrentMediaNullable;
            //set vi tri mac dinh cho pnlSelectedButton
            pnlSelectedButton.Height = btnHome.Height;
            pnlSelectedButton.Top = btnHome.Top;
            //cho trang mac dinh la Home
            uc_Info.Hide();
            uc_Playlist.Hide();
            uc_Search.Hide();
            uc_NewHome.Show();
            uc_NewHome.BringToFront();
            uc_Playlist.SelectSong += PlayMusic;
            uc_Playlist.ChangePlayback += UcPlaylist_ChangePlayback;            uc_Playlist.UpdatePlayback += UcPlaylist_UpdatePlayback;            uc_Playlist.SongRemoved += Uc_Playlist_SongRemoved;
            //slidervolume
            SliderVolume.Scroll += SliderVolumeChangeHandler;
            SliderVolume.Maximum = 100;
            SliderVolume.Minimum = 0;
            SliderVolume.LargeChange = 10;
            SliderVolume.SmallChange = 5;
            SliderVolume.Value = 100;            SliderVolume.AllowIncrementalClickMoves = false;            SliderVolume.AllowScrollOptionsMenu = false;            //uc Queue
            uc_Queue.SongSelected += Uc_Queue_SongSelected; ;
            uc_Queue.SongRemoved += Uc_Queue_SongRemoved;
            uc_Queue.SongControled += Uc_Queue_SongControled;

            //label curduration
            lbCurDuration.Text = "";            lblCurDuration.Visible = true;
            //label duration limit
            lblDurationLimit.Text = "";
            //slider music
            sliderMusic.Scroll += SliderMusic_Scroll; ;
            sliderMusic.Minimum = 0;
            sliderMusic.SmallChange = 1;
            sliderMusic.LargeChange = 1;
            sliderMusic.Value = 0;
            sliderMusic.AllowIncrementalClickMoves = false;
            sliderMusic.AllowScrollOptionsMenu = false;

            //notifyicon stop timer            //timer slider
            timerSliderMusic = new System.Windows.Forms.Timer();
            timerSliderMusic.Interval = 200;
            timerSliderMusic.Tick += TimerSliderMusic_Tick;
            //
            uc_MusicCutter.OpenFileSucceed += btnPause_Click;
            //
            gifImage = new GifImage(Path.Combine(Environment.CurrentDirectory.Replace("bin\\Debug", ""), "Resources\\YdBO.gif"));
            gifImage.ReverseAtEnd = false;
            //
        }

        private void GifTimer_Tick(object sender, EventArgs e)
        {
            picboxGif.Image = gifImage.GetNextFrame();
        }
        private void Uc_NewHome_RecentlySelected(object sender, EventArgs e)
        {
            RecentlySongItem src = sender as RecentlySongItem;
            if (mediaPlayer.AddSongToCurrentPlaylist(src.Song))
                uc_Queue.UpdateQueue(src.Song);
            mediaPlayer.PlayInIndex(mediaPlayer.CurrentPlaylist.IndexOf(src.Song));
            if (uc_MusicCutter.opname != null)
                uc_MusicCutter.Pause();
        }
        private void Uc_Playlist_SongRemoved(object sender, EventArgs e)
        {
            Song src = sender as Song;
            if (src == mediaPlayer.CurrentMedia)
            {
                if (mediaPlayer.CurrentPlaylist.Count >= 2)
                {
                    if (mediaPlayer.IsRepeat == false)
                        mediaPlayer.Next();
                    else
                    {
                        mediaPlayer.SetPlaybackMode(true, false, false);
                        mediaPlayer.Next();
                        mediaPlayer.SetPlaybackMode(false, false, true);
                    }
                }

                else
                {
                    mediaPlayer.Pause();
                    mediaPlayer.DisposeAudio();
                    mediaPlayer.CurrentMedia.IsPlaying = PlaybackState.Stopped;
                    mediaPlayer.CurrentMedia = null;
                    ResetUIInfor();
                    uc_Queue.NowPlayingSong = null;
                }
            }
            mediaPlayer.CurrentPlaylist.Remove(src);
            uc_Queue.RemoveSongItem(src);
        }

        #region MainForm
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_appData.Recently != null)
                _appData.Recently.Clear();
            if (_appData.SongCollection != null)
                _appData.SongCollection.Clear();
            if (_appData.Playback != null)
                _appData.Playback.Clear();
            if (_appData.PlaylistCollection != null)
                _appData.PlaylistCollection.Clear();
            foreach (Song song in mediaPlayer.CurrentPlaylist)
            {
                _appData.Playback.Add(song.SavedPath);
            }
            if (uc_NewHome.RecentlyItem1.Song != null)
            {
                _appData.Recently.Add(uc_NewHome.RecentlyItem1.Song.SavedPath);
                if (uc_NewHome.RecentlyItem2.Song != null)
                {
                    _appData.Recently.Add(uc_NewHome.RecentlyItem2.Song.SavedPath);
                    if (uc_NewHome.RecentlyItem3.Song != null)
                        _appData.Recently.Add(uc_NewHome.RecentlyItem3.Song.SavedPath);
                }
            }
            foreach (Playlist pl in uc_Playlist.PlaylistCollection)
            {
                _appData.PlaylistCollection.Add(pl.PlaylistName);
                string songPath = string.Format("");
                foreach (Song song in pl.List)
                {
                    songPath += song.SavedPath + "\n";
                }
                _appData.SongCollection.Add(songPath);
            }
            if (mediaPlayer.CurrentMedia != null)
            {
                _appData.CurrentSong = mediaPlayer.CurrentMedia.SavedPath;
                _appData.CurrentPossition = (int)mediaPlayer.GetCurrentPossiton();
            }
            _appData.SaveData();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, Song> recentlyList = new Dictionary<int, Song>();
            Song curMedia = null;
            _appData.LoadData();
            uc_Playlist.LoadData(_appData.Recently, _appData.Playback, _appData.PlaylistCollection, _appData.SongCollection, _appData.CurrentSong, _appData.CurrentPossition, ref curMedia, mediaPlayer.CurrentPlaylist, recentlyList);
            uc_Queue.UpdateQueue(mediaPlayer.CurrentPlaylist);
            //for (int i = 0; i < recentlyList.Count; i++)
            //{
            //    if (recentlyList.ContainsKey(i))
            //        if (recentlyList[i] != null)
            //            uc_NewHome.UpdateRecentlySong(recentlyList[i]);
            //}
            for (int i = recentlyList.Count - 1; i >= 0; i--)
            {
                if (recentlyList.ContainsKey(i))
                    if (recentlyList[i] != null)
                        uc_NewHome.UpdateRecentlySong(recentlyList[i]);
            }
            if (mediaPlayer.CurrentPlaylist.Count > 0)
            {
                if (curMedia != null)
                {
                    mediaPlayer.PlayInIndex(mediaPlayer.CurrentPlaylist.IndexOf(curMedia));
                    mediaPlayer.SetPossition(_appData.CurrentPossition);
                    sliderMusic.Value = _appData.CurrentPossition;
                    lblCurDuration.Text = TimeSpan.FromSeconds(sliderMusic.Value).ToString("mm':'ss");
                }
                mediaPlayer.Pause();
                mediaPlayer.Pause();
            }
            if (mediaPlayer.CurrentMedia == null)
                sliderMusic.Enabled = false;

        }
        #endregion

        #region ucQueue
        private void Uc_Queue_SongControled(object sender, EventArgs e)
        {
            string src = sender as string;
            if (src == "Play")
            {
                mediaPlayer.Play();
            }
            else
            {
                mediaPlayer.Pause();
            }
        }
        private void Uc_Queue_SongSelected(object sender, EventArgs e)
        {
            Song song = sender as Song;
            mediaPlayer.PlayInIndex(mediaPlayer.CurrentPlaylist.IndexOf(song));
            btnPause.Show();
            btnPlay.Hide();
        }
        private void Uc_Queue_SongRemoved(object sender, EventArgs e)
        {
            Song src = sender as Song;
            if (src == mediaPlayer.CurrentMedia)
            {
                if (mediaPlayer.CurrentPlaylist.Count >= 2)
                {
                    if (mediaPlayer.IsRepeat == false)
                        mediaPlayer.Next();
                    else
                    {
                        mediaPlayer.SetPlaybackMode(true, false, false);
                        mediaPlayer.Next();
                        mediaPlayer.SetPlaybackMode(false, false, true);
                    }
                }

                else
                {
                    mediaPlayer.Pause();
                    mediaPlayer.DisposeAudio();
                    mediaPlayer.CurrentMedia.IsPlaying = PlaybackState.Stopped;
                    mediaPlayer.CurrentMedia = null;
                    ResetUIInfor();
                }
            }
            mediaPlayer.CurrentPlaylist.Remove(src);
        }
        public void ResetUIInfor()
        {
            picArtCover.Image = null;
            lblCurDuration.Text = TimeSpan.Zero.ToString("mm':'ss");
            lblDurationLimit.Text = TimeSpan.Zero.ToString("mm':'ss");
            labelRun1.lbText.Text = "";
            lblArtistName.Text = "";
            sliderMusic.Value = 0;
        }
        #endregion

        #region Account Actions

        public void SetUserName(string name)
        {
            if (name.Length > 10)
            {
                lblUserName.Text = name.Remove(9, name.Length - 9).Insert(9, "...");
            }
            else
            {
                lblUserName.Text = name;
            }
            if (lblUserName.Text == "Guess")
            {
                logOutToolStripMenuItem.Text = "Log In";
                changeYourPasswordToolStripMenuItem.Enabled = false;

                logOutToolStripMenuItem1.Text = logOutToolStripMenuItem.Text;
                changePasswordToolStripMenuItem.Enabled = changeYourPasswordToolStripMenuItem.Enabled;
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
            this.Close();
            Application.Exit();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSearch.Text != "")
            {
                if (IsConnectedToInternet())
                {
                    TextBox textbox = sender as TextBox;
                    uc_Search.pnlSearchTitle.Show();
                    uc_Search.pnlSearchTitle.BringToFront();
                    uc_Search.panelContainFpnl.Show();
                    uc_Search.panelContainFpnl.BringToFront();
                    uc_Search.lblTextSearch.Text = textbox.Text;
                    Action crawl = () =>
                    {
                        List<ucSongSearchDetail> ListSongSearch = search.Search(txtSearch.Text);
                        uc_Search.IsSearch = true;
                        uc_Search.ShowListSearch(ListSongSearch);
                    };
                    var thread = new Thread(
                  () => this.Invoke(crawl));
                    thread.Start();
                }
                else
                {
                    MsgBox.Show("Check your Internet connection and try again", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                }
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Music Controls
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.CurrentMedia == null)
            {
                if (mediaPlayer.CurrentPlaylist != null && mediaPlayer.CurrentPlaylist.Count > 0)
                    mediaPlayer.PlayInIndex(0);
                return;
            }
            if (uc_MusicCutter.opname != null)
                uc_MusicCutter.Pause();
            mediaPlayer.Play();
            timerSliderMusic.Start();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mediaPlayer.Pause();
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
            mediaPlayer.SetVolume((float)SliderVolume.Value / 100f);
            SliderVolume.ElapsedColor = Color.FromArgb(0, 192, 192);
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

        private bool isUcCollapsed;
        private void UcDropdownTime_Tick(object sender, EventArgs e)
        {
            if (isUcCollapsed)
            {
                pnlButton.Width += 10;
                if (pnlButton.Size == pnlButton.MaximumSize)
                {
                    UcDropdownTime.Stop();
                    isUcCollapsed = false;
                }
            }
            else
            {
                pnlButton.Width -= 10;
                if (pnlButton.Size == pnlButton.MinimumSize)
                {
                    UcDropdownTime.Stop();
                    isUcCollapsed = true;
                }
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            UcDropdownTime.Start();
            if (!isUcCollapsed)
            {
                txtHour.Hide();
                txtMinute.Hide();
                txtSecond.Hide();
                btnSetCustomTime.Hide();
                btnSetCustomTime.Enabled = false;
                btnCollapse.Image = BLADE.Properties.Resources.angle_right_24px;
                lblTextBLADE.Hide();
            }
            else
            {
                txtHour.Show();
                txtMinute.Show();
                txtSecond.Show();
                btnSetCustomTime.Show();
                btnCollapse.Image = BLADE.Properties.Resources.angle_left_24px;
                lblTextBLADE.Show();
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (!isUcCollapsed)
            {
                lblTextBLADE.Show();
            }
            else
            {
                lblTextBLADE.Hide();
            }
            DropdownTime.Start();
            if (pnlSelectedButton.Top == btnInfo.Top)
            {
                if (isCollapsed)
                {
                    btnInfo.Top = 491;
                    pnlSelectedButton.Height = btnInfo.Height;
                    pnlSelectedButton.Top = btnInfo.Top;
                }
                else
                {
                    btnInfo.Top = 343;
                    pnlSelectedButton.Height = btnInfo.Height;
                    pnlSelectedButton.Top = btnInfo.Top;
                }
            }
            else
            {
                if (isCollapsed)
                {
                    btnInfo.Top = 491;
                }
                else
                {
                    btnInfo.Top = 343;
                }
            }

        }
        private void MainForm_ShowingStateChanged(object sender, EventArgs e)
        {
            if (_showingUC == ShowingUC.UcQueue)
            {
                pnlSongInfo.Hide();
                pnlGif.Show();
            }
            else
            {
                pnlSongInfo.Show();
                pnlGif.Hide();
            }
            if (!isCollapsed)
            {
                btnTimer.PerformClick();
            }
            if (!isUcCollapsed)
            {
                lblTextBLADE.Show();
            }
            else
            {
                lblTextBLADE.Hide();
            }
            switch (_showingUC)
            {
                case ShowingUC.UcHome:
                    //set vi tri cho pnlSelectedButton
                    pnlSelectedButton.Show();
                    pnlSelectedButton.Height = btnHome.Height;
                    pnlSelectedButton.Top = btnHome.Top;
                    //cho user control ohu hop xuat hien
                    uc_Info.Hide();
                    uc_Playlist.Hide();
                    uc_Search.Hide();
                    uc_MusicCutter.Hide();
                    uc_Converter.Hide();
                    uc_Queue.Hide();
                    uc_NewHome.Show();
                    uc_NewHome.BringToFront();
                    break;
                case ShowingUC.UcPlaylist:
                    //set vi tri cho pnlSelectedButton
                    pnlSelectedButton.Show();
                    pnlSelectedButton.Height = btnPlaylist.Height;
                    pnlSelectedButton.Top = btnPlaylist.Top;
                    //cho user control ohu hop xuat hien
                    uc_Info.Hide();
                    uc_NewHome.Hide();
                    uc_Queue.Hide();
                    uc_Search.Hide();
                    uc_Converter.Hide();
                    uc_MusicCutter.Hide();
                    uc_Playlist.Show();
                    uc_Playlist.BringToFront();
                    break;
                case ShowingUC.UcQueue:
                    //cho user control ohu hop xuat hien
                    uc_Queue.Show();
                    uc_Queue.BringToFront();
                    ShowingUc = ShowingUC.UcQueue;
                    break;
                case ShowingUC.UcInfo:
                    //set vi tri cho pnlSelectedButton
                    pnlSelectedButton.Show();
                    pnlSelectedButton.Height = btnInfo.Height;
                    pnlSelectedButton.Top = btnInfo.Top;
                    //cho user control ohu hop xuat hien
                    uc_Playlist.Hide();
                    uc_NewHome.Hide();
                    uc_Search.Hide();
                    uc_Queue.Hide();
                    uc_Converter.Hide();
                    uc_MusicCutter.Hide();
                    lblTextBLADE.Hide();
                    uc_Info.Show();
                    uc_Info.BringToFront();
                    break;
                case ShowingUC.UcConverter:
                    if (!isCollapsed)
                    {
                        btnTimer.PerformClick();
                    }
                    //set vi tri cho pnlSelectedButton
                    pnlSelectedButton.Show();
                    pnlSelectedButton.Height = btnConverter.Height;
                    pnlSelectedButton.Top = btnConverter.Top;
                    //cho user control ohu hop xuat hien
                    uc_Info.Hide();
                    uc_Playlist.Hide();
                    uc_Search.Hide();
                    uc_NewHome.Hide();
                    uc_Queue.Hide();
                    uc_MusicCutter.Hide();
                    uc_Converter.Show();
                    uc_Converter.BringToFront();
                    break;
                case ShowingUC.UcMusicCutter:
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
                    uc_NewHome.Hide();
                    uc_Queue.Hide();
                    uc_Converter.Hide();
                    uc_MusicCutter.Show();
                    uc_MusicCutter.BringToFront();
                    break;
                case ShowingUC.UcSearch:
                    //an pnlSelectedButton di
                    pnlSelectedButton.Hide();
                    //cho user control ohu hop xuat hien
                    uc_Playlist.Hide();
                    uc_NewHome.Hide();
                    uc_Info.Hide();
                    uc_MusicCutter.Hide();
                    uc_Search.Show();
                    uc_Queue.Hide();
                    uc_Converter.Hide();
                    uc_Search.BringToFront();
                    if (uc_Search.IsSearch)
                    {
                        uc_Search.pnlSearchTitle.Show();
                        uc_Search.panelContainFpnl.Show();
                    }
                    else
                    {
                        uc_Search.pnlSearchTitle.Hide();
                        uc_Search.panelContainFpnl.Hide();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {

            if (_showingUC != ShowingUC.UcConverter)
            {
                ShowingUc = ShowingUC.UcConverter;
            }
        }

        private void btnMusicCutter_Click(object sender, EventArgs e)
        {

            if (_showingUC != ShowingUC.UcMusicCutter)
            {
                ShowingUc = ShowingUC.UcMusicCutter;
            }
        }
        private void btnQueue_Click(object sender, EventArgs e)
        {
            if (_showingUC != ShowingUC.UcQueue)
            {
                _lastShowingUc = _showingUC;
                ShowingUc = ShowingUC.UcQueue;
            }
            else
            {
                ShowingUc = _lastShowingUc;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            if (_showingUC != ShowingUC.UcHome)
            {
                ShowingUc = ShowingUC.UcHome;
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {

            if (_showingUC != ShowingUC.UcPlaylist)
            {
                ShowingUc = ShowingUC.UcPlaylist;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

            if (_showingUC != ShowingUC.UcInfo)
            {
                ShowingUc = ShowingUC.UcInfo;
            }
        }

        private void txtSearch_Click(object sender, MouseEventArgs e)
        {
            if (_showingUC != ShowingUC.UcSearch)
            {
                ShowingUc = ShowingUC.UcSearch;
            }
        }

        private void timerChangeColorBLADE_Tick(object sender, EventArgs e)
        {
            if (lblTextBLADE.ForeColor == Color.White)
            {
                lblTextBLADE.ForeColor = Color.FromArgb(0, 192, 192);
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
        private void MediaPlayer_CurrentMediaNullable(object sender, EventArgs e)
        {
            if (mediaPlayer.CurrentMedia == null)
            {
                sliderMusic.Enabled = false;
            }
            else
                sliderMusic.Enabled = true;
        }
        private void UcPlaylist_UpdatePlayback(object sender, EventArgs e)
        {
            Song song = sender as Song;
            if (mediaPlayer.AddSongToCurrentPlaylist(song))
                uc_Queue.UpdateQueue(song);
        }
        private void UcPlaylist_ChangePlayback(object sender, EventArgs e)
        {
            Playlist playlist = sender as Playlist;            mediaPlayer.CurrentPlaylist.Clear();            for (int i = 0; i < playlist.Count; i++)
            {
                mediaPlayer.CurrentPlaylist.Add(playlist.List[i]);
            }
            uc_Queue.UpdateQueue(mediaPlayer.CurrentPlaylist);
            mediaPlayer.PlayInIndex(0);
        }

        private void PlayMusic(object sender, EventArgs e)
        {
            Song song = sender as Song;
            mediaPlayer.AddSongToCurrentPlaylist(song);
            uc_Queue.UpdateQueue(mediaPlayer.CurrentPlaylist);
            mediaPlayer.PlayInIndex(mediaPlayer.CurrentPlaylist.IndexOf(song));
            if (uc_MusicCutter.opname != null)
                uc_MusicCutter.Pause();
            btnPause.Show();
            btnPlay.Hide();
        }
        private void MediaPlayer_MediaChanged(object sender, EventArgs e)
        {
            sliderMusic.Value = 0;
            sliderMusic.Maximum = (int)mediaPlayer.GetDurationInSecond();
            sliderMusic.SmallChange = 1;
            sliderMusic.LargeChange = Math.Min(10, (int)mediaPlayer.GetDurationInSecond() / 10);

            //string textSongName = mediaPlayer.CurrentMedia.SongName;
            string textAuthor = mediaPlayer.CurrentMedia.Singer;
            //if (textSongName.Length > 18)
            //{
            //    labelRun1.lbText.Text = textSongName.Remove(18, textSongName.Length - 18).Insert(18, "...");
            //}
            //else
            //{
            //    labelRun1.lbText.Text = textSongName;
            //}
            labelRun1.lbText.Text = mediaPlayer.CurrentMedia.SongName;
            if (textAuthor.Length > 21)
            {
                lblArtistName.Text = textAuthor.Remove(21, textAuthor.Length - 21).Insert(21, "...");
            }
            else
            {
                lblArtistName.Text = textAuthor;
            }
            lblDurationLimit.Text = mediaPlayer.CurrentMedia.SongTime;
            lblCurDuration.Text = TimeSpan.Zero.ToString("mm':'ss");
            timerSliderMusic.Start();
            //uc Playback
            picArtCover.Image = mediaPlayer.CurrentMedia.SongImage;
            uc_Queue.NowPlayingSong = mediaPlayer.CurrentMedia;
            uc_Queue.SetSongInfo();
            uc_NewHome.UpdateRecentlySong(mediaPlayer.CurrentMedia);
        }
        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            mediaPlayer.Next();
        }
        private void MediaPlayer_PlaybackStateChanged(object sender, EventArgs e)
        {
            if (mediaPlayer.MediaState == PlaybackState.Paused)
            {
                picboxGif.Hide();
                timerSliderMusic.Stop();
                btnPlay.Show();
                btnPause.Hide();
            }
            else
            if (mediaPlayer.MediaState == PlaybackState.Playing)
            {
                picboxGif.Show();
                timerSliderMusic.Start();
                btnPlay.Hide();
                btnPause.Show();
            }
            else
            {
                picboxGif.Hide();
                timerSliderMusic.Stop();
                btnPlay.Show();
                btnPause.Hide();
            }
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
                if (txtHour.Text != "")
                    h = Convert.ToInt32(txtHour.Text);
                if (txtMinute.Text != "")
                    m = Convert.ToInt32(txtMinute.Text);
                if (txtSecond.Text != "")
                    s = Convert.ToInt32(txtSecond.Text);

                if ((txtHour.Text == "") && (txtMinute.Text == "") && (txtSecond.Text == ""))
                    MsgBox.Show("You must enter timespan first", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
                else
                {
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
                    }
                    else
                    {
                        btnTimer.Hide();
                        btnStopTimer.Show();
                        notifyIcon.ShowBalloonTip(3000, "BLADE SleepTimer", timeRemain, ToolTipIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show("You must fill all fields", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
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
            mediaPlayer.SetVolume((float)SliderVolume.Value / 100f);
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
            this.Close();
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
            isDrag = true;
            mediaPlayer.SetPossition(sliderMusic.Value);
            lblCurDuration.Text = TimeSpan.FromSeconds(sliderMusic.Value).ToString("mm':'ss");
            isDrag = false;
        }
        private void TimerSliderMusic_Tick(object sender, EventArgs e)
        {
            if (isDrag == true)
                return;
            sliderMusic.Value = (int)mediaPlayer.GetCurrentPossiton();
            lblCurDuration.Text = TimeSpan.FromSeconds(sliderMusic.Value).ToString("mm':'ss");
        }

        #endregion

    }
}
