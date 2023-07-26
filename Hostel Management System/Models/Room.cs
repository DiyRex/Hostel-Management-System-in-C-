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

        public void setRoomCondition(string value)
        {
            if (value == "AC")
            {
                roomCondition = 1;
            }
            else if (value == "Non AC")
            {
                roomCondition= 0;
            }
            else
            {
                roomCondition = 0;
            }
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

        public void setOccupied(string value)
        {
            if (value == "Available")
            {
                occupied = 1;
            }
            else if (value == "Occupied")
            {
                occupied = 0;
            }
            else
            {
                occupied = 0;
            }
        }
    }

}
