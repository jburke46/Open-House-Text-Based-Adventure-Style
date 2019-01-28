using System;

namespace OpenHouseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You walk up to the house and see the realtor standing in front. She explains that this is a text based adventure open house so it's up to you to deceide what you want to do. She then asks if you would like a flyer about the house? (Type Take Flyer if you want to take it, otherwise just type Continue)");
            string flyerChoice = Console.ReadLine();
            if (flyerChoice == "Take Flyer")
            {
                Console.WriteLine("You take the flyer and walk into the house and in front of you you see the living room. To your right you see a hallway. Type Go (direction) to go in that direction.");
            }
            else if (flyerChoice == "Continue")
            {
                Console.WriteLine("You say no thanks as you walk into the house without a flyer. You start to wonder if that could have been useful since this is a text based adventure after all. While inside you see in front of you you see the living room. To your right you see a hallway. Type Go (direction) to go in that direction.");
            }
            else
            {
                Console.WriteLine("As you let out a warcry that would scare even the scariest of enemies, you run up and punch the realtor in the face knocking her out in one hit. You then calmly take a flyer and walk into the house.  While inside you see in front of you you see the living room. To your right you see a hallway. Type Go (direction) to go in that direction.");
            }
            string doorChoice = Console.ReadLine();
            while (doorChoice != "Leave")
            {
                if (doorChoice == "Go Left")
                {
                    Console.WriteLine("You walk to your left and enter the living room. There are 3 doors. One leads to what looks like a kitchen while the others look like they lead to a hallway and a Go (Room) to continue or type Go Back to go back to the door.");
                }
                else if (doorChoice == "Go Up")
                {
                    Console.WriteLine("You walk up the stairs and end up in a small room. To your left there are two doors next to each other and in front of you there is another door. All these doors seem to lead into bedrooms. (If you ould like to inspect the room type Inspect. To enter a bedroom type Enter Bedroom (number 1-3). To go back type Go Back");
                }
                doorChoice = Console.ReadLine();

            }
            if (doorChoice == "Leave")
            {
                Console.WriteLine("YOu quickly sprint out of the house probably because this was made very poorly.");
            }

            Room Kitchen = new Room("Kitchen");
            Kitchen.Descriptions.Add("It has granite countertops.");
            
            

        }

    }
}
