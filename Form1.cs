using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
       
        
        public string[] radyoUrls = new string[]
    {
          "http://46.20.7.125/listen.pls",
            "http://provisioning.streamtheworld.com/pls/METRO_FMAAC.pls",
            "http://shoutcast.radyogrup.com:1010/;",
            "http://yayin.netradyom.com:8050/PARKFM/;",
            "http://37.247.98.17/;",
            "http://mega.netradyom.com:7900/;",
            "http://kralpopwmp.radyotvonline.com/"
    };

        private int currentIndex = 1;
        public AxWindowsMediaPlayer mediaPlayer;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            LoadCurrentRadyo();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCurrentRadyo();

        }

        private void LoadCurrentRadyo()
        {
            if (currentIndex >= 0 && currentIndex < radyoUrls.Length)
            {
                mediaPlayer.URL = radyoUrls[currentIndex];
                mediaPlayer.Ctlcontrols.play();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < radyoUrls.Length - 1)
            {
                currentIndex++;
                LoadCurrentRadyo();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                LoadCurrentRadyo();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.stop();
        }

        private void InitializeCustomComponents()
        {
          
            mediaPlayer = new AxWindowsMediaPlayer();
            mediaPlayer.CreateControl();
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.Size = new System.Drawing.Size(300, 45);
            mediaPlayer.Location = new System.Drawing.Point(12, 180);
            this.Controls.Add(mediaPlayer);

         
            Button playButton = new Button();
            playButton.Text = "Play";
            playButton.Location = new System.Drawing.Point(12, 230);
            playButton.Click += playButton_Click;
            this.Controls.Add(playButton);

            Button stopButton = new Button();
            stopButton.Text = "Stop";
            stopButton.Location = new System.Drawing.Point(100, 230);
            stopButton.Click += stopButton_Click;
            this.Controls.Add(stopButton);

          
            Button nextButton = new Button();
            nextButton.Text = "Next";
            nextButton.Location = new System.Drawing.Point(12, 270);
            nextButton.Click += nextButton_Click;
            this.Controls.Add(nextButton);

            Button previousButton = new Button();
            previousButton.Text = "Previous";
            previousButton.Location = new System.Drawing.Point(100, 270);
            previousButton.Click += previousButton_Click;
            this.Controls.Add(previousButton);
        }

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Mail { get; set; }
            public string Sifre { get; set; }
            public bool PremiumStatus { get; set; }
            public DateTime RegisterDate { get; set; }
        }

        public class Message
        {
            public int Id { get; set; }
            public int SenderId { get; set; }
            public int ReceiverId { get; set; }
            public string MessageContent { get; set; }
            public DateTime Date { get; set; }
            public bool Status { get; set; }
        }

   
        public class RadyoLog
        {
            public int Id { get; set; }
            public int RadyoId { get; set; }
            public int UserId { get; set; }
            public DateTime Date { get; set; }
        }

        public class LoginLog
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public DateTime Date { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
        }

       
    }
}
