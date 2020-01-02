using System;

namespace BLADE
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlMusicControl = new System.Windows.Forms.Panel();
            this.lblCurDuration = new System.Windows.Forms.Label();
            this.pnlSongInfo = new System.Windows.Forms.Panel();
            this.labelRun1 = new BLADE.LabelRun();
            this.picArtCover = new System.Windows.Forms.PictureBox();
            this.lblArtistName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGif = new System.Windows.Forms.Panel();
            this.picboxGif = new System.Windows.Forms.PictureBox();
            this.lblDurationLimit = new System.Windows.Forms.Label();
            this.SliderVolume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.sliderMusic = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnVolumeOff = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lbCurDuration = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.lblTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menuUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeYourPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseWindows = new System.Windows.Forms.Button();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnMusicCutter = new System.Windows.Forms.Button();
            this.pnlSelectedButton = new System.Windows.Forms.Panel();
            this.pnlTimerControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSetCustomTime = new System.Windows.Forms.Button();
            this.txtSecond = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMinute = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtHour = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn10m = new System.Windows.Forms.Button();
            this.btn1h = new System.Windows.Forms.Button();
            this.btn30m = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblTextBLADE = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.AppMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConverter = new System.Windows.Forms.Button();
            this.DropdownTime = new System.Windows.Forms.Timer(this.components);
            this.timerChangeColorBLADE = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.uc_NewHome = new BLADE.ucNewHome();
            this.uc_Converter = new BLADE.UcConverter();
            this.uc_Playlist = new BLADE.ucPlaylist();
            this.uc_Info = new BLADE.ucInfo();
            this.uc_Search = new BLADE.ucSearch();
            this.uc_MusicCutter = new BLADE.ucMusicCutter();
            this.uc_Queue = new BLADE.ucQueue();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNofityIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.UcDropdownTime = new System.Windows.Forms.Timer(this.components);
            this.tltMainform = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMusicControl.SuspendLayout();
            this.pnlSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtCover)).BeginInit();
            this.pnlGif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxGif)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.menuUser.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlTimerControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.AppMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.menuNofityIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMusicControl
            // 
            this.pnlMusicControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlMusicControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMusicControl.Controls.Add(this.lblCurDuration);
            this.pnlMusicControl.Controls.Add(this.pnlSongInfo);
            this.pnlMusicControl.Controls.Add(this.pnlGif);
            this.pnlMusicControl.Controls.Add(this.lblDurationLimit);
            this.pnlMusicControl.Controls.Add(this.SliderVolume);
            this.pnlMusicControl.Controls.Add(this.btnPrev);
            this.pnlMusicControl.Controls.Add(this.btnQueue);
            this.pnlMusicControl.Controls.Add(this.btnNext);
            this.pnlMusicControl.Controls.Add(this.sliderMusic);
            this.pnlMusicControl.Controls.Add(this.btnVolumeOff);
            this.pnlMusicControl.Controls.Add(this.btnVolume);
            this.pnlMusicControl.Controls.Add(this.btnShuffle);
            this.pnlMusicControl.Controls.Add(this.btnRepeat);
            this.pnlMusicControl.Controls.Add(this.btnLoop);
            this.pnlMusicControl.Controls.Add(this.btnPlay);
            this.pnlMusicControl.Controls.Add(this.btnPause);
            this.pnlMusicControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMusicControl.Location = new System.Drawing.Point(0, 600);
            this.pnlMusicControl.Name = "pnlMusicControl";
            this.pnlMusicControl.Size = new System.Drawing.Size(1000, 100);
            this.pnlMusicControl.TabIndex = 0;
            // 
            // lblCurDuration
            // 
            this.lblCurDuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurDuration.Location = new System.Drawing.Point(255, 47);
            this.lblCurDuration.Name = "lblCurDuration";
            this.lblCurDuration.Size = new System.Drawing.Size(51, 21);
            this.lblCurDuration.TabIndex = 5;
            this.lblCurDuration.Text = "00:00";
            // 
            // pnlSongInfo
            // 
            this.pnlSongInfo.Controls.Add(this.labelRun1);
            this.pnlSongInfo.Controls.Add(this.picArtCover);
            this.pnlSongInfo.Controls.Add(this.lblArtistName);
            this.pnlSongInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSongInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlSongInfo.Name = "pnlSongInfo";
            this.pnlSongInfo.Size = new System.Drawing.Size(240, 100);
            this.pnlSongInfo.TabIndex = 7;
            // 
            // labelRun1
            // 
            this.labelRun1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelRun1.Location = new System.Drawing.Point(89, 15);
            this.labelRun1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelRun1.Name = "labelRun1";
            this.labelRun1.Size = new System.Drawing.Size(139, 29);
            this.labelRun1.TabIndex = 6;
            // 
            // picArtCover
            // 
            this.picArtCover.Location = new System.Drawing.Point(3, 15);
            this.picArtCover.Name = "picArtCover";
            this.picArtCover.Size = new System.Drawing.Size(73, 73);
            this.picArtCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArtCover.TabIndex = 5;
            this.picArtCover.TabStop = false;
            // 
            // lblArtistName
            // 
            this.lblArtistName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblArtistName.Location = new System.Drawing.Point(86, 56);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(0, 16);
            this.lblArtistName.TabIndex = 4;
            // 
            // pnlGif
            // 
            this.pnlGif.Controls.Add(this.picboxGif);
            this.pnlGif.Location = new System.Drawing.Point(10, 10);
            this.pnlGif.Name = "pnlGif";
            this.pnlGif.Size = new System.Drawing.Size(218, 78);
            this.pnlGif.TabIndex = 6;
            // 
            // picboxGif
            // 
            this.picboxGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxGif.Location = new System.Drawing.Point(0, 0);
            this.picboxGif.Name = "picboxGif";
            this.picboxGif.Size = new System.Drawing.Size(218, 78);
            this.picboxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxGif.TabIndex = 0;
            this.picboxGif.TabStop = false;
            // 
            // lblDurationLimit
            // 
            this.lblDurationLimit.AutoSize = true;
            this.lblDurationLimit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDurationLimit.Location = new System.Drawing.Point(690, 47);
            this.lblDurationLimit.Name = "lblDurationLimit";
            this.lblDurationLimit.Size = new System.Drawing.Size(40, 17);
            this.lblDurationLimit.TabIndex = 5;
            this.lblDurationLimit.Text = "04:00";
            // 
            // SliderVolume
            // 
            this.SliderVolume.AllowCursorChanges = true;
            this.SliderVolume.AllowHomeEndKeysDetection = false;
            this.SliderVolume.AllowIncrementalClickMoves = true;
            this.SliderVolume.AllowMouseDownEffects = false;
            this.SliderVolume.AllowMouseHoverEffects = false;
            this.SliderVolume.AllowScrollingAnimations = true;
            this.SliderVolume.AllowScrollKeysDetection = true;
            this.SliderVolume.AllowScrollOptionsMenu = true;
            this.SliderVolume.AllowShrinkingOnFocusLost = false;
            this.SliderVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SliderVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SliderVolume.BackgroundImage")));
            this.SliderVolume.BindingContainer = null;
            this.SliderVolume.BorderRadius = 2;
            this.SliderVolume.BorderThickness = 1;
            this.SliderVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SliderVolume.DrawThickBorder = false;
            this.SliderVolume.DurationBeforeShrink = 2000;
            this.SliderVolume.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SliderVolume.LargeChange = 1;
            this.SliderVolume.Location = new System.Drawing.Point(866, 38);
            this.SliderVolume.Margin = new System.Windows.Forms.Padding(5);
            this.SliderVolume.Maximum = 5;
            this.SliderVolume.Minimum = 0;
            this.SliderVolume.MinimumSize = new System.Drawing.Size(0, 30);
            this.SliderVolume.MinimumThumbLength = 18;
            this.SliderVolume.Name = "SliderVolume";
            this.SliderVolume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.SliderVolume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.SliderVolume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.SliderVolume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SliderVolume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SliderVolume.ShrinkSizeLimit = 3;
            this.SliderVolume.Size = new System.Drawing.Size(109, 30);
            this.SliderVolume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SliderVolume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SliderVolume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SliderVolume.SmallChange = 1;
            this.SliderVolume.TabIndex = 3;
            this.SliderVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SliderVolume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.SliderVolume.ThumbLength = 18;
            this.SliderVolume.ThumbMargin = 1;
            this.SliderVolume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill;
            this.SliderVolume.Value = 5;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(419, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnQueue.FlatAppearance.BorderSize = 0;
            this.btnQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueue.Image = ((System.Drawing.Image)(resources.GetObject("btnQueue.Image")));
            this.btnQueue.Location = new System.Drawing.Point(587, 6);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(50, 50);
            this.btnQueue.TabIndex = 1;
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(531, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // sliderMusic
            // 
            this.sliderMusic.AllowCursorChanges = true;
            this.sliderMusic.AllowHomeEndKeysDetection = false;
            this.sliderMusic.AllowIncrementalClickMoves = true;
            this.sliderMusic.AllowMouseDownEffects = false;
            this.sliderMusic.AllowMouseHoverEffects = false;
            this.sliderMusic.AllowScrollingAnimations = true;
            this.sliderMusic.AllowScrollKeysDetection = false;
            this.sliderMusic.AllowScrollOptionsMenu = true;
            this.sliderMusic.AllowShrinkingOnFocusLost = false;
            this.sliderMusic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sliderMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderMusic.BackgroundImage")));
            this.sliderMusic.BindingContainer = null;
            this.sliderMusic.BorderRadius = 2;
            this.sliderMusic.BorderThickness = 1;
            this.sliderMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderMusic.DrawThickBorder = false;
            this.sliderMusic.DurationBeforeShrink = 2000;
            this.sliderMusic.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sliderMusic.LargeChange = 1;
            this.sliderMusic.Location = new System.Drawing.Point(250, 66);
            this.sliderMusic.Margin = new System.Windows.Forms.Padding(4);
            this.sliderMusic.Maximum = 100;
            this.sliderMusic.Minimum = 0;
            this.sliderMusic.MinimumSize = new System.Drawing.Size(0, 31);
            this.sliderMusic.MinimumThumbLength = 18;
            this.sliderMusic.Name = "sliderMusic";
            this.sliderMusic.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderMusic.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderMusic.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderMusic.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sliderMusic.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sliderMusic.ShrinkSizeLimit = 3;
            this.sliderMusic.Size = new System.Drawing.Size(500, 31);
            this.sliderMusic.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sliderMusic.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sliderMusic.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sliderMusic.SmallChange = 1;
            this.sliderMusic.TabIndex = 0;
            this.sliderMusic.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sliderMusic.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.sliderMusic.ThumbLength = 18;
            this.sliderMusic.ThumbMargin = 1;
            this.sliderMusic.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill;
            this.sliderMusic.Value = 50;
            // 
            // btnVolumeOff
            // 
            this.btnVolumeOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolumeOff.FlatAppearance.BorderSize = 0;
            this.btnVolumeOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeOff.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumeOff.Image")));
            this.btnVolumeOff.Location = new System.Drawing.Point(808, 27);
            this.btnVolumeOff.Name = "btnVolumeOff";
            this.btnVolumeOff.Size = new System.Drawing.Size(50, 50);
            this.btnVolumeOff.TabIndex = 1;
            this.btnVolumeOff.UseVisualStyleBackColor = true;
            this.btnVolumeOff.Click += new System.EventHandler(this.btnVolumeOff_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnVolume.Image")));
            this.btnVolume.Location = new System.Drawing.Point(808, 27);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(50, 50);
            this.btnVolume.TabIndex = 1;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.Location = new System.Drawing.Point(363, 5);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(50, 50);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeat.Image")));
            this.btnRepeat.Location = new System.Drawing.Point(363, 5);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(50, 50);
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLoop.FlatAppearance.BorderSize = 0;
            this.btnLoop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLoop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoop.Image = ((System.Drawing.Image)(resources.GetObject("btnLoop.Image")));
            this.btnLoop.Location = new System.Drawing.Point(363, 5);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(50, 50);
            this.btnLoop.TabIndex = 1;
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(475, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(475, 5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lbCurDuration
            // 
            this.lbCurDuration.Location = new System.Drawing.Point(0, 0);
            this.lbCurDuration.Name = "lbCurDuration";
            this.lbCurDuration.Size = new System.Drawing.Size(100, 23);
            this.lbCurDuration.TabIndex = 0;
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlControl.Controls.Add(this.btnCollapse);
            this.pnlControl.Controls.Add(this.lblTime);
            this.pnlControl.Controls.Add(this.lblUserName);
            this.pnlControl.Controls.Add(this.txtSearch);
            this.pnlControl.Controls.Add(this.btnMinimize);
            this.pnlControl.Controls.Add(this.btnCloseWindows);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(213, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(787, 35);
            this.pnlControl.TabIndex = 2;
            // 
            // btnCollapse
            // 
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCollapse.Image = global::BLADE.Properties.Resources.angle_left_24px;
            this.btnCollapse.Location = new System.Drawing.Point(0, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(35, 35);
            this.btnCollapse.TabIndex = 4;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(349, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 18);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "TimeNow";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.ContextMenuStrip = this.menuUser;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(560, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(96, 18);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Guess";
            // 
            // menuUser
            // 
            this.menuUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeYourPasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuUser.Name = "menuUser";
            this.menuUser.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuUser.ShowImageMargin = false;
            this.menuUser.Size = new System.Drawing.Size(186, 48);
            // 
            // changeYourPasswordToolStripMenuItem
            // 
            this.changeYourPasswordToolStripMenuItem.AutoToolTip = true;
            this.changeYourPasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.changeYourPasswordToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeYourPasswordToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.changeYourPasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.changeYourPasswordToolStripMenuItem.Name = "changeYourPasswordToolStripMenuItem";
            this.changeYourPasswordToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changeYourPasswordToolStripMenuItem.Text = "Change Your Password";
            this.changeYourPasswordToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeYourPasswordToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.changeYourPasswordToolStripMenuItem.Click += new System.EventHandler(this.changeYourPasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.AutoToolTip = true;
            this.logOutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(80, 4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties8;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(197, 27);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Search";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSearch_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(711, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseWindows
            // 
            this.btnCloseWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindows.FlatAppearance.BorderSize = 0;
            this.btnCloseWindows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindows.Image")));
            this.btnCloseWindows.Location = new System.Drawing.Point(752, 0);
            this.btnCloseWindows.Name = "btnCloseWindows";
            this.btnCloseWindows.Size = new System.Drawing.Size(35, 35);
            this.btnCloseWindows.TabIndex = 0;
            this.btnCloseWindows.UseVisualStyleBackColor = true;
            this.btnCloseWindows.Click += new System.EventHandler(this.btnCloseWindows_Click);
            // 
            // lblCountdown
            // 
            this.lblCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCountdown.Location = new System.Drawing.Point(120, 14);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(0, 16);
            this.lblCountdown.TabIndex = 4;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.pnlControl;
            this.DragControl.Vertical = true;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlButton.Controls.Add(this.btnMusicCutter);
            this.pnlButton.Controls.Add(this.pnlSelectedButton);
            this.pnlButton.Controls.Add(this.pnlTimerControl);
            this.pnlButton.Controls.Add(this.btnInfo);
            this.pnlButton.Controls.Add(this.lblTextBLADE);
            this.pnlButton.Controls.Add(this.btnHome);
            this.pnlButton.Controls.Add(this.btnPlaylist);
            this.pnlButton.Controls.Add(this.AppMenu);
            this.pnlButton.Controls.Add(this.btnConverter);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.MaximumSize = new System.Drawing.Size(213, 600);
            this.pnlButton.MinimumSize = new System.Drawing.Size(57, 600);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(213, 600);
            this.pnlButton.TabIndex = 3;
            // 
            // btnMusicCutter
            // 
            this.btnMusicCutter.FlatAppearance.BorderSize = 0;
            this.btnMusicCutter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMusicCutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCutter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicCutter.ForeColor = System.Drawing.Color.White;
            this.btnMusicCutter.Image = ((System.Drawing.Image)(resources.GetObject("btnMusicCutter.Image")));
            this.btnMusicCutter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusicCutter.Location = new System.Drawing.Point(12, 190);
            this.btnMusicCutter.Name = "btnMusicCutter";
            this.btnMusicCutter.Size = new System.Drawing.Size(198, 45);
            this.btnMusicCutter.TabIndex = 18;
            this.btnMusicCutter.Text = "   Cutter";
            this.btnMusicCutter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusicCutter.UseVisualStyleBackColor = true;
            this.btnMusicCutter.Click += new System.EventHandler(this.btnMusicCutter_Click);
            // 
            // pnlSelectedButton
            // 
            this.pnlSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlSelectedButton.ForeColor = System.Drawing.Color.White;
            this.pnlSelectedButton.Location = new System.Drawing.Point(0, 88);
            this.pnlSelectedButton.Name = "pnlSelectedButton";
            this.pnlSelectedButton.Size = new System.Drawing.Size(4, 45);
            this.pnlSelectedButton.TabIndex = 4;
            // 
            // pnlTimerControl
            // 
            this.pnlTimerControl.Controls.Add(this.lblCountdown);
            this.pnlTimerControl.Controls.Add(this.panel3);
            this.pnlTimerControl.Controls.Add(this.btn10m);
            this.pnlTimerControl.Controls.Add(this.btn1h);
            this.pnlTimerControl.Controls.Add(this.btn30m);
            this.pnlTimerControl.Controls.Add(this.btnTimer);
            this.pnlTimerControl.Controls.Add(this.btnStopTimer);
            this.pnlTimerControl.Location = new System.Drawing.Point(12, 292);
            this.pnlTimerControl.MaximumSize = new System.Drawing.Size(198, 193);
            this.pnlTimerControl.MinimumSize = new System.Drawing.Size(198, 45);
            this.pnlTimerControl.Name = "pnlTimerControl";
            this.pnlTimerControl.Size = new System.Drawing.Size(198, 45);
            this.pnlTimerControl.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSetCustomTime);
            this.panel3.Controls.Add(this.txtSecond);
            this.panel3.Controls.Add(this.txtMinute);
            this.panel3.Controls.Add(this.txtHour);
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 30);
            this.panel3.TabIndex = 16;
            // 
            // btnSetCustomTime
            // 
            this.btnSetCustomTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetCustomTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSetCustomTime.FlatAppearance.BorderSize = 0;
            this.btnSetCustomTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetCustomTime.Location = new System.Drawing.Point(160, 0);
            this.btnSetCustomTime.Name = "btnSetCustomTime";
            this.btnSetCustomTime.Size = new System.Drawing.Size(35, 30);
            this.btnSetCustomTime.TabIndex = 6;
            this.btnSetCustomTime.Text = "Set";
            this.btnSetCustomTime.UseVisualStyleBackColor = false;
            this.btnSetCustomTime.Click += new System.EventHandler(this.btnSetCustomTime_Click);
            // 
            // txtSecond
            // 
            this.txtSecond.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSecond.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSecond.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecond.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSecond.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSecond.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSecond.HintText = "S";
            this.txtSecond.isPassword = false;
            this.txtSecond.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSecond.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSecond.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSecond.LineThickness = 2;
            this.txtSecond.Location = new System.Drawing.Point(113, 0);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecond.MaxLength = 32767;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(40, 30);
            this.txtSecond.TabIndex = 5;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinute
            // 
            this.txtMinute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMinute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMinute.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinute.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMinute.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMinute.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMinute.HintText = "M";
            this.txtMinute.isPassword = false;
            this.txtMinute.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMinute.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMinute.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMinute.LineThickness = 2;
            this.txtMinute.Location = new System.Drawing.Point(65, 0);
            this.txtMinute.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinute.MaxLength = 32767;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(40, 30);
            this.txtMinute.TabIndex = 5;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHour
            // 
            this.txtHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHour.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHour.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHour.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtHour.HintText = "H";
            this.txtHour.isPassword = false;
            this.txtHour.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtHour.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHour.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtHour.LineThickness = 2;
            this.txtHour.Location = new System.Drawing.Point(17, 0);
            this.txtHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtHour.MaxLength = 32767;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(40, 30);
            this.txtHour.TabIndex = 5;
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn10m
            // 
            this.btn10m.FlatAppearance.BorderSize = 0;
            this.btn10m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10m.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10m.Image = ((System.Drawing.Image)(resources.GetObject("btn10m.Image")));
            this.btn10m.Location = new System.Drawing.Point(0, 51);
            this.btn10m.Name = "btn10m";
            this.btn10m.Size = new System.Drawing.Size(198, 30);
            this.btn10m.TabIndex = 15;
            this.btn10m.Text = "   10 minutes";
            this.btn10m.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn10m.UseVisualStyleBackColor = true;
            this.btn10m.Click += new System.EventHandler(this.btn10m_Click_1);
            // 
            // btn1h
            // 
            this.btn1h.FlatAppearance.BorderSize = 0;
            this.btn1h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1h.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1h.Image = ((System.Drawing.Image)(resources.GetObject("btn1h.Image")));
            this.btn1h.Location = new System.Drawing.Point(0, 123);
            this.btn1h.Name = "btn1h";
            this.btn1h.Size = new System.Drawing.Size(198, 30);
            this.btn1h.TabIndex = 14;
            this.btn1h.Text = "   1 hour       ";
            this.btn1h.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1h.UseVisualStyleBackColor = true;
            this.btn1h.Click += new System.EventHandler(this.btn1h_Click_1);
            // 
            // btn30m
            // 
            this.btn30m.FlatAppearance.BorderSize = 0;
            this.btn30m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn30m.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30m.Image = ((System.Drawing.Image)(resources.GetObject("btn30m.Image")));
            this.btn30m.Location = new System.Drawing.Point(0, 87);
            this.btn30m.Name = "btn30m";
            this.btn30m.Size = new System.Drawing.Size(198, 30);
            this.btn30m.TabIndex = 14;
            this.btn30m.Text = "   30 minutes";
            this.btn30m.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn30m.UseVisualStyleBackColor = true;
            this.btn30m.Click += new System.EventHandler(this.btn30m_Click_1);
            // 
            // btnTimer
            // 
            this.btnTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.White;
            this.btnTimer.Image = ((System.Drawing.Image)(resources.GetObject("btnTimer.Image")));
            this.btnTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimer.Location = new System.Drawing.Point(0, 0);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(198, 45);
            this.btnTimer.TabIndex = 13;
            this.btnTimer.Text = "   Timer";
            this.btnTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.FlatAppearance.BorderSize = 0;
            this.btnStopTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopTimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.ForeColor = System.Drawing.Color.White;
            this.btnStopTimer.Image = ((System.Drawing.Image)(resources.GetObject("btnStopTimer.Image")));
            this.btnStopTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopTimer.Location = new System.Drawing.Point(0, 0);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(198, 45);
            this.btnStopTimer.TabIndex = 17;
            this.btnStopTimer.Text = "   Stop Timer";
            this.btnStopTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(12, 343);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(198, 45);
            this.btnInfo.TabIndex = 13;
            this.btnInfo.Text = "   About Us";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblTextBLADE
            // 
            this.lblTextBLADE.AutoEllipsis = false;
            this.lblTextBLADE.AutoSize = false;
            this.lblTextBLADE.CursorType = null;
            this.lblTextBLADE.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.lblTextBLADE.ForeColor = System.Drawing.Color.White;
            this.lblTextBLADE.Location = new System.Drawing.Point(0, 0);
            this.lblTextBLADE.Name = "lblTextBLADE";
            this.lblTextBLADE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTextBLADE.Size = new System.Drawing.Size(213, 66);
            this.lblTextBLADE.TabIndex = 14;
            this.lblTextBLADE.Text = "BLADE";
            this.lblTextBLADE.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTextBLADE.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 88);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(198, 45);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "   Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(12, 139);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(198, 45);
            this.btnPlaylist.TabIndex = 13;
            this.btnPlaylist.Text = "   Playlist";
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // AppMenu
            // 
            this.AppMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.AppMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AppMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.AppMenu.Location = new System.Drawing.Point(0, 572);
            this.AppMenu.Name = "AppMenu";
            this.AppMenu.Size = new System.Drawing.Size(213, 28);
            this.AppMenu.TabIndex = 17;
            this.AppMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoToolTip = true;
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShowShortcutKeys = false;
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.AutoToolTip = true;
            this.playbackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.playbackToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem});
            this.playbackToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.ShowShortcutKeys = false;
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.playToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pauseToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nextToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.previousToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.AutoToolTip = true;
            this.accountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.accountToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.ShowShortcutKeys = false;
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.logOutToolStripMenuItem1.ForeColor = System.Drawing.Color.Gainsboro;
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.FlatAppearance.BorderSize = 0;
            this.btnConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.ForeColor = System.Drawing.Color.White;
            this.btnConverter.Image = global::BLADE.Properties.Resources.change_30px;
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.Location = new System.Drawing.Point(12, 241);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(198, 45);
            this.btnConverter.TabIndex = 18;
            this.btnConverter.Text = "   Converter";
            this.btnConverter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // DropdownTime
            // 
            this.DropdownTime.Interval = 10;
            this.DropdownTime.Tick += new System.EventHandler(this.DropdownTime_Tick);
            // 
            // timerChangeColorBLADE
            // 
            this.timerChangeColorBLADE.Enabled = true;
            this.timerChangeColorBLADE.Interval = 2000;
            this.timerChangeColorBLADE.Tick += new System.EventHandler(this.timerChangeColorBLADE_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.uc_NewHome);
            this.pnlMain.Controls.Add(this.uc_Converter);
            this.pnlMain.Controls.Add(this.uc_Playlist);
            this.pnlMain.Controls.Add(this.uc_Info);
            this.pnlMain.Controls.Add(this.uc_Search);
            this.pnlMain.Controls.Add(this.uc_MusicCutter);
            this.pnlMain.Controls.Add(this.uc_Queue);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(213, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(787, 565);
            this.pnlMain.TabIndex = 4;
            // 
            // uc_NewHome
            // 
            this.uc_NewHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_NewHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_NewHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_NewHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_NewHome.Location = new System.Drawing.Point(0, 0);
            this.uc_NewHome.Margin = new System.Windows.Forms.Padding(4);
            this.uc_NewHome.Name = "uc_NewHome";
            this.uc_NewHome.Size = new System.Drawing.Size(787, 565);
            this.uc_NewHome.TabIndex = 7;
            // 
            // uc_Converter
            // 
            this.uc_Converter.AutoSize = true;
            this.uc_Converter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Converter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Converter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Converter.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Converter.Location = new System.Drawing.Point(0, 0);
            this.uc_Converter.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Converter.Name = "uc_Converter";
            this.uc_Converter.Size = new System.Drawing.Size(787, 565);
            this.uc_Converter.TabIndex = 8;
            // 
            // uc_Playlist
            // 
            this.uc_Playlist.AutoSize = true;
            this.uc_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Playlist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Playlist.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Playlist.Location = new System.Drawing.Point(0, 0);
            this.uc_Playlist.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Playlist.Name = "uc_Playlist";
            this.uc_Playlist.Size = new System.Drawing.Size(787, 565);
            this.uc_Playlist.TabIndex = 1;
            // 
            // uc_Info
            // 
            this.uc_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Info.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Info.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Info.Location = new System.Drawing.Point(0, 0);
            this.uc_Info.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Info.Name = "uc_Info";
            this.uc_Info.Size = new System.Drawing.Size(787, 565);
            this.uc_Info.TabIndex = 0;
            // 
            // uc_Search
            // 
            this.uc_Search.AutoSize = true;
            this.uc_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Search.IsSearch = false;
            this.uc_Search.Location = new System.Drawing.Point(0, 0);
            this.uc_Search.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Search.Name = "uc_Search";
            this.uc_Search.Size = new System.Drawing.Size(787, 565);
            this.uc_Search.TabIndex = 3;
            // 
            // uc_MusicCutter
            // 
            this.uc_MusicCutter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_MusicCutter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_MusicCutter.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_MusicCutter.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_MusicCutter.Location = new System.Drawing.Point(0, 0);
            this.uc_MusicCutter.Name = "uc_MusicCutter";
            this.uc_MusicCutter.Size = new System.Drawing.Size(787, 565);
            this.uc_MusicCutter.TabIndex = 5;
            // 
            // uc_Queue
            // 
            this.uc_Queue.AutoSize = true;
            this.uc_Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Queue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Queue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Queue.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Queue.Location = new System.Drawing.Point(0, 0);
            this.uc_Queue.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Queue.Name = "uc_Queue";
            this.uc_Queue.NowPlayingSong = null;
            this.uc_Queue.Size = new System.Drawing.Size(787, 565);
            this.uc_Queue.TabIndex = 6;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.menuNofityIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BLADE-Player";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // menuNofityIcon
            // 
            this.menuNofityIcon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuNofityIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToTrayToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuNofityIcon.Name = "menuNofityIcon";
            this.menuNofityIcon.Size = new System.Drawing.Size(162, 48);
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(757, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label1";
            // 
            // UcDropdownTime
            // 
            this.UcDropdownTime.Interval = 10;
            this.UcDropdownTime.Tick += new System.EventHandler(this.UcDropdownTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlMusicControl);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLADE-Player";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMusicControl.ResumeLayout(false);
            this.pnlMusicControl.PerformLayout();
            this.pnlSongInfo.ResumeLayout(false);
            this.pnlSongInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtCover)).EndInit();
            this.pnlGif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxGif)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.menuUser.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlTimerControl.ResumeLayout(false);
            this.pnlTimerControl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.AppMenu.ResumeLayout(false);
            this.AppMenu.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.menuNofityIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SleepNotifyIcon_Click(object sender, EventArgs e)
        {
            s_Timer.Stop();
        }

        #endregion
        private System.Windows.Forms.Panel pnlMusicControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseWindows;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private Bunifu.UI.WinForms.BunifuHSlider sliderMusic;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private Bunifu.UI.WinForms.BunifuHSlider SliderVolume;
        private System.Windows.Forms.Panel pnlButton;
        private Bunifu.UI.WinForms.BunifuLabel lblTextBLADE;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Panel pnlTimerControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn10m;
        private System.Windows.Forms.Button btn30m;
        private System.Windows.Forms.Button btn1h;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHour;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSecond;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMinute;
        private System.Windows.Forms.Button btnSetCustomTime;
        private System.Windows.Forms.Panel pnlSelectedButton;
        private System.Windows.Forms.Timer DropdownTime;
        private System.Windows.Forms.Timer timerChangeColorBLADE;
        private System.Windows.Forms.Panel pnlMain;
        private ucInfo uc_Info;
        private ucPlaylist uc_Playlist;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private ucSearch uc_Search;
        private stopTimer s_Timer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private System.Windows.Forms.Button btnVolumeOff;
        private System.Windows.Forms.Button btnVolume;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArtistName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.MenuStrip AppMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblDurationLimit;
        private System.Windows.Forms.Label lbCurDuration;
        private System.Windows.Forms.ContextMenuStrip menuNofityIcon;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurDuration;
        private System.Windows.Forms.ContextMenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem changeYourPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnMusicCutter;
        private ucMusicCutter uc_MusicCutter;
        private System.Windows.Forms.Button btnQueue;
        private ucQueue uc_Queue;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Timer UcDropdownTime;
        private System.Windows.Forms.Panel pnlSongInfo;
        private System.Windows.Forms.PictureBox picArtCover;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel pnlGif;
        private System.Windows.Forms.PictureBox picboxGif;
        private ucNewHome uc_NewHome;
        private UcConverter uc_Converter;
        private System.Windows.Forms.ToolTip tltMainform;
        private LabelRun labelRun1;
    }
}

