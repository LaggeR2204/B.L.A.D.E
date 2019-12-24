namespace BLADE
{
    partial class ucMusicCutter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMusicCutter));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTextTo = new System.Windows.Forms.Label();
            this.lblTextCut = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSongName = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGetStartTime = new System.Windows.Forms.Button();
            this.btnGetEndTime = new System.Windows.Forms.Button();
            this.pnlSetTime = new System.Windows.Forms.Panel();
            this.lblRealTime = new System.Windows.Forms.Label();
            this.txtEndSecond = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStartSecond = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEndMinute = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEndHour = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStartMinute = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStartHour = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.picboxChart = new System.Windows.Forms.PictureBox();
            this.pnlSetTime.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextTo
            // 
            this.lblTextTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTo.Location = new System.Drawing.Point(382, 153);
            this.lblTextTo.Name = "lblTextTo";
            this.lblTextTo.Size = new System.Drawing.Size(27, 21);
            this.lblTextTo.TabIndex = 1;
            this.lblTextTo.Text = "to";
            this.lblTextTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextCut
            // 
            this.lblTextCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextCut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextCut.Location = new System.Drawing.Point(334, 110);
            this.lblTextCut.Name = "lblTextCut";
            this.lblTextCut.Size = new System.Drawing.Size(117, 21);
            this.lblTextCut.TabIndex = 1;
            this.lblTextCut.Text = "Cut from, sec:";
            this.lblTextCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(40, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 40);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(80, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSongName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.Location = new System.Drawing.Point(0, 0);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(787, 40);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "SongName";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(40, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 4;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGetStartTime
            // 
            this.btnGetStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetStartTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetStartTime.BackgroundImage")));
            this.btnGetStartTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetStartTime.FlatAppearance.BorderSize = 0;
            this.btnGetStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStartTime.Location = new System.Drawing.Point(198, 147);
            this.btnGetStartTime.Name = "btnGetStartTime";
            this.btnGetStartTime.Size = new System.Drawing.Size(27, 27);
            this.btnGetStartTime.TabIndex = 6;
            this.btnGetStartTime.UseVisualStyleBackColor = true;
            this.btnGetStartTime.Click += new System.EventHandler(this.btnGetStartTime_Click);
            // 
            // btnGetEndTime
            // 
            this.btnGetEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetEndTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetEndTime.BackgroundImage")));
            this.btnGetEndTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetEndTime.FlatAppearance.BorderSize = 0;
            this.btnGetEndTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetEndTime.Location = new System.Drawing.Point(563, 147);
            this.btnGetEndTime.Name = "btnGetEndTime";
            this.btnGetEndTime.Size = new System.Drawing.Size(27, 27);
            this.btnGetEndTime.TabIndex = 7;
            this.btnGetEndTime.UseVisualStyleBackColor = true;
            this.btnGetEndTime.Click += new System.EventHandler(this.btnGetEndTime_Click);
            // 
            // pnlSetTime
            // 
            this.pnlSetTime.Controls.Add(this.lblRealTime);
            this.pnlSetTime.Controls.Add(this.txtEndSecond);
            this.pnlSetTime.Controls.Add(this.txtStartSecond);
            this.pnlSetTime.Controls.Add(this.txtEndMinute);
            this.pnlSetTime.Controls.Add(this.txtEndHour);
            this.pnlSetTime.Controls.Add(this.txtStartMinute);
            this.pnlSetTime.Controls.Add(this.txtStartHour);
            this.pnlSetTime.Controls.Add(this.pnlControls);
            this.pnlSetTime.Controls.Add(this.btnGetEndTime);
            this.pnlSetTime.Controls.Add(this.btnGetStartTime);
            this.pnlSetTime.Controls.Add(this.lblTextTo);
            this.pnlSetTime.Controls.Add(this.lblTextCut);
            this.pnlSetTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSetTime.Location = new System.Drawing.Point(0, 347);
            this.pnlSetTime.Name = "pnlSetTime";
            this.pnlSetTime.Size = new System.Drawing.Size(787, 218);
            this.pnlSetTime.TabIndex = 8;
            // 
            // lblRealTime
            // 
            this.lblRealTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRealTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealTime.Location = new System.Drawing.Point(358, 63);
            this.lblRealTime.Name = "lblRealTime";
            this.lblRealTime.Size = new System.Drawing.Size(72, 21);
            this.lblRealTime.TabIndex = 13;
            this.lblRealTime.Text = "00:00:00";
            this.lblRealTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEndSecond
            // 
            this.txtEndSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndSecond.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndSecond.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndSecond.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndSecond.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEndSecond.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndSecond.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndSecond.HintText = "S";
            this.txtEndSecond.isPassword = false;
            this.txtEndSecond.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEndSecond.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEndSecond.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEndSecond.LineThickness = 2;
            this.txtEndSecond.Location = new System.Drawing.Point(516, 144);
            this.txtEndSecond.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndSecond.MaxLength = 32767;
            this.txtEndSecond.Name = "txtEndSecond";
            this.txtEndSecond.Size = new System.Drawing.Size(40, 30);
            this.txtEndSecond.TabIndex = 10;
            this.txtEndSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndSecond.OnValueChanged += new System.EventHandler(this.txtEndTimeOnValueChanged);
            // 
            // txtStartSecond
            // 
            this.txtStartSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStartSecond.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStartSecond.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStartSecond.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStartSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartSecond.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStartSecond.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartSecond.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartSecond.HintText = "S";
            this.txtStartSecond.isPassword = false;
            this.txtStartSecond.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtStartSecond.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStartSecond.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtStartSecond.LineThickness = 2;
            this.txtStartSecond.Location = new System.Drawing.Point(328, 144);
            this.txtStartSecond.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartSecond.MaxLength = 32767;
            this.txtStartSecond.Name = "txtStartSecond";
            this.txtStartSecond.Size = new System.Drawing.Size(40, 30);
            this.txtStartSecond.TabIndex = 10;
            this.txtStartSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndMinute
            // 
            this.txtEndMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndMinute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndMinute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndMinute.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndMinute.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEndMinute.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndMinute.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndMinute.HintText = "M";
            this.txtEndMinute.isPassword = false;
            this.txtEndMinute.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEndMinute.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEndMinute.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEndMinute.LineThickness = 2;
            this.txtEndMinute.Location = new System.Drawing.Point(468, 144);
            this.txtEndMinute.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndMinute.MaxLength = 32767;
            this.txtEndMinute.Name = "txtEndMinute";
            this.txtEndMinute.Size = new System.Drawing.Size(40, 30);
            this.txtEndMinute.TabIndex = 11;
            this.txtEndMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndMinute.OnValueChanged += new System.EventHandler(this.txtEndTimeOnValueChanged);
            // 
            // txtEndHour
            // 
            this.txtEndHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEndHour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEndHour.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEndHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndHour.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEndHour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndHour.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndHour.HintText = "H";
            this.txtEndHour.isPassword = false;
            this.txtEndHour.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEndHour.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEndHour.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEndHour.LineThickness = 2;
            this.txtEndHour.Location = new System.Drawing.Point(420, 144);
            this.txtEndHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndHour.MaxLength = 32767;
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(40, 30);
            this.txtEndHour.TabIndex = 12;
            this.txtEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndHour.OnValueChanged += new System.EventHandler(this.txtEndTimeOnValueChanged);
            // 
            // txtStartMinute
            // 
            this.txtStartMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStartMinute.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStartMinute.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStartMinute.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStartMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartMinute.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStartMinute.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartMinute.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartMinute.HintText = "M";
            this.txtStartMinute.isPassword = false;
            this.txtStartMinute.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtStartMinute.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStartMinute.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtStartMinute.LineThickness = 2;
            this.txtStartMinute.Location = new System.Drawing.Point(280, 144);
            this.txtStartMinute.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartMinute.MaxLength = 32767;
            this.txtStartMinute.Name = "txtStartMinute";
            this.txtStartMinute.Size = new System.Drawing.Size(40, 30);
            this.txtStartMinute.TabIndex = 11;
            this.txtStartMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStartHour
            // 
            this.txtStartHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStartHour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStartHour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStartHour.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStartHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartHour.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStartHour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartHour.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartHour.HintText = "H";
            this.txtStartHour.isPassword = false;
            this.txtStartHour.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtStartHour.LineIdleColor = System.Drawing.Color.Gray;
            this.txtStartHour.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtStartHour.LineThickness = 2;
            this.txtStartHour.Location = new System.Drawing.Point(232, 144);
            this.txtStartHour.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartHour.MaxLength = 32767;
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(40, 30);
            this.txtStartHour.TabIndex = 12;
            this.txtStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnOpen);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Controls.Add(this.btnPlay);
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Location = new System.Drawing.Point(331, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(120, 40);
            this.pnlControls.TabIndex = 9;
            // 
            // picboxChart
            // 
            this.picboxChart.Location = new System.Drawing.Point(31, 86);
            this.picboxChart.Name = "picboxChart";
            this.picboxChart.Size = new System.Drawing.Size(728, 180);
            this.picboxChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxChart.TabIndex = 9;
            this.picboxChart.TabStop = false;
            // 
            // ucMusicCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.picboxChart);
            this.Controls.Add(this.pnlSetTime);
            this.Controls.Add(this.lblSongName);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ucMusicCutter";
            this.Size = new System.Drawing.Size(787, 565);
            this.SizeChanged += new System.EventHandler(this.ucMusicCutter_SizeChanged);
            this.pnlSetTime.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTextTo;
        private System.Windows.Forms.Label lblTextCut;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGetStartTime;
        private System.Windows.Forms.Button btnGetEndTime;
        private System.Windows.Forms.Panel pnlSetTime;
        private System.Windows.Forms.Panel pnlControls;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStartSecond;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStartMinute;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStartHour;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEndSecond;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEndMinute;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEndHour;
        private System.Windows.Forms.Label lblRealTime;
        private System.Windows.Forms.PictureBox picboxChart;
    }
}