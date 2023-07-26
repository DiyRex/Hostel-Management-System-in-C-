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

namespace Hostel_Management_System.User_Controls
{
    public partial class OveriewPanel : UserControl
    {
        public OveriewPanel()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            new SendMail().ShowDialog();
        }

        private void OveriewPanel_Load(object sender, EventArgs e)
        {
            ReadCount readCount = new ReadCount();
            int stdCount = readCount.getRowCount("Students");
            int stfCount = readCount.getRowCount("Staff");
            int RoomTotal = readCount.getRowCount("Rooms");
            int RoomAvailable = readCount.getRowCountWhere("Rooms", "Occupied", "1");
            int RoomOccupied = readCount.getRowCountWhere("Rooms", "Occupied", "0");

            lblroomav.Text = RoomAvailable.ToString();
            lblstd.Text = stdCount.ToString();
            lblstaff.Text = stfCount.ToString();
            room_occupied.Text = RoomOccupied.ToString();
            room_total.Text = RoomTotal.ToString();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            new ConfigPanel().ShowDialog();
        }
    }
}
