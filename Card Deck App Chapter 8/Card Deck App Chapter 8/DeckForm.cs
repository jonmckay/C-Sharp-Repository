using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Deck_App_Chapter_8
{
    public partial class DeckForm : Form
    {
        Deck deck1;
        Deck deck2;
        Random random;

        public DeckForm()
        {
            InitializeComponent();
             random = new Random();
             ResetDeck(1);
             ResetDeck(2);
             RedrawDeck(1);
             RedrawDeck(2);
        }

        private void btnMoveToDeck2_Click(object sender, EventArgs e)
        {
            if (lbDeck1.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(lbDeck1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void btnMoveToDeck1_Click(object sender, EventArgs e)
        {
            if (lbDeck2.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                {
                    deck1.Add(deck2.Deal(lbDeck2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void btnShuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void btnShuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int numberOfCards = random.Next(1, 11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new Card((Card.suits)random.Next(4), (Card.values)random.Next(1,14)));
                }
                deck1.Sort();
            }
            if (deckNumber == 2)
            {
                deck2 = new Deck();
            }            
        }

        private void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                lbDeck1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    lbDeck1.Items.Add(cardName);
                }
                label1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                lbDeck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    lbDeck2.Items.Add(cardName);
                }
                label2.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }
    }
}
