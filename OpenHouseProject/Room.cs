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
        public static List<Room> ListOfRooms { get; set; } = new List<Room>();
        
        public string Name { get; set; }

        public string Descriptions { get; set; }

        public static bool RoomSelection(string response, int position, out int NewPosition)
        {
            if (response == ListOfRooms[position - 1].Name)
            {
                //response = Console.ReadLine();
                NewPosition = --position;
                return true;
            }
            else if (response == ListOfRooms[position + 1].Name)
            {
                //response = Console.ReadLine();
                NewPosition = ++position;
                return true;
                
            }
            else if (response == "Exit House")
            {
                NewPosition = position;
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect Response. Please Try Again");
                NewPosition = position;
                return false;
            }
        }
    }
}
