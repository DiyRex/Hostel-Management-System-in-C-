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
    internal class UpdateStaff
    {
        DataConnection db = new DataConnection();

        public bool Update_Staff(Staff Staff)
        {
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = @"UPDATE [dbo].[Staff] 
                         SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [NIC] = @NIC, [Contact] = @Contact, [Role] = @Role
                         WHERE [StaffId] = @StaffId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", Staff.getFirstName());
                    command.Parameters.AddWithValue("@LastName", Staff.getLastName());
                    command.Parameters.AddWithValue("@Address", Staff.getAddress());
                    command.Parameters.AddWithValue("@NIC", Staff.getNIC());
                    command.Parameters.AddWithValue("@Contact", Staff.getContact());
                    command.Parameters.AddWithValue("@Role", Staff.getRole());
                    command.Parameters.AddWithValue("@StaffId", Staff.getStaffId());

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
