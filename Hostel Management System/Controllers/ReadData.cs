﻿using Hostel_Management_System.Assets;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Controllers
{
    internal class ReadData
    {
        DataConnection db = new DataConnection();

        public DataTable ReadTableData(string tableName)
        {
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = $"SELECT * FROM [dbo].[{tableName}]";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception as per your requirement
                return null;
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}
