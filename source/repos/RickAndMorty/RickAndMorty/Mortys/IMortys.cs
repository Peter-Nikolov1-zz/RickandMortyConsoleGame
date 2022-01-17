using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Mortys
{
    public interface IMortys
    {
        int Health { get; }
        void Scream();
        void Hurt(int damage);
        int Attack();
    }
}
