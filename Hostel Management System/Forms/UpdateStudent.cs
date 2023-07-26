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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Forms
{
    public partial class UpdateStudent : Form
    {
        private string s_id = StudentsPanel.s_id;
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            ReadData readData = new ReadData();
            DataTable dataTable = readData.ReadDataWithID("Students", "Id", s_id);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                addfname.Text = dataTable.Rows[0]["FirstName"].ToString();
                addlname.Text = dataTable.Rows[0]["LastName"].ToString();
                addaddress.Text = dataTable.Rows[0]["Address"].ToString();
                addnic.Text = dataTable.Rows[0]["NIC"].ToString();
                addbirthday.Value = DateTime.Parse(dataTable.Rows[0]["Birthday"].ToString());
                addsex.Text = dataTable.Rows[0]["Sex"].ToString();
                addcontact.Text = dataTable.Rows[0]["ContactNumber"].ToString();
                addemail.Text = dataTable.Rows[0]["Email"].ToString();
                addgrdfname.Text = dataTable.Rows[0]["GrdFirstname"].ToString();
                addgrdlaname.Text = dataTable.Rows[0]["GrdLastname"].ToString();
                addgrdcontact.Text = dataTable.Rows[0]["GrdContactNumber"].ToString();
                addgrdnic.Text = dataTable.Rows[0]["GrdNIC"].ToString();;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string first_name = addfname.Text;
            string last_name = addlname.Text;
            string address = addaddress.Text;
            string nic = addnic.Text;
            string birthday = addbirthday.Value.ToString("MM/dd/yyyy");
            string sex = addsex.Text;
            string contact = addcontact.Text;
            string email = addemail.Text;
            string grd_first_name = addgrdfname.Text;
            string grd_last_name = addgrdlaname.Text;
            string grd_contact = addgrdcontact.Text;
            string grd_nic = addgrdnic.Text;


            Student student = new Student();
            student.setId(int.Parse(s_id));
            student.setFirstName(first_name);
            student.setLastName(last_name);
            student.setAddress(address);
            student.setNIC(nic);
            student.setBirthday(birthday);
            student.setSex(sex);
            student.setContactNumber(contact);
            student.setEmail(email);
            student.setGrdFirstName(grd_first_name);
            student.setGrdLastName(grd_last_name);
            student.setGrdContactNumber(grd_contact);
            student.setGrdNIC(grd_nic);

            bool isValid = Validation.AreAnyStringsEmpty(first_name, last_name, address, nic, birthday, sex, contact, email, grd_first_name, grd_last_name, grd_contact, grd_nic);
            if (!isValid)
            {
                Controllers.UpdateStudent upstd = new Controllers.UpdateStudent();
                bool isUpdated = upstd.Update_Student(student);
                if (isUpdated)
                {
                    StudentsPanel.up_sts = 1;
                    MessageBox.Show("Student Updated Successfully !");
                }
                else
                {
                    MessageBox.Show("Unable to Update");
                }
            }
            else
            {
                MessageBox.Show("All fields are required !");
            }
        }
    }
}
