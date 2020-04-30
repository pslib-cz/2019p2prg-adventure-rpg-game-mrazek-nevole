using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Room
    {
        public string Description { get; set; }
        public string RoomName { get; set; }
        public int RoomNumber { get; set; }
        public Room(string description, string roomName, int roomNumber)
        {
            Description = description;
            RoomName = roomName;
            RoomNumber = roomNumber;
        }
    }
}
