using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck_App_Chapter_8
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 0; value <= 13; value++)
                {
                    cards.Add(new Card((Card.suits)suit, (Card.values)value));
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Card> newDeck = new List<Card>();
            while(cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                newDeck.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = newDeck;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] cardArray = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                cardArray[i] = cards[i].Name;
            }
            return cardArray;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }

    }
}
