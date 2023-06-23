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
    internal class UpdateRoom
    {
        DataConnection db = new DataConnection();

        public bool Update_Room(Room Room)
        {
            SqlConnection connection = null;

            try
            {
                connection = db.getConnection();

                string query = @"UPDATE [dbo].[Rooms] 
                             SET [RoomCondition] = @RoomCondition, [BedCount] = @BedCount, [Occupied] = @Occupied 
                             WHERE [RoomId] = @RoomId";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomCondition", Room.getRoomCondition());
                    command.Parameters.AddWithValue("@BedCount", Room.getBedCount());
                    command.Parameters.AddWithValue("@Occupied",Room.getOccupied());
                    command.Parameters.AddWithValue("@RoomId", Room.getRoomId());

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
