using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestForms;

namespace Aim_Trainer
{
    public partial class Startseite : Form
    {

        public Startseite()
        {
            DoubleBuffered = true;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }
        public static int click = 0;
        private void btnZahnrad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menue mu = new Menue();
            mu.ShowDialog();
            this.Close();
        }

        private void btnEndM_Click(object sender, EventArgs e)
        {
            click = 0;
            this.Hide();
            Endless_Mode em = new Endless_Mode(); 
            em.ShowDialog();
            this.Close();
        }
        private void btn20btn_Click(object sender, EventArgs e)
        {
            click = 2;
            this.Hide();
            Endless_Mode em = new Endless_Mode();
            em.ShowDialog();
            this.Close();
        }
        private void btn1min_Click(object sender, EventArgs e)
        {
            click = 1;
            this.Hide();
            Endless_Mode em = new Endless_Mode();
            em.ShowDialog();
            this.Close();
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }


    }
}
