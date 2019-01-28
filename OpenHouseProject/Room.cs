using System.Collections.Generic;

namespace OpenHouseProject

{
    class Room
    {
        public Room(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public List<string> Descriptions { get; set; } = new List<string>();

        public string RoomSelection { get; set; }

        public string ResponseFromBuyer { get; set; }
    }
}
