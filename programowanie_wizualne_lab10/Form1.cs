using CommunityToolkit.Maui.Views;
using System.IO;
using System.Media;
using System.Text;
using System.Timers;
using WMPLib;

namespace programowanie_wizualne_lab10
{
    public partial class Form1 : Form
    {
        private List<string> songs;
        WindowsMediaPlayer player;
        private bool isPaused = false;
        private bool isPlaying = false;
        private double pausedPosition;
        string path;
        int indexOfSelectedSong = 0;
        int ms = 0;
        int m = 0;
        int s = 0;

        public Form1()
        {
            InitializeComponent();
            listView1.View = View.List;
            listView1.Clear();
            songs = new List<string>();

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "Audio (*.mp3,*wav)|*.mp3;*.wav";
                DialogResult answer = file.ShowDialog();
                path = file.FileName;
                if (answer == DialogResult.OK)
                {
                    foreach (var item in file.FileNames)
                    {
                        listView1.Items.Add(file.SafeFileName);
                        songs.Add(file.FileName);
                    }
                }
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (isPlaying == true)
            {
                player.controls.stop();
            }
            isPlaying = true;
            int ms = 0;
            int m = 0;
            int s = 0;
            indexOfSelectedSong = listView1.Items.IndexOf(listView1.SelectedItems[0]);

            timer1.Start();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(OnTimeEvent);

            var vFile = TagLib.File.Create(songs[indexOfSelectedSong]);
            double vDuration = vFile.Properties.Duration.TotalSeconds;
            label1.Text = TimeSpan.FromSeconds(vDuration).ToString(@"mm\:ss");

            player = new WMPLib.WindowsMediaPlayer();
            player.URL = songs[indexOfSelectedSong];
            player.controls.play();
            isPaused = false;

            progressBar1.Maximum = (int)vDuration;
            
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.controls.pause();
                isPaused = true;
                pausedPosition = player.controls.currentPosition;
                timer1.Stop();
            }
            else if (player.playState == WMPPlayState.wmppsPaused)
            {
                timer1.Start();
                player.controls.play();
                isPaused = false;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (isPlaying == true)
            {
                isPlaying = false;
                timer1.Stop();
                ms = 0;
                m = 0;
                s = 0;
                label1.Text = "00:00";
                labelTime.Text = "00:00";
                player.controls.stop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isPlaying == true)
            {
                progressBar1.Value = (int)player.controls.currentPosition;
            }
            
        }
        void OnTimeEvent(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                labelTime.Text = String.Format("{0}:{1}", m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'));
            }));
        }
    }
}