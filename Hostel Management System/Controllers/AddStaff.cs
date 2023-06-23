using Hostel_Management_System.Assets;
using Hostel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Controllers
{
    internal class AddStaff
    {
        DataConnection db = new DataConnection();

        public bool Add_Staff(Staff Staff)
        {
            DataConnection db = new DataConnection();
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = @"INSERT INTO [dbo].[Staff] ([FirstName], [LastName], [Address], [NIC], [Contact], [Role]) 
                                VALUES (@FirstName, @LastName, @Address, @NIC, @Contact, @Role)";


                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", Staff.getFirstName());
                    command.Parameters.AddWithValue("@LastName", Staff.getLastName());
                    command.Parameters.AddWithValue("@Address", Staff.getAddress());
                    command.Parameters.AddWithValue("@NIC", Staff.getNIC());
                    command.Parameters.AddWithValue("@Contact", Staff.getContact());
                    command.Parameters.AddWithValue("@Role", Staff.getRole());


                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
