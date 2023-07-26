using Hostel_Management_System.Controllers;
using Hostel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.User_Controls
{
    public partial class RoomsPanel : UserControl
    {
        public static int add_room; //add_sts
        public static string r_id;
        public static int up_room; //up_sts
        private string room, stats;
        public RoomsPanel()
        {
            InitializeComponent();
        }
        public void addRooms()
        { 
            this.Grid.DataSource = null;
            this.Grid.Rows.Clear();

            ReadData readData = new ReadData();
            DataTable userData = readData.ReadTableData("Rooms");
            if (userData != null)
            {
                foreach (DataRow dr in userData.Rows)
                {
                    if (dr["RoomCondition"].ToString() == "1")
                    {
                        room = "AC";
                    }
                    else if (dr["RoomCondition"].ToString() == "0")
                    {
                        room = "Non AC";
                    }

                    if (dr["Occupied"].ToString() == "0")
                    {
                        stats = "Occupied";
                    }
                    else if (dr["Occupied"].ToString() == "1")
                    {
                        stats = "Available";
                    }

                    Grid.Rows.Add(dr["RoomId"], room, dr["BedCount"], stats);

                }
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            r_id = $"{Grid.CurrentRow.Cells[0].Value.ToString()}";
            if (r_id != null)
            {
                new Forms.UpdateRoom().ShowDialog();
                if (up_room == 1)
                {
                    addRooms();
                    add_room = 0;
                }
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            r_id = $"{Grid.CurrentRow.Cells[0].Value.ToString()}";
            if (r_id != null)
            {
                string tablename = "Rooms";
                string idname = "RoomId";
                if (r_id != null)
                {
                    bool isDeleted = new DeleteData().DeleteRecord(tablename, idname, int.Parse(r_id));
                    if (isDeleted)
                    {
                        MessageBox.Show("Room Record Deleted");
                        addRooms();
                    }
                    else
                    {
                        MessageBox.Show("Unable To Delete");
                    }
                }
            }
        }

        private void RoomsPanel_Load(object sender, EventArgs e)
        {
            addRooms();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            Forms.AddRoom addRoom = new Forms.AddRoom();
            addRoom.ShowDialog();
            if (add_room == 1)
            {
                addRooms();
                add_room = 0;
            }
        }
    }
}
