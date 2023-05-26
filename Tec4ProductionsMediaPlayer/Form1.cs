using AxWMPLib;
using MediaPlayer;
using System;
using System.Drawing;
using System.IO;
using System.Net.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;


namespace Tec4ProductionsMediaPlayer
{
    public partial class MediaPlayer : Form
    {
        //create variables for directory paths of each folder and store the audio files in an array.

        //directory and array for the general playlist
        private static string directoryPathAllSongs = @"C:\Users\Bnguy\source\repos\Tec4ProductionsMediaPlayer\Tec4ProductionsMediaPlayer/Songs/General Playlist"; // Replace with your directory path
        private string[] audioFilesGeneralPlaylist = Directory.GetFiles(directoryPathAllSongs, "*.mp3"); // Get all MP3 files in the directory

        //directory and array for the Filler Music. This is for Simon to populate with enough music for the remaining duration depending on the pre-selected playlist.
        private static string directoryPathFillerMusic = @"C:\Users\Bnguy\source\repos\Tec4ProductionsMediaPlayer\Tec4ProductionsMediaPlayer/Songs/Filler Music"; // Replace with your directory path
        private string[] audioFilesFillerMusic = Directory.GetFiles(directoryPathFillerMusic, "*.mp3"); // Get all MP3 files in the directory

        //directory and array for the Walk in song
        private static string directoryPathWalkInSong = @"C:\Users\Bnguy\source\repos\Tec4ProductionsMediaPlayer\Tec4ProductionsMediaPlayer/Songs/Walk-In Song";
        private string[] audioFileWalkInSong = Directory.GetFiles(directoryPathWalkInSong, "*.mp3");

        //directory and array for the First Dance Song
        private static string directoryPathFirstDanceSong = @"C:\Users\Bnguy\source\repos\Tec4ProductionsMediaPlayer\Tec4ProductionsMediaPlayer/Songs/First Dance Song";
        private string[] audioFileFirstDanceSong = Directory.GetFiles(directoryPathFirstDanceSong, "*.mp3");

        //directory and array for the Father-daughter Dance Song
        private static string directoryPathFatherDaughter = @"C:\Users\Bnguy\source\repos\Tec4ProductionsMediaPlayer\Tec4ProductionsMediaPlayer/Songs/Father-Daughter Dance Song";
        private string[] audioFileFatherDaughter = Directory.GetFiles(directoryPathFatherDaughter, "*.mp3");

        int currentAudioIndex = 0; // Keep track of the current audio file being played
        int currentAudioIndexFillerMusic = 0; // Keep track of the current audio file being played

        //create rectangles for each button
        private Rectangle buttonPlayRectangle;
        private Rectangle buttonStopRectangle;
        private Rectangle buttonPauseRectangle;
        private Rectangle buttonGeneralPlaylistRectangle;
        private Rectangle buttonWalkInSongRectangle;
        private Rectangle buttonFirstDanceSongRectangle;
        private Rectangle buttonFatherDaughterDanceSongRectangle;
        private Rectangle progressBarRectangle;
        private Rectangle timerStartRectangle;
        private Rectangle timerEndRectangle;
        private Rectangle currentSongRectangle;
        private Rectangle wmpRectangle;
        private Rectangle volumeBarRectangle;
        private Rectangle volumeRectangle;
        private Rectangle volumePercentageRectangle;
        private Rectangle panelBlackOutRectangle;

        //rectangle for the original form's size
        private Rectangle originalFormSize;

