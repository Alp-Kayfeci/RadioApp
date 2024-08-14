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
        private Radyo currentRadyo;
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
                
                Application.Exit();
            }
            axWindowsMediaPlayer1.settings.volume = 20;

            RefreshButtons();
            MarqueeForm();
            setTimer();
        }

        private void RefreshButtons()
        {
            List<Radyo> list = Operations.getRadyoURL();
            int yPosition = 10;
            bool ilkYuklenmedeMevcutRadyoAtama = true;
            foreach (Radyo radyo in list) 
            {
                string radioName = radyo.RadyoAdi;
                string radioURL = radyo.RadyoUrl;

                if (ilkYuklenmedeMevcutRadyoAtama)
                {
                    currentRadyo = radyo;
                    ilkYuklenmedeMevcutRadyoAtama = false;
                }

                Button radioButton = new Button
                {
                    Text = radioName,
                    Width = 370,
                    Height = 30,
                    Top = yPosition,
                    Left = 10
                };

                radioButton.Click += (sender, e) => PlayRadio(radyo);

                panel1.Controls.Add(radioButton);

                yPosition += 55;


            }
        }

        private void PlayRadio(Radyo radyo)
        {
            label1.Text = radyo.RadyoAdi;
            axWindowsMediaPlayer1.URL = radyo.RadyoUrl;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            currentIndex = radyoList.FindIndex(r => r.RadyoUrl == radyo.RadyoUrl);
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            PlayRadio(currentRadyo);
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
                PlayRadio(radyoList[currentIndex]);
            }
            else
            {
                currentIndex = radyoList.Count - 1;
                PlayRadio(radyoList[currentIndex]); 
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            currentIndex = random.Next(radyoList.Count);
            PlayRadio(radyoList[currentIndex]);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < radyoList.Count - 1)
            {
                currentIndex++;
                PlayRadio(radyoList[currentIndex]);
            }
            else
            {
                currentIndex = 0;
                PlayRadio(radyoList[currentIndex]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
            
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Green;

        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Green;

        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.GreenYellow;
        }

        private void playButton_MouseDown(object sender, MouseEventArgs e)
        {
            playButton.BackColor = Color.DarkGreen;
        }

        private void playButton_MouseUp(object sender, MouseEventArgs e)
        {
            playButton.BackColor = Color.Green;
        }

        private void setTimer()
        {
            timer1.Interval = 1000 * 15 * 60;
            timer1.Start();
            this.MouseMove += awaySayacSifirla;
            this.KeyPress += awaySayacSifirla;
        }
        int awaySayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            awaySayac++;
            Console.WriteLine(awaySayac);
            if (awaySayac >= 2)
            {
                timer1.Stop();
                Console.WriteLine("UYGULAMA SONLANDIRILDI!");
            }

            axWindowsMediaPlayer1.Ctlcontrols.stop();
            MessageBox.Show("Premium üyelik almak ister misiniz?");
            
        }

        private void awaySayacSifirla(object sender, EventArgs e)
        {
            awaySayac = 0;

        }


    }
}
