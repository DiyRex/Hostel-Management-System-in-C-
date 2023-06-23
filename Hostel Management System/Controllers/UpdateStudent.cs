using Hostel_Management_System.Assets;
using Hostel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Controllers
{
    internal class UpdateStudent
    {
        DataConnection db = new DataConnection();

        public bool Update_Student(Student student)
        {
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = @"UPDATE [dbo].[Students] 
                             SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [NIC] = @NIC, [Birthday] = @Birthday, [Sex] = @Sex,
                                 [ContactNumber] = @ContactNumber, [Email] = @Email, [GrdFirstName] = @GrdFirstName, [GrdLastName] = @GrdLastName,
                                 [GrdNIC] = @GrdNIC, [GrdContactNumber] = @GrdContactNumber
                             WHERE [Id] = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", student.getFirstName());
                    command.Parameters.AddWithValue("@LastName", student.getLastName());
                    command.Parameters.AddWithValue("@Address", student.getAddress());
                    command.Parameters.AddWithValue("@NIC", student.getNIC());
                    command.Parameters.AddWithValue("@Birthday", student.getBirthday());
                    command.Parameters.AddWithValue("@Sex", student.getSex());
                    command.Parameters.AddWithValue("@ContactNumber", student.getContactNumber());
                    command.Parameters.AddWithValue("@Email", student.getEmail());
                    command.Parameters.AddWithValue("@GrdFirstName", student.getGrdFirstName());
                    command.Parameters.AddWithValue("@GrdLastName", student.getGrdLastName());
                    command.Parameters.AddWithValue("@GrdNIC", student.getGrdNIC());
                    command.Parameters.AddWithValue("@GrdContactNumber", student.getGrdContactNumber());
                    command.Parameters.AddWithValue("@Id", student.getId());

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