        public MediaPlayer()
        {
            InitializeComponent();
            //set the default volume and text for the volume
            trackVolume.Value = 50;
            lblVolume.Text = "50%";

            // Starts the media player with the general playlist so the special songs are not accidentally played.
            if (currentAudioIndex < audioFilesGeneralPlaylist.Length)
            {

                wmpSongs.URL = audioFilesGeneralPlaylist[currentAudioIndex];
                string fileName = Path.GetFileName(audioFilesGeneralPlaylist[currentAudioIndex]); // Get the file name without the path
                fileName = fileNameRemove(fileName);
                lblCurrentSong.Text = fileName;

            }

            //automatically start the visual design background and loop the windows media player.
            wmpSoundBars.URL = @"C:\Users\Bnguy\source\repos\Tec4ProductionsMediaPlayer\Tec4ProductionsMediaPlayer\Songs\Visual\vecteezy_square-rectangle-picture-border-with-neon-line-footage_10366177_983.mp4";
            wmpSoundBars.settings.setMode("loop", true);

        }
        //method to remove ".mp3" from the file name
        public string fileNameRemove(string fileName)
        {
            //loops through the file name to find a period, once found it will delete the next 4 chars ".mp3"
            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i] == '.')
                {
                    fileName = fileName.Remove(i, 4);
                }
            }
            //returns the filename without ".mp3"
            return fileName;
        }
        //method to resize the buttons when the window is resized. Passes in a rectangle and control(button)
        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }


        //method for the Play button. Plays the current song.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpSongs.Ctlcontrols.play();
        }

        //method for the Stop button. Stops the current song.
        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpSongs.Ctlcontrols.stop();
        }
        //method for the Pause button. Pauses the current song.
        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpSongs.Ctlcontrols.pause();
        }
        //method to play the song in the Walk In Dance Song folder.
        private void btnWalkIn_Click(object sender, EventArgs e)
        {

            wmpSongs.URL = audioFileWalkInSong[0];
            string fileName = Path.GetFileName(audioFileWalkInSong[0]); // Get the file name without the path

            fileName = fileNameRemove(fileName);
            lblCurrentSong.Text = fileName;
            wmpSongs.Ctlcontrols.play();
        }
        //method to play the song in the First Dance Song folder.
        private void btnFirstDance_Click(object sender, EventArgs e)
        {
            wmpSongs.URL = audioFileFirstDanceSong[0];
            string fileName = Path.GetFileName(audioFileFirstDanceSong[0]); // Get the file name without the path

            fileName = fileNameRemove(fileName);
            lblCurrentSong.Text = fileName;
            wmpSongs.Ctlcontrols.play();
        }
        //method to play the song in the Father-daughter Dance Song folder.
        private void btnFatherDaughter_Click(object sender, EventArgs e)
        {
            wmpSongs.URL = audioFileFatherDaughter[0];
            string fileName = Path.GetFileName(audioFileFatherDaughter[0]); // Get the file name without the path

            fileName = fileNameRemove(fileName);
            lblCurrentSong.Text = fileName;
            wmpSongs.Ctlcontrols.play();
        }
        //method to adjust the volume as the user moves the volume bar
        private void VolumeBar(object sender, EventArgs e)
        {
            wmpSongs.settings.volume = trackVolume.Value;
            lblVolume.Text = trackVolume.Value.ToString() + "%";
        }
        //method to control the progress bar of the songs.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wmpSongs.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                customProgressBar1.Maximum = (int)wmpSongs.Ctlcontrols.currentItem.duration;
                customProgressBar1.Value = (int)wmpSongs.Ctlcontrols.currentPosition;

                try
                {
                    lblTrackStart.Text = wmpSongs.Ctlcontrols.currentPositionString;
                    lblTrackEnd.Text = wmpSongs.Ctlcontrols.currentItem.durationString.ToString();

                    // Conditions to make adjustments according to if the playlist is playing the General Playlist or the Filler Music playlist
                    if (currentAudioIndex < audioFilesGeneralPlaylist.Length)
                    {
                        if (customProgressBar1.Value == customProgressBar1.Maximum - 1 || customProgressBar1.Value == customProgressBar1.Maximum)
                        {
                            currentAudioIndex++;

                            wmpSongs.URL = audioFilesGeneralPlaylist[currentAudioIndex];
                            string fileName = Path.GetFileName(audioFilesGeneralPlaylist[currentAudioIndex]);

                            fileName = fileNameRemove(fileName);
                            lblCurrentSong.Text = fileName;

                            wmpSongs.Ctlcontrols.play();
                        }
                    }

                    if (currentAudioIndex >= audioFilesGeneralPlaylist.Length)
                    {
                        string fileName = Path.GetFileName(audioFilesFillerMusic[currentAudioIndexFillerMusic]);
                        fileName = fileNameRemove(fileName);
                        lblCurrentSong.Text = fileName;

                        if (customProgressBar1.Value == customProgressBar1.Maximum - 1)
                        {
                            currentAudioIndexFillerMusic++;
                            wmpSongs.URL = audioFilesFillerMusic[currentAudioIndexFillerMusic];
                            fileName = Path.GetFileName(audioFilesGeneralPlaylist[currentAudioIndexFillerMusic]);

                            fileName = fileNameRemove(fileName);
                            lblCurrentSong.Text = fileName;

                            wmpSongs.Ctlcontrols.play();
                        }
                    }

                }
                catch { }
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //sets the visual background to auto start
            wmpSoundBars.settings.autoStart = true;

            //declare the rectangles when the form loads
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonPlayRectangle = new Rectangle(btnPlay.Location.X, btnPlay.Location.Y, btnPlay.Width, btnPlay.Height);
            buttonStopRectangle = new Rectangle(btnStop.Location.X, btnStop.Location.Y, btnStop.Width, btnStop.Height);
            buttonPauseRectangle = new Rectangle(btnPause.Location.X, btnPause.Location.Y, btnPause.Width, btnPause.Height);
            buttonGeneralPlaylistRectangle = new Rectangle(btnGeneralPlaylist.Location.X, btnGeneralPlaylist.Location.Y, btnGeneralPlaylist.Width, btnGeneralPlaylist.Height);
            buttonWalkInSongRectangle = new Rectangle(btnWalkIn.Location.X, btnWalkIn.Location.Y, btnWalkIn.Width, btnWalkIn.Height);
            buttonFirstDanceSongRectangle = new Rectangle(btnFirstDance.Location.X, btnFirstDance.Location.Y, btnFirstDance.Width, btnFirstDance.Height);
            buttonFatherDaughterDanceSongRectangle = new Rectangle(btnFatherDaughter.Location.X, btnFatherDaughter.Location.Y, btnFatherDaughter.Width, btnFatherDaughter.Height);
            progressBarRectangle = new Rectangle(customProgressBar1.Location.X, customProgressBar1.Location.Y, customProgressBar1.Width, customProgressBar1.Height);
            timerStartRectangle = new Rectangle(lblTrackStart.Location.X, lblTrackStart.Location.Y, lblTrackStart.Width, lblTrackStart.Height);
            timerEndRectangle = new Rectangle(lblTrackEnd.Location.X, lblTrackEnd.Location.Y, lblTrackEnd.Width, lblTrackEnd.Height);
            currentSongRectangle = new Rectangle(lblCurrentSong.Location.X, lblCurrentSong.Location.Y, lblCurrentSong.Width, lblCurrentSong.Height);
            wmpRectangle = new Rectangle(wmpSoundBars.Location.X, wmpSoundBars.Location.Y, wmpSoundBars.Width, wmpSoundBars.Height);
            volumeBarRectangle = new Rectangle(trackVolume.Location.X, trackVolume.Location.Y, trackVolume.Width, trackVolume.Height);
            volumeRectangle = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            volumePercentageRectangle = new Rectangle(lblVolume.Location.X, lblVolume.Location.Y, lblVolume.Width, lblVolume.Height);
            panelBlackOutRectangle = new Rectangle(panelBlackOut.Location.X, panelBlackOut.Location.Y, panelBlackOut.Width, panelBlackOut.Height);

            //disables the visual background full screen so the users can't double click it.
            wmpSoundBars.Enabled = false;
        }

        //if the application is resized, adjusts each button accordingly.
        private void MediaPlayer_Resize(object sender, EventArgs e)
        {
            resizeControl(buttonPlayRectangle, btnPlay);
            resizeControl(buttonStopRectangle, btnStop);
            resizeControl(buttonPauseRectangle, btnPause);
            resizeControl(buttonGeneralPlaylistRectangle, btnGeneralPlaylist);
            resizeControl(buttonWalkInSongRectangle, btnWalkIn);
            resizeControl(buttonFirstDanceSongRectangle, btnFirstDance);
            resizeControl(buttonFatherDaughterDanceSongRectangle, btnFatherDaughter);
            resizeControl(progressBarRectangle, customProgressBar1);
            resizeControl(timerStartRectangle, lblTrackStart);
            resizeControl(timerEndRectangle, lblTrackEnd);
            resizeControl(currentSongRectangle, lblCurrentSong);
            resizeControl(wmpRectangle, wmpSoundBars);
            resizeControl(volumeBarRectangle, trackVolume);
            resizeControl(volumeRectangle, label1);
            resizeControl(volumePercentageRectangle, lblVolume);
            resizeControl(panelBlackOutRectangle, panelBlackOut);

        }
        //adjusts the song according to where the user clicks the progress bar.
        private void customProgressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            wmpSongs.Ctlcontrols.currentPosition = wmpSongs.currentMedia.duration * e.X / customProgressBar1.Width;
        }

        //plays the General Playlist music. If there are no songs left, plays the Filler Music playlist.
        private void btnGeneralPlaylist_Click(object sender, EventArgs e)
        {
            if (currentAudioIndex >= audioFilesGeneralPlaylist.Length)
            {

                wmpSongs.URL = audioFilesFillerMusic[currentAudioIndexFillerMusic];
                string fileName = Path.GetFileName(audioFilesFillerMusic[currentAudioIndexFillerMusic]); // Get the file name without the path

                fileName = fileNameRemove(fileName);
                lblCurrentSong.Text = fileName;
            }
            else
            {

                wmpSongs.URL = audioFilesGeneralPlaylist[currentAudioIndex];
                string fileName = Path.GetFileName(audioFilesGeneralPlaylist[currentAudioIndex]); // Get the file name without the path

                fileName = fileNameRemove(fileName);
                lblCurrentSong.Text = fileName;
            }
        }

        //method to control full screen mode. 
        //eliminates the task bar and window options.
        //clients will not be able to minimize the application, reducing user errors and security risks.
        private void MediaPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            // ESC key exits full screen
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            //F1 key enters full screen
            if (e.KeyCode == Keys.F1)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }

        }
    }
}
