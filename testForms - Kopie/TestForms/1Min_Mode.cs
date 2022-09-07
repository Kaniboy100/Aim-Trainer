using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class _1Min_Mode : Form
    {
        public _1Min_Mode()
        {
            DoubleBuffered = true;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void _1Min_Mode_Load(object sender, EventArgs e)
        {

        }
    }
}
