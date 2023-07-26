using Hostel_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Forms
{
    public partial class SplashWindow : Form
    {
        public SplashWindow()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled=true;
            bunifuProgressBar1.Value = bunifuProgressBar1.Value + 1;
            if (bunifuProgressBar1.Value == 100)
            {
                timer.Enabled = false;
                new Login().Show();
                this.Hide();
            }
        }
    }
}
