using NAudio.Wave;
using pv = backbone.PublicVariables;
namespace backbone.MiscForms
{
    public partial class LoadingScreen : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;

        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Start();
            InitializeSoundPlayer();
        }

        bool done = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left > 800)
            {
                pictureBox1.Left = 100;
            }


            panel2.Width += 5;
            panel2.Height = 32;

            if (panel2.Width > 585)
            {
                panel2.Width = 585;
                timer1.Enabled = false;
                done = true;
            }

            if (done)
            {
                LoadMainForm();
            }
        }

        private void LoadMainForm()
        {
            WelcomeInterface1 form = new();
            form.Show();
            this.Hide();
        }

        private void InitializeSoundPlayer()
        {
            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader($"{pv.folderPath}music\\bg_music.wav"); // Set the correct path

            waveOut.Init(audioFile);
            waveOut.Volume = 1.0f;
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            waveOut.Play();
        }

        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // Reset the position to the beginning for looping
            audioFile.Position = 0;

            // Restart playback
            waveOut.Play();
        }

        private void LoadingScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the music and dispose of resources when the form is closed
            waveOut.Stop();
            waveOut.Dispose();
            audioFile.Dispose();
        }
    }
}
