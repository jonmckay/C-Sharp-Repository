using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird_Project_Chapter_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
            new Duck() { Kind = Duck.KindOfDuck.Mallard, Size = 17},
            new Duck() { Kind = Duck.KindOfDuck.Muscovy, Size = 18},
            new Duck() { Kind = Duck.KindOfDuck.Decoy, Size = 14},
            new Duck() { Kind = Duck.KindOfDuck.Muscovy, Size = 11},
            new Duck() { Kind = Duck.KindOfDuck.Mallard, Size = 14},
            new Duck() { Kind = Duck.KindOfDuck.Decoy, Size = 13},
        };

            IEnumerable<Bird> upcastDucks = ducks;


        }
    }
}
