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

        public string Descriptions { get; set; }

        public static bool RoomSelection(string response, int position)
        {
            if (response == Room.listOfRooms[position - 1].Name)
            {
                return true;
            }
            else if (response == Room.listOfRooms[position + 1].Name)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Response. Please Try Again");
                return false;
            }
        }
    }
}
