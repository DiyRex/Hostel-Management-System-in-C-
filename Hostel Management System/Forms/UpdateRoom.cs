using Hostel_Management_System.Controllers;
using Hostel_Management_System.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hostel_Management_System.Models;
using Hostel_Management_System.User_Controls;

namespace Hostel_Management_System.Forms
{
    public partial class UpdateRoom : Form
    {
        private string r_id = RoomsPanel.r_id;
        public UpdateRoom()
        {
            InitializeComponent();
        }

        private void UpdateRoom_Load(object sender, EventArgs e)
        {
            ReadData readData = new ReadData();
            DataTable dataTable = readData.ReadDataWithID("Rooms", "RoomId", r_id);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                
                string u_condition = dataTable.Rows[0]["RoomCondition"].ToString();
                string u_bedcount = dataTable.Rows[0]["BedCount"].ToString();
                string u_availability = dataTable.Rows[0]["Occupied"].ToString();

                if (u_condition == "1")
                {
                    condition.Text = "AC";
                }
                else
                {
                    condition.Text = "Non AC";
                }

                if (u_availability == "1")
                {
                    txtAvailability.Text = "Available";
                }
                else
                {
                    txtAvailability.Text = "Occupied";
                }

                bdCount.Text = u_bedcount;
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            string roomCondition = condition.Text;
            string bedCount = bdCount.Text;
            string availability = txtAvailability.Text;

            Room room = new Room();
            room.setRoomId(int.Parse(r_id));
            room.setRoomCondition(roomCondition);
            room.setBedCount(int.Parse(bedCount));
            room.setOccupied(availability);

            bool isValid = Validation.AreAnyStringsEmpty(roomCondition,bedCount);
            if (!isValid)
            {
                Controllers.UpdateRoom updateRoom = new Controllers.UpdateRoom();
                bool isUpdated = updateRoom.Update_Room(room);
                if (isUpdated)
                {
                    RoomsPanel.up_room = 1;
                    MessageBox.Show("Data Updated Successfully !");
                }
                else
                {
                    MessageBox.Show("Unable to Update");
                }
            }
            else
            {
                MessageBox.Show("Empty");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
