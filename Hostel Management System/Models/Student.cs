using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Models
{
    internal class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private string nic;
        private string birthday;
        private string sex;
        private string contactNumber;
        private string email;
        private string grdFirstName;
        private string grdLastName;
        private string grdContactNumber;
        private string grdNIC;

        public int getId()
        {
            return id;
        }

        public void setId(int value)
        {
            id = value;
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

        public string getBirthday()
        {
            return birthday;
        }

        public void setBirthday(string value)
        {
            birthday = value;
        }

        public string getSex()
        {
            return sex;
        }

        public void setSex(string value)
        {
            sex = value;
        }

        public string getContactNumber()
        {
            return contactNumber;
        }

        public void setContactNumber(string value)
        {
            contactNumber = value;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string value)
        {
            email = value;
        }

        public string getGrdFirstName()
        {
            return grdFirstName;
        }

        public void setGrdFirstName(string value)
        {
            grdFirstName = value;
        }

        public string getGrdLastName()
        {
            return grdLastName;
        }

        public void setGrdLastName(string value)
        {
            grdLastName = value;
        }

        public string getGrdContactNumber()
        {
            return grdContactNumber;
        }

        public void setGrdContactNumber(string value)
        {
            grdContactNumber = value;
        }

        public string getGrdNIC()
        {
            return grdNIC;
        }

        public void setGrdNIC(string value)
        {
            grdNIC = value;
        }
    }
}
