using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hostel_Management_System.Assets
{
    internal class DataConnection
    {
        private SqlConnection connection;
        private string connectionString;

        public DataConnection()
        {
            // Set your connection string here
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=.\Database\HostelDB.mdf;Integrated Security=True";
        }

        public SqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
