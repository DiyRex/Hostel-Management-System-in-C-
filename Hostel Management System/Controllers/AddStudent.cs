using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hostel_Management_System.Assets;
using Hostel_Management_System.Models;

namespace Hostel_Management_System.Controllers
{
    internal class AddStudent
    {
        DataConnection db = new DataConnection();

        public bool Add_Student(Student Student)
        {
            DataConnection db = new DataConnection();
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = @"INSERT INTO [dbo].[Students] ([FirstName], [LastName], [Address], [NIC], [Birthday], [Sex], [ContactNumber], [Email], [GrdFirstName], [GrdLastName], [GrdNIC], [GrdContactNumber]) 
                VALUES (@FirstName, @LastName, @Address, @NIC, @Birthday, @Sex, @ContactNumber, @Email, @GrdFirstName, @GrdLastName, @GrdNIC, @GrdContactNumber)";


                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", Student.getFirstName());
                    command.Parameters.AddWithValue("@LastName", Student.getLastName());
                    command.Parameters.AddWithValue("@Address", Student.getAddress());
                    command.Parameters.AddWithValue("@NIC", Student.getNIC());
                    command.Parameters.AddWithValue("@Birthday", Student.getBirthday());
                    command.Parameters.AddWithValue("@Sex", Student.getSex());
                    command.Parameters.AddWithValue("@ContactNumber", Student.getContactNumber());
                    command.Parameters.AddWithValue("@Email", Student.getEmail());
                    command.Parameters.AddWithValue("@GrdFirstName", Student.getGrdFirstName());
                    command.Parameters.AddWithValue("@GrdLastName", Student.getGrdLastName());
                    command.Parameters.AddWithValue("@GrdNIC", Student.getGrdNIC());
                    command.Parameters.AddWithValue("@GrdContactNumber", Student.getGrdContactNumber());

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                db.closeConnection();
            }  
        }
    }
}
