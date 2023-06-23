using Hostel_Management_System.Assets;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Controllers
{
    internal class ReadCount
    {
        
        public int getRowCount(string tableName)
        {
            DataConnection db = new DataConnection();
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = $"SELECT COUNT(*) FROM [dbo].[{tableName}]";

                using (var command = new SqlCommand(query, connection))
                {
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public int getRowCountWhere(string tableName, string columnName, string value)
        {
            DataConnection db = new DataConnection();
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = $"SELECT COUNT(*) FROM [dbo].[{tableName}] WHERE {columnName} = @value";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", value);

                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount;
                }
            }
            catch (Exception ex)
            {
                
                return -1;
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
