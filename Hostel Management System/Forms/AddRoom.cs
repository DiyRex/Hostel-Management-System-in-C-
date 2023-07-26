using Hostel_Management_System.Assets;
using Hostel_Management_System.Controllers;
using Hostel_Management_System.Models;
using Hostel_Management_System.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Forms
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void btnaddRoom_Click(object sender, EventArgs e)
        {
            string roomcond = condition.Text;
            string roombedcnd = bdCount.Text;
            string availability = txtAvailability.Text;
            bool isEmpty = Validation.AreAnyStringsEmpty(roomcond,roombedcnd,availability);
            if (!isEmpty)
            {
                Room room = new Room();
                room.setRoomCondition(roomcond);
                room.setBedCount(int.Parse(roombedcnd));
                room.setOccupied(availability);

                Controllers.AddRoom addRoom = new Controllers.AddRoom();
                bool isAdded = addRoom.Add_Room(room);


                if (isAdded)
                {
                    RoomsPanel.add_room = 1;
                    MessageBox.Show("Room Added Successfully !");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
            
        }
    }
}
