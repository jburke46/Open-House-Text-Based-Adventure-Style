using System;
using System.Linq;
namespace OpenHouseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Room Closet = new Room("Closet");
            Room.listOfRooms.Add(Closet);

            Room MasterBath = new Room("Master Bath");
            Room.listOfRooms.Add(MasterBath);

            Room MasterBedroom = new Room("Master Bedroom");
            Room.listOfRooms.Add(MasterBedroom);

            Room Hallway = new Room("Hallway");
            Room.listOfRooms.Add(Hallway);

            Room LivingRoom = new Room("LivingRoom");
            Room.listOfRooms.Add(LivingRoom);

            Room Kitchen = new Room("Kitchen");
            Kitchen.Descriptions = "It has granite countertops.";
            Room.listOfRooms.Add(Kitchen);

            Room LaundryRoom = new Room("Laundry Room");
            Room.listOfRooms.Add(LaundryRoom);

            Room Pantry = new Room("Pantry");
            Room.listOfRooms.Add(Pantry);


            Console.WriteLine("You find yourself outside of a house. It's a single story with red brick and 3 windows. You see a woman out front in a suit waving at you. She is saying somthing you can't quite hear yet. You approach and ask her to repeat herself. She replies \"Welcome to the open house. Would you like to take a flyer?\" (Type Take Flyer or Ignore to continue).");
            Console.WriteLine();
            string response = Console.ReadLine();
            int position = 4;
            if (response == "Take Flyer")
            {
                Console.WriteLine();
            }
            else if (response == "Ignore")
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
            
            while(true)
            {
                Console.WriteLine(Room.listOfRooms[position].Descriptions); 
                response = Console.ReadLine();
                while(Room.RoomSelection(response, position))
            }

            /*foreach ( Room element in Room.listOfRooms)
            {
                Console.WriteLine(element.Name);
                Console.WriteLine();

            }*/
            


        }

    }
}
