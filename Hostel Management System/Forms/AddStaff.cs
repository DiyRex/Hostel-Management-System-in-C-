using Hostel_Management_System.Assets;
using Hostel_Management_System.Models;
using Hostel_Management_System.User_Controls;
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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnaddStd_Click(object sender, EventArgs e)
        {
            string firstname = addfname.Text;
            string lastname = addlname.Text;
            string address = addaddress.Text;
            string nic = addnic.Text;
            string role = addrole.Text;
            string contact = addcontact.Text;

            bool isEmpty = Validation.AreAnyStringsEmpty(firstname,lastname,address,nic,role,contact);
            if(!isEmpty)
            {
                Staff staff = new Staff();
                staff.setFirstName(firstname);
                staff.setLastName(lastname);
                staff.setAddress(address);
                staff.setNIC(nic);
                staff.setRole(role);
                staff.setContact(contact);

                Controllers.AddStaff addStaff = new Controllers.AddStaff();
                bool isAdded = addStaff.Add_Staff(staff);
                if(isAdded)
                {
                    StaffPanel.add_staff = 1;
                    MessageBox.Show("Staff Added Successfully !");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                MessageBox.Show("All fields ae required");
            }
        }
    }
}
