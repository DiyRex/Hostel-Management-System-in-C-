using Hostel_Management_System.Controllers;
using Hostel_Management_System.User_Controls;
using Hostel_Management_System.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hostel_Management_System.Forms
{
    public partial class UpdateStaff : Form
    {
        private string stf_id = StaffPanel.stf_id;
        public UpdateStaff()
        {
            InitializeComponent();
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            ReadData readData = new ReadData();
            DataTable dataTable = readData.ReadDataWithID("Staff", "StaffId", stf_id);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                addfname.Text = dataTable.Rows[0]["FirstName"].ToString();
                addlname.Text = dataTable.Rows[0]["LastName"].ToString();
                addaddress.Text = dataTable.Rows[0]["Address"].ToString();
                addnic.Text = dataTable.Rows[0]["NIC"].ToString();
                addcontact.Text = dataTable.Rows[0]["Contact"].ToString();
                addrole.Text = dataTable.Rows[0]["Role"].ToString();
            }
        }

        private void btnUpdateStd_Click(object sender, EventArgs e)
        {
            string first_name = addfname.Text;
            string last_name = addlname.Text;
            string address = addaddress.Text;
            string nic = addnic.Text;
            string role = addrole.Text;
            string contact = addcontact.Text;

            Staff staff = new Staff();
            staff.setStaffId(int.Parse(stf_id));
            staff.setFirstName(first_name);
            staff.setLastName(last_name);
            staff.setAddress(address);
            staff.setNIC(nic);
            staff.setRole(role);
            staff.setContact(contact);

            bool isValid = Validation.AreAnyStringsEmpty(first_name, last_name, address, nic, contact, role);
            if (!isValid)
            {
                Controllers.UpdateStaff upstf = new Controllers.UpdateStaff();
                bool isUpdated = upstf.Update_Staff(staff);
                if (isUpdated)
                {
                    StaffPanel.up_sts = 1;
                    MessageBox.Show("Student Updated Successfully !");
                }
                else
                {
                    MessageBox.Show("Unable to Update");
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void btnCancelStd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
