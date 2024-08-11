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
        }

        private void Form1_load(object sender, EventArgs e)
        {
            RefreshButtons();
            MarqueeForm();
        }

        private void RefreshButtons()
        {
            List<Radyo> list = Operations.getRadyoURL();
            int yPosition = 10;
            foreach (Radyo radyo in list) 
            {
                string radioName = radyo.RadyoAdi;
                string radioURL = radyo.RadyoUrl;

                Button radioButton = new Button
                {
                    Text = radioName,
                    Width = 370,
                    Height = 30,
                    Top = yPosition,
                    Left = 10
                };

                radioButton.Click += (sender, e) => PlayRadio(radioName, radioURL);

                panel1.Controls.Add(radioButton);

                yPosition += 40;


            }
        }

        private void PlayRadio(string radioName, string url)
        {
            axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private Label marqueeLabel;
        private Timer timer;
        private int labelX;
        public void MarqueeForm()
        {

            marqueeLabel = new Label
            {
                Text = Operations.kayarYazi,
                AutoSize = true,
                Location = new System.Drawing.Point(-400 ,30),
            };

            panel2.Controls.Add(marqueeLabel);

            timer = new Timer
            {
                Interval = 50
            };

            timer.Tick += Timer_Tick;
            timer.Start();

            labelX = panel2.Width;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelX -= 5;
            marqueeLabel.Location = new System.Drawing.Point(labelX, marqueeLabel.Location.Y);

            if(labelX + marqueeLabel.Width < 0)
            {
                labelX = panel2.Width;
            }

        }

       
    }
}
