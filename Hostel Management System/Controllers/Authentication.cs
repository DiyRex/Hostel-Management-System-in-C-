using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Hostel_Management_System.Assets;
using System.Windows.Forms;
using System.Data;

namespace Hostel_Management_System.Controllers
{
    internal class Authentication
    {
        private DataConnection db;
        private string tableName = "Admin";
        public static string AuthKey;

        public Authentication()
        {
            db = new DataConnection();
        }

        public static string getAuthKey()
        {
            
            ReadData readData = new ReadData();
            DataTable dataTable = readData.ReadDataWithID("Config", "ConfigId", "1");
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                AuthKey =  dataTable.Rows[0]["auth_key"].ToString();
            }
            return AuthKey;
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

                SessionManagement.setUserSession(username);

                return loginSuccessful;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public bool SignUp(string username, string password, string email)
        {
            DataConnection db = new DataConnection();
            SqlConnection connection = null;

            bool auth = isAuthenticate(username, password);
            if (!auth)
            {
                try
                {
                    connection = db.getConnection();

                    string query = @"INSERT INTO [dbo].[Admin] ([Username], [Password], [Email]) VALUES (@Username, @Password, @Email )";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    db.closeConnection();
                }
            }else
            {
                return false;
            }
        }
    }
}
