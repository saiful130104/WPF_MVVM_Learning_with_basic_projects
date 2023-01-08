using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveRoom.Models
{
   public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }
        public RoomID(int floorNumber, int roomNumber)
        {
            this.FloorNumber = floorNumber;
            this.RoomNumber = roomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }
        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        public override bool Equals(object obj)
        {
            return obj is RoomID roomID &&
                FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null)
            {
                return true;
            }

            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }
    }
}
