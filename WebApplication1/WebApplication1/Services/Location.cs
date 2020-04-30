using System;
using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class Location
    {
        public List<Room> Rooms { get; set; }
        public Location()
        {
            Rooms = new List<Room>();
            Rooms.Add(new Room("Vítej v první časti", "Začátek", 0));
            Rooms.Add(new Room("Vítej ve druhý časti", "2", 1));
            Rooms.Add(new Room("Vítej ve třetí časti", "3", 2));
            Rooms.Add(new Room("Vítej ve čtvrtý časti", "4", 3));
            Rooms.Add(new Room("Vítej v pátý časti", "5", 4));
        }

    }
}
