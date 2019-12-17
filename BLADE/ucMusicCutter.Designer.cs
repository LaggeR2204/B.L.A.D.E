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
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.lblTextTo = new System.Windows.Forms.Label();
            this.lblTextCut = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSongName = new System.Windows.Forms.Label();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGetStartTime = new System.Windows.Forms.Button();
            this.btnGetEndTime = new System.Windows.Forms.Button();
            this.pnlSetTime = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pnlSetTime.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimeStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTimeStart.Location = new System.Drawing.Point(214, 180);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(160, 27);
            this.txtTimeStart.TabIndex = 0;
            this.txtTimeStart.Text = "00:00:00";
            this.txtTimeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTimeEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTimeEnd.Location = new System.Drawing.Point(413, 181);
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(160, 27);
            this.txtTimeEnd.TabIndex = 0;
            this.txtTimeEnd.Text = "00:00:00";
            this.txtTimeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeEnd.TextChanged += new System.EventHandler(this.txtTimeEnd_TextChanged);
            // 
            // lblTextTo
            // 
            this.lblTextTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTo.Location = new System.Drawing.Point(380, 184);
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
            this.lblTextCut.Location = new System.Drawing.Point(334, 131);
            this.lblTextCut.Name = "lblTextCut";
            this.lblTextCut.Size = new System.Drawing.Size(117, 21);
            this.lblTextCut.TabIndex = 1;
            this.lblTextCut.Text = "Cut from, sec:";
            this.lblTextCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(374, 3);
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
            this.btnOpen.Location = new System.Drawing.Point(328, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 40);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(420, 3);
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
            // waveViewer1
            // 
            this.waveViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.waveViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.waveViewer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.waveViewer1.Location = new System.Drawing.Point(56, 98);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(672, 189);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 3;
            this.waveViewer1.WaveStream = null;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(374, 3);
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
            this.btnGetStartTime.Location = new System.Drawing.Point(181, 181);
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
            this.btnGetEndTime.Location = new System.Drawing.Point(580, 180);
            this.btnGetEndTime.Name = "btnGetEndTime";
            this.btnGetEndTime.Size = new System.Drawing.Size(27, 27);
            this.btnGetEndTime.TabIndex = 7;
            this.btnGetEndTime.UseVisualStyleBackColor = true;
            this.btnGetEndTime.Click += new System.EventHandler(this.btnGetEndTime_Click);
            // 
            // pnlSetTime
            // 
            this.pnlSetTime.Controls.Add(this.pnlControls);
            this.pnlSetTime.Controls.Add(this.txtTimeStart);
            this.pnlSetTime.Controls.Add(this.btnGetEndTime);
            this.pnlSetTime.Controls.Add(this.btnGetStartTime);
            this.pnlSetTime.Controls.Add(this.lblTextTo);
            this.pnlSetTime.Controls.Add(this.lblTextCut);
            this.pnlSetTime.Controls.Add(this.txtTimeEnd);
            this.pnlSetTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSetTime.Location = new System.Drawing.Point(0, 347);
            this.pnlSetTime.Name = "pnlSetTime";
            this.pnlSetTime.Size = new System.Drawing.Size(787, 218);
            this.pnlSetTime.TabIndex = 8;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnOpen);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Controls.Add(this.btnPlay);
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(787, 46);
            this.pnlControls.TabIndex = 9;
            // 
            // ucMusicCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.pnlSetTime);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.lblSongName);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ucMusicCutter";
            this.Size = new System.Drawing.Size(787, 565);
            this.pnlSetTime.ResumeLayout(false);
            this.pnlSetTime.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.Label lblTextTo;
        private System.Windows.Forms.Label lblTextCut;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSongName;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGetStartTime;
        private System.Windows.Forms.Button btnGetEndTime;
        private System.Windows.Forms.Panel pnlSetTime;
        private System.Windows.Forms.Panel pnlControls;
    }
}