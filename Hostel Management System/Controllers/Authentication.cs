using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hostel_Management_System.Assets;

namespace Hostel_Management_System.Controllers
{
    internal class Authentication
    {
        private DataConnection db;
        private string tableName = "users";

        public Authentication()
        {
            db = new DataConnection();
        }

        public bool isAuthenticate(string username, string password)
        {
            SqlConnection connection = db.getConnection();

            try
            {
                string query = $"SELECT * FROM {tableName} WHERE username = @Username AND password = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                bool loginSuccessful = reader.HasRows;

                reader.Close();

                return loginSuccessful;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
