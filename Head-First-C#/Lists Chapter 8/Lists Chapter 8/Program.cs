using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Chapter_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe() { style = Shoe.Style.Sneakers, Color = "Black" });

            shoeCloset.Add(new Shoe() { style = Shoe.Style.Clogs, Color = "Brown" });

            shoeCloset.Add(new Shoe() { style = Shoe.Style.Wingtips, Color = "Black" });

            shoeCloset.Add(new Shoe() { style = Shoe.Style.Loafers, Color = "White" });

            shoeCloset.Add(new Shoe() { style = Shoe.Style.Loafers, Color = "Red" });

            shoeCloset.Add(new Shoe() { style = Shoe.Style.Sneakers, Color = "Green" });

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.style = Shoe.Style.Flipflops;
                shoe.Color = "Orange";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[3];
            Shoe secondShoe = shoeCloset[2];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if (shoeCloset.Contains(secondShoe))
            {
                Console.WriteLine("That's surprising.");
            }

        }
    }
}
