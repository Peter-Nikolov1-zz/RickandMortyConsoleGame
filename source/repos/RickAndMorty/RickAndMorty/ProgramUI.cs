﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty
{
    public class ProgramUI 
    {
        public static Room garage = new Room(
            "\n\n\n\n\nYou're in the garage with all your junk and crap.\n\n" + "Obvious exits are DRIVEWAY and HOUSE\n",
            new List<string> { "driveway", "house" }
        );

        public static Room driveway = new Room(
            "\n\n\n\n\nYou're in the driveway. The car is gone but " + "the oil stain is still there.\n\n" + "Obvious exits are GARAGE and YARD\n",
            new List<string> { "garage"}
        );

        public static Room house = new Room(
            "\n\n\n\n\nYou're in the house now. It's drab and smells lie " + "lemon pine-sole with a hint of stale fart.\n\n" + "Obvious exits are GARAGE and KITCHEN\n",
            new List<string> { "garage" }
        );

    public void Run()
    {
            Room currentRoom = garage;

        Console.Clear();
        Console.WriteLine("You accidentally killed Morty.\n" + "In order to construct a passable facsimile, you must collect" + "enough Mortys from other dimensions to assemble from them " + "Morty's genetic structure and connectome.");

        bool alive = true;
        while (alive)
        {
            string command = Console.ReadLine().ToLower();
            Console.Clear();
            if (command.StartsWith("go ") || command.StartsWith("exit "))
            {
                    if (command.Contains("garage"))
                    {
                        currentRoom = garage;
                    }
                    else if (command.Contains("driveway"))
                    {
                        currentRoom = driveway;
                    }
                    else if (command.Contains("house"))
                    {
                        currentRoom = house;
                    }
                    else
                    {
                        Console.WriteLine("uhh... Go where?");
                    }
            }
            else if (command.StartsWith("get ") || command.StartsWith("take ") || command.StartsWith("grab "))
            {
                Console.WriteLine("I don't know what you're talking about.");
            }
            else if (command.StartsWith("use ") || command.StartsWith("activate "))
            {
                Console.WriteLine("I double you know how.");
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
