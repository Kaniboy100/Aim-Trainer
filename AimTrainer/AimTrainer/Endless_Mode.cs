using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Timer = System.Threading.Timer;
using WMPLib;
using System.Media;
using Aim_Trainer;

namespace AimTrainer
{
    public partial class Endless_Mode : Form
    {
        public Endless_Mode()
        {
            DoubleBuffered = true;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        double missed;
        double score;
        int x;
        int y;
        int breite;
        int länge;
        double accuracy;
        int screenlength;
        int screenwitdh;
        int screenlengthabstand;
        int screenwithdabstand;
        string buttonclicked = "";
        int intbuttonclicked = 0;

        private String FormatTimeSpan(TimeSpan ts)
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime; 
        }
        private String GetElapsedTimeString()
        {
            return FormatTimeSpan(stopWatch.Elapsed);
        }
        private Stopwatch stopWatch = new Stopwatch();



        private void btnTarget_Click(object sender, EventArgs e)
        {
            intbuttonclicked++;

            SoundPlayer wmd = new SoundPlayer();
            wmd.SoundLocation = "hitmarkersound.wav";
            wmd.Play();

            stopWatch.Start();
            score++;
            this.btnTarget.Hide();
            this.lblHitmarker.Hide();

            Random rnd = new Random();
            x = rnd.Next(0, screenwitdh - screenlengthabstand);
            y = rnd.Next(0, screenlength - screenlengthabstand);
            btnTarget.Location = new Point(x, y);

            Random random = new Random();
            breite = random.Next(50, 150);
            länge = breite;

            this.btnTarget.Show();
            btnTarget.Size = new Size(breite, länge);
            string scoreString = Convert.ToString(score);
            lblscore.Text = "Score "+ scoreString;


            accuracy = Math.Round(score/ (missed + score)  * 100);
            string accuracyString = accuracy.ToString();
            lblAccuracy.Text = "Accuracy " + accuracyString + "%";
        }

        private void Endless_Mode_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\ccrosshair.cur");
            this.lblHitmarker.Hide();
            screenlength = Screen.PrimaryScreen.Bounds.Height;
            screenwitdh = Screen.PrimaryScreen.Bounds.Width;
            screenlengthabstand = screenlength / 10;
            screenwithdabstand = screenwitdh / 10;
        }

        private void Endless_Mode_Click(object sender, EventArgs e)
        {
            missed++;
            accuracy = Math.Round(score / (missed + score) * 100);
            string accuracyString = accuracy.ToString();
            lblAccuracy.Text = "Accuracy " + accuracy + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Startseite.click == 2)
            {
                lbltwenty.Text = buttonclicked.ToString();
                this.Text = "20 Button Mode";
                if (intbuttonclicked == 20)
                {
                    timer1.Stop();
                    MessageBox.Show("Timer " + GetElapsedTimeString() + "\nAccuracy " + accuracy + "%");
                    this.Hide();
                    Startseite ss = new Startseite();
                    ss.ShowDialog();
                    this.Close();
                }

            }
            if(Startseite.click == 1)
            {
                Char[] splitter = { '.' };
                string[] Min = GetElapsedTimeString().Split(splitter);
                this.Text = "1min Mode";
                if (Min[0] =="00:01:00")
                {
                   
                    timer1.Stop();
                    MessageBox.Show("Score" +score + "\nAccuracy " + accuracy + "%");
                    this.Hide();
                    Startseite ss = new Startseite();
                    ss.ShowDialog();
                    this.Close();
                }
            }
            lbltimer.Text ="Timer "+ GetElapsedTimeString();
            _ = stopWatch.Elapsed;
        }

        private void Endless_Mode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                DialogResult dlgResult = MessageBox.Show("Do you want to return?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dlgResult == DialogResult.Yes)
                {
                    this.Hide();
                    Startseite ss = new Startseite();
                    ss.ShowDialog();
                    this.Close();
                }
            }
        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }
    }
}
