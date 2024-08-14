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

        private List<Radyo> radyoList;
        private int currentIndex = 0;
      
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_load(object sender, EventArgs e)
        {
            radyoList = Operations.getRadyoURL(); 
            if (radyoList == null || radyoList.Count == 0)
            {
                MessageBox.Show("Radyo listesi yüklenemedi.", "Hata");
                return;
            }

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

                yPosition += 55;


            }
        }

        private void PlayRadio(string radioName, string url)
        {
             
        axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            currentIndex = radyoList.FindIndex(r => r.RadyoUrl == url);
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

        private void stopButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void prevıousButton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                PlayRadio(radyoList[currentIndex].RadyoAdi, radyoList[currentIndex].RadyoUrl);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            currentIndex = random.Next(radyoList.Count);
            PlayRadio(radyoList[currentIndex].RadyoAdi, radyoList[currentIndex].RadyoUrl);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < radyoList.Count - 1)
            {
                currentIndex++;
                PlayRadio(radyoList[currentIndex].RadyoAdi, radyoList[currentIndex].RadyoUrl);
            }
        }
    }
}
