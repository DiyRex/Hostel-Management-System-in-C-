using Hostel_Management_System.Controllers;
using Hostel_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lblLoggedUsr.Text = SessionManagement.getUserSession();
        }

        private void studentsPanel1_Load(object sender, EventArgs e)
        {

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.studentsPanel.Show();
            this.studentsPanel.BringToFront();
            this.roomsPanel.Hide();
            this.staffPanel.Hide();
            this.overiewPanel.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.roomsPanel.Show();
            this.roomsPanel.BringToFront();
            this.studentsPanel.Hide();
            this.staffPanel.Hide();
            this.overiewPanel.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.staffPanel.Show();
            this.staffPanel.BringToFront();
            this.studentsPanel.Hide();
            this.roomsPanel.Hide();
            this.overiewPanel.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.overiewPanel.Show();
            this.overiewPanel.BringToFront();
            this.studentsPanel.Hide();
            this.roomsPanel.Hide();
            this.staffPanel.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            SessionManagement.clearUserSession();
            this.Hide();
        }
    }
}
