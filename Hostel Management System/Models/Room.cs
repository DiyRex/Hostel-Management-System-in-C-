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
        private int roomCondition;
        private int bedCount;
        private int occupied;

        public int getRoomId()
        {
            return roomId;
        }

        public void setRoomId(int value)
        {
            roomId = value;
        }

        public int getRoomCondition()
        {
            return roomCondition;
        }

        public void setRoomCondition(int value)
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

        public int getOccupied()
        {
            return occupied;
        }

        public void setOccupied(int value)
        {
            occupied = value;
        }
    }

}
