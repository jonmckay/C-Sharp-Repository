using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish_Chapter_8
{
    class Card
    {
        public Suits Suit;
        public Values Value;

        public string Name { get { return this.Value + " of " + this.Suit; } }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Plural(Values value)
        {
            if (value == Values.Six)
            {
                return "Sixes";
            }
            else
            {
                return value.ToString() + "s";
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
