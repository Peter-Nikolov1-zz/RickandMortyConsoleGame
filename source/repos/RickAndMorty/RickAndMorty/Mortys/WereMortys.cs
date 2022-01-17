using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Mortys
{
    public class WerewolfMorty : IMortys
    {
        public int Health { get; set; } = 25;

        public void Scream()
        {
            Console.WriteLine("AAAAWWOOOOOOOOO");
        }

        public void Hurt(int damage)
        {
            Health -= damage;
        }

        public int Attack()
        {
            return 5;
        }
    }

    public class DrunkMorty : IMortys
    {
        public int Health { get; set; } = 15;

        public void Scream()
        {
            Console.WriteLine("Blleeeeeeeeehhh");
        }

        public void Hurt(int damage)
        {
            Health -= damage;
        }

        public int Attack()
        {
            return 1;
        }
    }
}
