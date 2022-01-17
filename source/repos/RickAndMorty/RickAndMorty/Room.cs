using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMorty.ProgramUI;

namespace RickAndMorty
{
    public class Room
    {
        public string Splash { get; set; }

        public List<string> Exits { get; set; }

        public List<Item> Items { get; }

        public void RemoveItem(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        public Room(string splash, List<string> exits, List<Item> items)
        {
            Splash = splash;
            Exits = exits;
            Items = items;
        }
    }
}
