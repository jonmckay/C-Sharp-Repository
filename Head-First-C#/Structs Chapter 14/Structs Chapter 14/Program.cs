using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Chapter_14
{
    class Program
    {
        public struct Dog
        {
            public string Name;
            public string Breed;

            public Dog(string name, string breed)
            {
                this.Name = name;
                this.Breed = breed;
            }

            public void Speak()
            {
                Console.WriteLine("My name is {0} and I'm a {1}.", Name, Breed);
            }
        }

        static void Main(string[] args)
        {
            Canine spot = new Canine("Spot", "pug");
            Canine bob = spot;
            bob.Name = "spike";
            bob.Breed = "beagle";
            spot.Speak();

            Dog jake = new Dog("Jake", "poodle");
            Dog betty = jake;
            betty.Name = "Betty";
            betty.Breed = "pit bull";
            jake.Speak();

            Console.ReadKey();
        }
    }
}
