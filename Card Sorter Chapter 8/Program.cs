using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Sorter_Chapter_8
{
    class Program
    {
        public static void printCardsList(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.WriteLine("Done Printing Cards!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Five random cards: ");
            Random random = new Random();
            List<Card> cards = new List<Card>()
            {
                new Card((Card.suits)random.Next(4),(Card.values)random.Next(1,14)),
                new Card((Card.suits)random.Next(4),(Card.values)random.Next(1,14)),
                new Card((Card.suits)random.Next(4),(Card.values)random.Next(1,14)),
                new Card((Card.suits)random.Next(4),(Card.values)random.Next(1,14)),
                new Card((Card.suits)random.Next(4),(Card.values)random.Next(1,14)),
            };

            cards.Sort(new CardComparer_byValue());
            printCardsList(cards);

            Console.ReadKey();
        }
    }
}
