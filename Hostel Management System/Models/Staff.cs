using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Models
{
    internal class Staff
    {
        private int staffId;
        private string firstName;
        private string lastName;
        private string address;
        private string nic;
        private string contact;
        private string role;

        public int getStaffId()
        {
            return staffId;
        }

        public void setStaffId(int value)
        {
            staffId = value;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string value)
        {
            firstName = value;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setLastName(string value)
        {
            lastName = value;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string value)
        {
            address = value;
        }

        public string getNIC()
        {
            return nic;
        }

        public void setNIC(string value)
        {
            nic = value;
        }

        public string getContact()
        {
            return contact;
        }

        public void setContact(string value)
        {
            contact = value;
        }

        public string getRole()
        {
            return role;
        }

        public void setRole(string value)
        {
            role = value;
        }
    }
}
