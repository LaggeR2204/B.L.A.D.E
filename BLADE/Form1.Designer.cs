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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.pnlMusicControl = new System.Windows.Forms.Panel();
            this.lblArtistName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSongName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SliderVolume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnShuffleOff = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.sliderMusic = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRepeatOff = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnVolumeOff = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseWindows = new System.Windows.Forms.Button();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlButton = new System.Windows.Forms.Panel();
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblTextBLADE = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.AppMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DropdownTime = new System.Windows.Forms.Timer(this.components);
            this.timerChangeColorBLADE = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.uc_Home = new BLADE.ucHome();
            this.uc_Playlist = new BLADE.ucPlaylist();
            this.uc_Info = new BLADE.ucInfo();
            this.uc_Search = new BLADE.ucSearch();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.pnlMusicControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlTimerControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.AppMenu.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMusicControl
            // 
            this.pnlMusicControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlMusicControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMusicControl.Controls.Add(this.lblArtistName);
            this.pnlMusicControl.Controls.Add(this.lblSongName);
            this.pnlMusicControl.Controls.Add(this.SliderVolume);
            this.pnlMusicControl.Controls.Add(this.WMP);
            this.pnlMusicControl.Controls.Add(this.btnPrev);
            this.pnlMusicControl.Controls.Add(this.btnShuffleOff);
            this.pnlMusicControl.Controls.Add(this.btnShuffle);
            this.pnlMusicControl.Controls.Add(this.btnNext);
            this.pnlMusicControl.Controls.Add(this.btnPlay);
            this.pnlMusicControl.Controls.Add(this.sliderMusic);
            this.pnlMusicControl.Controls.Add(this.btnPause);
            this.pnlMusicControl.Controls.Add(this.btnRepeatOff);
            this.pnlMusicControl.Controls.Add(this.btnRepeat);
            this.pnlMusicControl.Controls.Add(this.btnVolumeOff);
            this.pnlMusicControl.Controls.Add(this.btnVolume);
            this.pnlMusicControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMusicControl.Location = new System.Drawing.Point(0, 600);
            this.pnlMusicControl.Name = "pnlMusicControl";
            this.pnlMusicControl.Size = new System.Drawing.Size(1000, 100);
            this.pnlMusicControl.TabIndex = 0;
            // 
            // lblArtistName
            // 
            this.lblArtistName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblArtistName.Location = new System.Drawing.Point(9, 57);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(0, 21);
            this.lblArtistName.TabIndex = 4;
            // 
            // lblSongName
            // 
            this.lblSongName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.Location = new System.Drawing.Point(9, 27);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(0, 23);
            this.lblSongName.TabIndex = 4;
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
            this.SliderVolume.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.SliderVolume.LargeChange = 1;
            this.SliderVolume.Location = new System.Drawing.Point(913, 38);
            this.SliderVolume.Margin = new System.Windows.Forms.Padding(5);
            this.SliderVolume.Maximum = 100;
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
            this.SliderVolume.Size = new System.Drawing.Size(82, 30);
            this.SliderVolume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SliderVolume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SliderVolume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SliderVolume.SmallChange = 1;
            this.SliderVolume.TabIndex = 3;
            this.SliderVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.SliderVolume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.SliderVolume.ThumbLength = 18;
            this.SliderVolume.ThumbMargin = 1;
            this.SliderVolume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill;
            this.SliderVolume.Value = 100;
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 0);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(0, 0);
            this.WMP.TabIndex = 2;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(419, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnShuffleOff
            // 
            this.btnShuffleOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnShuffleOff.FlatAppearance.BorderSize = 0;
            this.btnShuffleOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffleOff.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffleOff.Image")));
            this.btnShuffleOff.Location = new System.Drawing.Point(363, 5);
            this.btnShuffleOff.Name = "btnShuffleOff";
            this.btnShuffleOff.Size = new System.Drawing.Size(50, 50);
            this.btnShuffleOff.TabIndex = 1;
            this.btnShuffleOff.UseVisualStyleBackColor = true;
            this.btnShuffleOff.Click += new System.EventHandler(this.btnShuffleOff_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = ((System.Drawing.Image)(resources.GetObject("btnShuffle.Image")));
            this.btnShuffle.Location = new System.Drawing.Point(363, 5);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(50, 50);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(531, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(475, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // sliderMusic
            // 
            this.sliderMusic.AllowCursorChanges = true;
            this.sliderMusic.AllowHomeEndKeysDetection = false;
            this.sliderMusic.AllowIncrementalClickMoves = true;
            this.sliderMusic.AllowMouseDownEffects = false;
            this.sliderMusic.AllowMouseHoverEffects = false;
            this.sliderMusic.AllowScrollingAnimations = true;
            this.sliderMusic.AllowScrollKeysDetection = true;
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
            this.sliderMusic.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.sliderMusic.LargeChange = 1;
            this.sliderMusic.Location = new System.Drawing.Point(250, 66);
            this.sliderMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.sliderMusic.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.sliderMusic.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.sliderMusic.ThumbLength = 18;
            this.sliderMusic.ThumbMargin = 1;
            this.sliderMusic.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill;
            this.sliderMusic.Value = 50;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(475, 5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRepeatOff
            // 
            this.btnRepeatOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRepeatOff.FlatAppearance.BorderSize = 0;
            this.btnRepeatOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeatOff.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeatOff.Image")));
            this.btnRepeatOff.Location = new System.Drawing.Point(587, 5);
            this.btnRepeatOff.Name = "btnRepeatOff";
            this.btnRepeatOff.Size = new System.Drawing.Size(50, 50);
            this.btnRepeatOff.TabIndex = 1;
            this.btnRepeatOff.UseVisualStyleBackColor = true;
            this.btnRepeatOff.Click += new System.EventHandler(this.btnRepeatOff_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeat.Image")));
            this.btnRepeat.Location = new System.Drawing.Point(587, 5);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(50, 50);
            this.btnRepeat.TabIndex = 1;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnVolumeOff
            // 
            this.btnVolumeOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolumeOff.FlatAppearance.BorderSize = 0;
            this.btnVolumeOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeOff.Image = ((System.Drawing.Image)(resources.GetObject("btnVolumeOff.Image")));
            this.btnVolumeOff.Location = new System.Drawing.Point(855, 27);
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
            this.btnVolume.Location = new System.Drawing.Point(855, 27);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(50, 50);
            this.btnVolume.TabIndex = 1;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.lblCountdown);
            this.pnlControl.Controls.Add(this.lblTime);
            this.pnlControl.Controls.Add(this.lblUserName);
            this.pnlControl.Controls.Add(this.txtSearch);
            this.pnlControl.Controls.Add(this.btnMaximize);
            this.pnlControl.Controls.Add(this.btnMinimize);
            this.pnlControl.Controls.Add(this.btnCloseWindows);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(213, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(787, 35);
            this.pnlControl.TabIndex = 2;
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCountdown.Location = new System.Drawing.Point(448, 9);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(79, 22);
            this.lblCountdown.TabIndex = 4;
            this.lblCountdown.Text = "TimeCD";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(349, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 22);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "TimeNow";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(577, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(106, 23);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
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
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
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
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(197, 31);
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
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(708, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(667, 0);
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
            this.btnCloseWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindows.Image")));
            this.btnCloseWindows.Location = new System.Drawing.Point(752, 0);
            this.btnCloseWindows.Name = "btnCloseWindows";
            this.btnCloseWindows.Size = new System.Drawing.Size(35, 35);
            this.btnCloseWindows.TabIndex = 0;
            this.btnCloseWindows.UseVisualStyleBackColor = true;
            this.btnCloseWindows.Click += new System.EventHandler(this.btnCloseWindows_Click);
            this.btnCloseWindows.MouseLeave += new System.EventHandler(this.btnCloseWindows_MouseLeave);
            this.btnCloseWindows.MouseHover += new System.EventHandler(this.btnCloseWindows_MouseHover);
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
            this.pnlButton.Controls.Add(this.pnlSelectedButton);
            this.pnlButton.Controls.Add(this.pnlTimerControl);
            this.pnlButton.Controls.Add(this.btnInfo);
            this.pnlButton.Controls.Add(this.lblTextBLADE);
            this.pnlButton.Controls.Add(this.btnHome);
            this.pnlButton.Controls.Add(this.btnPlaylist);
            this.pnlButton.Controls.Add(this.AppMenu);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(213, 600);
            this.pnlButton.TabIndex = 3;
            // 
            // pnlSelectedButton
            // 
            this.pnlSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.pnlSelectedButton.ForeColor = System.Drawing.Color.White;
            this.pnlSelectedButton.Location = new System.Drawing.Point(0, 88);
            this.pnlSelectedButton.Name = "pnlSelectedButton";
            this.pnlSelectedButton.Size = new System.Drawing.Size(4, 45);
            this.pnlSelectedButton.TabIndex = 4;
            // 
            // pnlTimerControl
            // 
            this.pnlTimerControl.Controls.Add(this.panel3);
            this.pnlTimerControl.Controls.Add(this.btn10m);
            this.pnlTimerControl.Controls.Add(this.btn1h);
            this.pnlTimerControl.Controls.Add(this.btn30m);
            this.pnlTimerControl.Controls.Add(this.btnTimer);
            this.pnlTimerControl.Location = new System.Drawing.Point(12, 190);
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
            this.btnSetCustomTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
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
            this.txtSecond.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.txtSecond.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSecond.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
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
            this.txtMinute.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.txtMinute.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMinute.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
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
            this.txtHour.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.txtHour.LineIdleColor = System.Drawing.Color.Gray;
            this.txtHour.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
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
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(12, 241);
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
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playbackToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(34, 24);
            this.menuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.shuffleToolStripMenuItem,
            this.repeatToolStripMenuItem,
            this.volumeUpToolStripMenuItem,
            this.volumeDownToolStripMenuItem});
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.previousToolStripMenuItem_Click);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.repeatToolStripMenuItem.Text = "Repeat";
            this.repeatToolStripMenuItem.Click += new System.EventHandler(this.repeatToolStripMenuItem_Click);
            // 
            // volumeUpToolStripMenuItem
            // 
            this.volumeUpToolStripMenuItem.Name = "volumeUpToolStripMenuItem";
            this.volumeUpToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.volumeUpToolStripMenuItem.Text = "Volume up";
            // 
            // volumeDownToolStripMenuItem
            // 
            this.volumeDownToolStripMenuItem.Name = "volumeDownToolStripMenuItem";
            this.volumeDownToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.volumeDownToolStripMenuItem.Text = "Volume down";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // DropdownTime
            // 
            this.DropdownTime.Interval = 10;
            this.DropdownTime.Tick += new System.EventHandler(this.DropdownTime_Tick);
            // 
            // timerChangeColorBLADE
            // 
            this.timerChangeColorBLADE.Enabled = true;
            this.timerChangeColorBLADE.Interval = 3000;
            this.timerChangeColorBLADE.Tick += new System.EventHandler(this.timerChangeColorBLADE_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.uc_Home);
            this.pnlMain.Controls.Add(this.uc_Playlist);
            this.pnlMain.Controls.Add(this.uc_Info);
            this.pnlMain.Controls.Add(this.uc_Search);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(213, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(787, 565);
            this.pnlMain.TabIndex = 4;
            // 
            // uc_Home
            // 
            this.uc_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Home.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Home.Location = new System.Drawing.Point(0, 0);
            this.uc_Home.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Home.Name = "uc_Home";
            this.uc_Home.Size = new System.Drawing.Size(787, 565);
            this.uc_Home.TabIndex = 2;
            // 
            // uc_Playlist
            // 
            this.uc_Playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Playlist.ChoosingPlaylist = null;
            this.uc_Playlist.CurrentPlaylist = null;
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
            this.uc_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.uc_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_Search.ForeColor = System.Drawing.Color.Gainsboro;
            this.uc_Search.Location = new System.Drawing.Point(0, 0);
            this.uc_Search.Margin = new System.Windows.Forms.Padding(4);
            this.uc_Search.Name = "uc_Search";
            this.uc_Search.Size = new System.Drawing.Size(787, 565);
            this.uc_Search.TabIndex = 3;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
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
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlTimerControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.AppMenu.ResumeLayout(false);
            this.AppMenu.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMusicControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseWindows;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnPause;
        private Bunifu.UI.WinForms.BunifuHSlider sliderMusic;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnRepeatOff;
        private System.Windows.Forms.Button btnShuffleOff;
        private System.Windows.Forms.Button btnShuffle;
        private Bunifu.UI.WinForms.BunifuHSlider SliderVolume;
        private System.Windows.Forms.Panel pnlButton;
        private Bunifu.UI.WinForms.BunifuLabel lblTextBLADE;
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
        private ucHome uc_Home;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private ucSearch uc_Search;
        private stopTimer s_Timer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
        private System.Windows.Forms.Button btnVolumeOff;
        private System.Windows.Forms.Button btnVolume;
        private Bunifu.Framework.UI.BunifuCustomLabel lblArtistName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSongName;
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
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblCountdown;
    }
}

