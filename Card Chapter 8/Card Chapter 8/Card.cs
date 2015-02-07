using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Chapter_8
{
    class Card
    {
        public suits Suit;
        public values Value;

        public string Name { get { return this.Value + " of " + this.Suit; } }

        public enum suits
        {
            Spades = 0,
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
        }

        public enum values
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

        public Card(suits suit, values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
