using Hostel_Management_System.Assets;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Controllers
{
    internal class DeleteData
    {
        DataConnection db = new DataConnection();

        public bool DeleteRecord(string tableName, string idName, int id)
        {
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = $"DELETE FROM [dbo].[{tableName}] WHERE [{idName}] = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
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
