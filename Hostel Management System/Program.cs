using Hostel_Management_System.Controllers;
using Hostel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainWindow());

            Staff staff = new Staff();
            staff.setStaffId(4);
            staff.setFirstName("Sam");
            staff.setLastName("Jonah");
            staff.setAddress("65/C NewYork");
            staff.setContact("2222222");
            staff.setNIC("654321");
            staff.setRole("Warden");

            UpdateStaff addStaff = new UpdateStaff();
            bool isadded = addStaff.Update_Staff(staff);
            if (isadded)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
