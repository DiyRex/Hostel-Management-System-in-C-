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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnaddStd_Click(object sender, EventArgs e)
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
                Controllers.AddStudent addStd = new Controllers.AddStudent();
                bool isAdded = addStd.Add_Student(student);

                if (isAdded)
                {
                    StudentsPanel.add_sts = 1;
                    MessageBox.Show("Student Added");
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");

                }
            }
            else
            {
                MessageBox.Show("All fields are required !");
            }
        }
    }
}

