using Hostel_Management_System.Controllers;
using Hostel_Management_System.Forms;
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
    public partial class StaffPanel : UserControl
    {
        public static int add_staff;
        public static string stf_id;
        public static int up_sts;

        public StaffPanel()
        {
            InitializeComponent();
        }

        public void addstaff()
        {
            this.Grid.DataSource = null;
            this.Grid.Rows.Clear();

            ReadData readData = new ReadData();
            DataTable userData = readData.ReadTableData("Staff");
            if (userData != null)
            {
                foreach (DataRow dr in userData.Rows)
                {
                    Grid.Rows.Add(dr["StaffId"], dr["Role"], dr["FirstName"], dr["LastName"], dr["Address"], dr["NIC"], dr["Contact"]);
                }
            }
        }

        private void StaffPanel_Load(object sender, EventArgs e)
        {
            addstaff();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            Forms.AddStaff addStaff = new Forms.AddStaff();
            addStaff.ShowDialog();
            if (add_staff == 1)
            {
                addstaff();
                add_staff = 0;
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            stf_id = $"{Grid.CurrentRow.Cells[0].Value.ToString()}";
            if (stf_id != null)
            {
                new Forms.UpdateStaff().ShowDialog();
                if (up_sts == 1)
                {
                    addstaff();
                    up_sts = 0;
                }
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            stf_id = $"{Grid.CurrentRow.Cells[0].Value.ToString()}";
            if (stf_id != null)
            {
                string tablename = "Staff";
                string idname = "StaffId";
                if (stf_id != null)
                {
                    bool isDeleted = new DeleteData().DeleteRecord(tablename, idname, int.Parse(stf_id));
                    if (isDeleted)
                    {
                        MessageBox.Show("Room Record Deleted");
                        addstaff();
                    }
                    else
                    {
                        MessageBox.Show("Unable To Delete");
                    }
                }
            }
        }
    }
}
