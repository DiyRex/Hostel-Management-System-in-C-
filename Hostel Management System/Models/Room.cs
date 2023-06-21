using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Management_System.Models
{
    internal class Room
    {
        private int roomId;
        private string roomCondition;
        private int bedCount;
        private bool occupied;

        public int getroomId()
        {
            return roomId;
        }

        public void setRoomId(int value)
        {
            roomId = value;
        }

        public string getRoomCondition()
        {
            return roomCondition;
        }

        public void setRoomCondition(string value)
        {
            roomCondition = value;
        }

        public int getBedCount()
        {
            return bedCount;
        }

        public void setBedCount(int value)
        {
            bedCount = value;
        }

        public bool getOccupied()
        {
            return occupied;
        }

        public void setOccupied(bool value)
        {
            occupied = value;
        }
    }

}
