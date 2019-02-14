using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace OpenHouseProject

{
    class Room
    {
        public Room(string name)
        {
            Name = name;
        }
        public static List<Room> listOfRooms { get; set; } = new List<Room>();
        
        public string Name { get; set; }

        public List<string> Descriptions { get; set; } = new List<string>();

        public string RoomSelection { get; set; }


    }
}
