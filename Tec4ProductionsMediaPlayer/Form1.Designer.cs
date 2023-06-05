namespace Tec4ProductionsMediaPlayer
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnWalkIn = new System.Windows.Forms.Button();
            this.btnFirstDance = new System.Windows.Forms.Button();
            this.btnFatherDaughter = new System.Windows.Forms.Button();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblTrackStart = new System.Windows.Forms.Label();
            this.lblTrackEnd = new System.Windows.Forms.Label();
            this.lblCurrentSong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBlackOut = new System.Windows.Forms.Panel();
            this.btnGeneralPlaylist = new System.Windows.Forms.Button();
            this.wmpSoundBars = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpSongs = new AxWMPLib.AxWindowsMediaPlayer();
            this.customProgressBar1 = new Tec4ProductionsMediaPlayer.customProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(798, 458);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(146, 63);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(988, 458);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(146, 63);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(1182, 458);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(146, 63);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnWalkIn
            // 
            this.btnWalkIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWalkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalkIn.ForeColor = System.Drawing.Color.White;
            this.btnWalkIn.Location = new System.Drawing.Point(824, 562);
            this.btnWalkIn.Name = "btnWalkIn";
            this.btnWalkIn.Size = new System.Drawing.Size(203, 79);
            this.btnWalkIn.TabIndex = 3;
            this.btnWalkIn.Text = "Walk-In Song";
            this.btnWalkIn.UseVisualStyleBackColor = true;
            this.btnWalkIn.Click += new System.EventHandler(this.btnWalkIn_Click);
            // 
            // btnFirstDance
            // 
            this.btnFirstDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstDance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstDance.ForeColor = System.Drawing.Color.White;
            this.btnFirstDance.Location = new System.Drawing.Point(1058, 562);
            this.btnFirstDance.Name = "btnFirstDance";
            this.btnFirstDance.Size = new System.Drawing.Size(203, 79);
            this.btnFirstDance.TabIndex = 4;
            this.btnFirstDance.Text = "First Dance Song";
            this.btnFirstDance.UseVisualStyleBackColor = true;
            this.btnFirstDance.Click += new System.EventHandler(this.btnFirstDance_Click);
            // 
            // btnFatherDaughter
            // 
            this.btnFatherDaughter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFatherDaughter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatherDaughter.ForeColor = System.Drawing.Color.White;
            this.btnFatherDaughter.Location = new System.Drawing.Point(1292, 562);
            this.btnFatherDaughter.Name = "btnFatherDaughter";
            this.btnFatherDaughter.Size = new System.Drawing.Size(203, 79);
            this.btnFatherDaughter.TabIndex = 5;
            this.btnFatherDaughter.Text = "Father-Daughter Dance Song";
            this.btnFatherDaughter.UseVisualStyleBackColor = true;
            this.btnFatherDaughter.Click += new System.EventHandler(this.btnFatherDaughter_Click);
            // 
            // trackVolume
            // 
            this.trackVolume.BackColor = System.Drawing.Color.Black;
            this.trackVolume.Location = new System.Drawing.Point(900, 665);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(301, 45);
            this.trackVolume.TabIndex = 8;
            this.trackVolume.TickFrequency = 10;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVolume.Scroll += new System.EventHandler(this.VolumeBar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(816, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Volume";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Black;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(1217, 677);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(54, 20);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "100%";
            // 
            // lblTrackStart
            // 
            this.lblTrackStart.AutoSize = true;
            this.lblTrackStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackStart.ForeColor = System.Drawing.Color.White;
            this.lblTrackStart.Location = new System.Drawing.Point(800, 403);
            this.lblTrackStart.Name = "lblTrackStart";
            this.lblTrackStart.Size = new System.Drawing.Size(87, 31);
            this.lblTrackStart.TabIndex = 11;
            this.lblTrackStart.Text = "00:00";
            // 
            // lblTrackEnd
            // 
            this.lblTrackEnd.AutoSize = true;
            this.lblTrackEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackEnd.ForeColor = System.Drawing.Color.White;
            this.lblTrackEnd.Location = new System.Drawing.Point(1250, 403);
            this.lblTrackEnd.Name = "lblTrackEnd";
            this.lblTrackEnd.Size = new System.Drawing.Size(87, 31);
            this.lblTrackEnd.TabIndex = 12;
            this.lblTrackEnd.Text = "00:00";
            // 
            // lblCurrentSong
            // 
            this.lblCurrentSong.AutoSize = true;
            this.lblCurrentSong.BackColor = System.Drawing.Color.Black;
            this.lblCurrentSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSong.ForeColor = System.Drawing.Color.White;
            this.lblCurrentSong.Location = new System.Drawing.Point(793, 360);
            this.lblCurrentSong.Name = "lblCurrentSong";
            this.lblCurrentSong.Size = new System.Drawing.Size(267, 25);
            this.lblCurrentSong.TabIndex = 14;
            this.lblCurrentSong.Text = "No Song Currently Playing";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tec4ProductionsMediaPlayer.Properties.Resources.Tec4Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 152);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panelBlackOut
            // 
            this.panelBlackOut.Location = new System.Drawing.Point(266, 974);
            this.panelBlackOut.Name = "panelBlackOut";
            this.panelBlackOut.Size = new System.Drawing.Size(1521, 138);
            this.panelBlackOut.TabIndex = 16;
            // 
            // btnGeneralPlaylist
            // 
            this.btnGeneralPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnGeneralPlaylist.Location = new System.Drawing.Point(583, 562);
            this.btnGeneralPlaylist.Name = "btnGeneralPlaylist";
            this.btnGeneralPlaylist.Size = new System.Drawing.Size(203, 79);
            this.btnGeneralPlaylist.TabIndex = 18;
            this.btnGeneralPlaylist.Text = "General Playlist";
            this.btnGeneralPlaylist.UseVisualStyleBackColor = true;
            this.btnGeneralPlaylist.Click += new System.EventHandler(this.btnGeneralPlaylist_Click);
            // 
            // wmpSoundBars
            // 
            this.wmpSoundBars.Enabled = true;
            this.wmpSoundBars.Location = new System.Drawing.Point(447, 65);
            this.wmpSoundBars.Name = "wmpSoundBars";
            this.wmpSoundBars.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSoundBars.OcxState")));
            this.wmpSoundBars.Size = new System.Drawing.Size(1197, 1022);
            this.wmpSoundBars.TabIndex = 7;
            // 
            // wmpSongs
            // 
            this.wmpSongs.Enabled = true;
            this.wmpSongs.Location = new System.Drawing.Point(49, 103);
            this.wmpSongs.Name = "wmpSongs";
            this.wmpSongs.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSongs.OcxState")));
            this.wmpSongs.Size = new System.Drawing.Size(10, 10);
            this.wmpSongs.TabIndex = 13;
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.BackColor = System.Drawing.Color.White;
            this.customProgressBar1.ChannelColor = System.Drawing.Color.White;
            this.customProgressBar1.ChannelHeight = 10;
            this.customProgressBar1.ForeBackColor = System.Drawing.Color.Black;
            this.customProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.customProgressBar1.Location = new System.Drawing.Point(794, 388);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.ShowMaximun = false;
            this.customProgressBar1.ShowValue = Tec4ProductionsMediaPlayer.TextPosition.None;
            this.customProgressBar1.Size = new System.Drawing.Size(534, 12);
            this.customProgressBar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.customProgressBar1.SliderHeight = 15;
            this.customProgressBar1.SymbolAfter = "";
            this.customProgressBar1.SymbolBefore = "";
            this.customProgressBar1.TabIndex = 17;
            this.customProgressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customProgressBar1_MouseDown);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeneralPlaylist);
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.panelBlackOut);
            this.Controls.Add(this.lblCurrentSong);
            this.Controls.Add(this.lblTrackEnd);
            this.Controls.Add(this.lblTrackStart);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.btnFatherDaughter);
            this.Controls.Add(this.btnFirstDance);
            this.Controls.Add(this.btnWalkIn);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.wmpSoundBars);
            this.Controls.Add(this.wmpSongs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "MediaPlayer";
            this.Text = "MediaPlayer";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MediaPlayer_KeyDown);
            this.Resize += new System.EventHandler(this.MediaPlayer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSoundBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnWalkIn;
        private System.Windows.Forms.Button btnFirstDance;
        private System.Windows.Forms.Button btnFatherDaughter;
        private AxWMPLib.AxWindowsMediaPlayer wmpSoundBars;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblTrackStart;
        private System.Windows.Forms.Label lblTrackEnd;
        private AxWMPLib.AxWindowsMediaPlayer wmpSongs;
        private System.Windows.Forms.Label lblCurrentSong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBlackOut;
        private customProgressBar customProgressBar1;
        private System.Windows.Forms.Button btnGeneralPlaylist;
    }
}

