using System;
using System.Linq;
using System.Threading;
namespace OpenHouseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 20);
            Console.BufferWidth = 100;
            
            Room Closet = new Room("Closet");
            Closet.Descriptions = "Master Closet Fill In";
            Room.ListOfRooms.Add(Closet);

            Room MasterBath = new Room("Master Bath");
            MasterBath.Descriptions = "Master Bath Fill In";
            Room.ListOfRooms.Add(MasterBath);

            Room MasterBedroom = new Room("Master Bedroom");
            MasterBedroom.Descriptions = "Master Bedroom Fill In";
            Room.ListOfRooms.Add(MasterBedroom);

            Room Hallway = new Room("Hallway");
            Hallway.Descriptions = "Hallway Fill In";
            Room.ListOfRooms.Add(Hallway);

            Room LivingRoom = new Room("LivingRoom");
            LivingRoom.Descriptions = "Living Room Fill In";
            Room.ListOfRooms.Add(LivingRoom);

            Room Kitchen = new Room("Kitchen");
            Kitchen.Descriptions = "It has granite countertops.";
            Room.ListOfRooms.Add(Kitchen);

            Room LaundryRoom = new Room("Laundry Room");
            LaundryRoom.Descriptions = "Laundry Room Fill In";
            Room.ListOfRooms.Add(LaundryRoom);

            Room Pantry = new Room("Pantry");
            Pantry.Descriptions = "Pantry Fill In";
            Room.ListOfRooms.Add(Pantry);


            HelperMethods.Type("You find yourself outside of a house. It's a single story with red brick and 3 windows. \nYou see a woman out front in a suit waving at you. She is saying somthing you can't quite hear yet. You approach and ask her to repeat herself.\n She replies \"Welcome to the open house. Would you like to take a flyer?\" \n (Type Take Flyer or Ignore to continue).");
            Console.WriteLine();
            string response = Console.ReadLine();
        
            
            if (response == "Take Flyer")
            {
                Console.WriteLine("Option A");
            }
            else if (response == "Ignore")
            {
                Console.WriteLine("Option B");
            }
            else
            {
                Console.WriteLine("Option C");
            }
            int NewPosition = 0;
            int position = 4;
            bool exited = false;
            while (exited == false)
            {
                
                Console.WriteLine(Room.ListOfRooms[position].Descriptions);
                response = Console.ReadLine();
                while (Room.RoomSelection(response, position, out NewPosition) == false)
                {
                    response = Console.ReadLine();
                    
                }
                if (response == "Exit House")
                {
                    exited = true;
                    break;
                }
                position = NewPosition;    
            }

            /*foreach ( Room element in Room.listOfRooms)
            {
                Console.WriteLine(element.Name);
                Console.WriteLine();

            }*/
            


        }

    }
}
