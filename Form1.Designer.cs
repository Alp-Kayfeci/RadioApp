namespace WindowsFormsApp7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevıousButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(12, 79);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(172, 56);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(190, 79);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(172, 56);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(190, 141);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(172, 56);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // prevıousButton
            // 
            this.prevıousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevıousButton.Location = new System.Drawing.Point(12, 141);
            this.prevıousButton.Name = "prevıousButton";
            this.prevıousButton.Size = new System.Drawing.Size(172, 56);
            this.prevıousButton.TabIndex = 3;
            this.prevıousButton.Text = "PREVIOUS";
            this.prevıousButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(350, 56);
            this.button5.TabIndex = 4;
            this.button5.Text = "SHUFFLE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(384, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 180);
            this.panel1.TabIndex = 9;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 16);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(350, 46);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(384, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 60);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 264);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.prevıousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevıousButton;
        private System.Windows.Forms.Button button5;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

