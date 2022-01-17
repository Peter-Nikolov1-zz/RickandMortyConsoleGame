using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty
{
    public class ProgramUI
    {
        public enum Item { plumbus, meeseeks, portalgun };

        public List<Item> inventory = new List<Item>();

        Dictionary<string, Room> Rooms = new Dictionary<string, Room>
        {
            {"garage", garage},
            {"house", house},
            {"driveway", driveway},
        };

        public static Room garage = new Room(
            "\n\n\n\n\nYou're in the garage with all your junk and crap.\n\n" + "Obvious exits are DRIVEWAY and HOUSE\n",
            new List<string> { "driveway", "house" },
            new List<Item> { Item.plumbus }
        );

        public static Room driveway = new Room(
            "\n\n\n\n\nYou're in the driveway. The car is gone but " + "the oil stain is still there.\n\n" + "Obvious exits are GARAGE and YARD\n",
            new List<string> { "garage" },
            new List<Item> { }
        );

        public static Room house = new Room(
            "\n\n\n\n\nYou're in the house now. It's drab and smells lkie " + "lemon pine-sole with a hint of stale fart.\n\n" + "Obvious exits are GARAGE and KITCHEN\n",
            new List<string> { "garage" },
            new List<Item> { }
        );

        public void Run()
        {
            Room currentRoom = garage;

            Console.Clear();
            Console.WriteLine("You accidentally killed Morty.\n" + "In order to construct a passable facsimile, you must collect" + "enough Mortys from other dimensions to assemble from them " + "Morty's genetic structure and connectome.");

            bool alive = true;
            while (alive)
            {
                Console.WriteLine(currentRoom.Splash);

                string command = Console.ReadLine().ToLower();
                Console.Clear();

                if (command.StartsWith("go ") || command.StartsWith("exit"))
                {
                    bool foundExit = false;
                    foreach (string exit in currentRoom.Exits)
                    {

                        if (command.Contains(exit) && Rooms.ContainsKey(exit))
                        {
                            currentRoom = Rooms[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if (!foundExit)
                    {
                        Console.WriteLine("uhh... Go where?");
                    }
                }
                else if (command.StartsWith("get ") || command.StartsWith("take ") || command.StartsWith("grab "))
                {
                    bool foundItem = false;
                    foreach (Item item in currentRoom.Items)
                    {
                        if (!foundItem && command.Contains(item.ToString()))
                        {
                            Random random = new Random();
                            int flavorTextChoices = random.Next(0, 3);
                            string flavorText;
                            switch (flavorTextChoices)
                            {
                                case 0:
                                    flavorText = "Don't break it.";
                                    break;
                                case 1:
                                    flavorText = "Good for you.";
                                    break;
                                case 2:
                                default:
                                    flavorText = "Greeeeeat.";
                                    break;
                            }
                            Console.WriteLine($"Congrats, you found a(n) {item}. {flavorText}");
                            currentRoom.RemoveItem(item);
                            inventory.Add(item);
                            foundItem = true;
                            Console.ReadKey();
                            break;
                        }
                    }
                    if (!foundItem)
                    {
                        Console.WriteLine("I don't know what you're talking about.");
                    }
                }
                else if (command.StartsWith("use ") || command.StartsWith("activate "))
                {
                    Console.WriteLine("I doubt you know how.");
                }
                else
                {
                    Console.WriteLine("*BUUUUUUURP* What?");
                }
            }
            Console.Clear();
        }
    }
}

