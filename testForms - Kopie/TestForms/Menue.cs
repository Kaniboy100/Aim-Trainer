using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aim_Trainer
{
    public partial class Menue : Form
    {
        public Menue()
        {
            DoubleBuffered = true;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; 
            InitializeComponent();
        }

        private void btnRe1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Startseite f1 = new Startseite();
            f1.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }
    }
}
