using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Go_Fish_Chapter_8
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        /// <summary>
        /// The constructor for the Player class initializes four private fields, and then
        /// adds a line to the TextBox control on the form that say, "Joe has just
        /// joined the game" - but use the name in the private field, and don't forget to
        /// add a line break at the end of every line you add to the TextBox.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="random"></param>
        /// <param name="textBoxOnForm"></param>
        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.textBoxOnForm.Text += this.Name + " has just joined the game" + Environment.NewLine; 
        }

        /// <summary>
        /// This method gets a random value-but it has to be a value that's in the deck!
        /// </summary>
        /// <returns></returns>
        public Values GetRandomValue() 
        {
            int valueToGet = random.Next();
            //This is a test to see if github is working
        }

        /// <summary>
        /// This is where an opponent asks if I have any cards of a certain value
        /// Use Deck.PullOutValues() to pull out the values. Add a line to the TextBox
        /// that says, "Joe has 3 sixes" - use the new Card.Plural() static method
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Deck DoYouHaveAny(Values value)
        {
            if (cards.ContainsValue(value))
            {
                
            }
        }

        /// <summary>
        /// Here's an overloaded version of AskForACard() - choose a random value
        /// from the deck using GetRandomValue() and ask for it using AskForACard()
        /// </summary>
        /// <param name="players"></param>
        /// <param name="myIndex"></param>
        /// <param name="stock"></param>
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            
        }

        /// <summary>
        /// Ask the other players for a value. First add a line to the TextBox: "Joe asks
        /// if anyone has a Queen". Then go through the list of players that was passed in
        /// as a parmeter and ask each player if he has any of the value (using his
        /// DoYouHaveAny() method). He'll pass you a deck of cards - add them to my deck.
        /// Keep track of how many cards were added. If there weren't any, you'll need
        /// to deal yourself a card from the stock ( which was alaso passed as a parameter),
        /// and you'll have to add a line to the TextBox: "Joe had to draw from the stock"
        /// </summary>
        /// <param name="players"></param>
        /// <param name="myIndex"></param>
        /// <param name="stock"></param>
        /// <param name="value"></param>
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            
        }

        // Here's a property and a few short methods that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }


        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                    {
                        howMany++;
                    }
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                    {
                        cards.Deal(card);
                    }
                }
            }
            return books;
        }
    }
}
