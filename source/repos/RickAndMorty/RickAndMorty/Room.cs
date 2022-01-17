using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty
{
    public class Room
    {
        public string Splash { get; set; }
        public List<string> Exits { get; set; }

        public Room(string splash, List<string> exits)
        {
            Splash = splash;
            Exits = exits;
        }
    }
}
