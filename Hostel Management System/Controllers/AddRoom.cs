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
    internal class AddRoom
    {
        DataConnection db = new DataConnection();

        public bool Add_Room(Room Room)
        {
            DataConnection db = new DataConnection();
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = @"INSERT INTO [dbo].[Rooms] ([RoomCondition], [BedCount], [Occupied]) 
                                VALUES (@RoomCondition, @BedCount, @Occupied)";


                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomCondition", Room.getRoomCondition());
                    command.Parameters.AddWithValue("@BedCount", Room.getBedCount());
                    command.Parameters.AddWithValue("@Occupied", Room.getOccupied());
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
