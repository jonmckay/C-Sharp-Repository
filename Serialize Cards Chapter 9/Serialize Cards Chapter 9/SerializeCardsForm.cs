using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialize_Cards_Chapter_9
{
    public partial class SerializeCardsForm : Form
    {
        Random random = new Random();

        public SerializeCardsForm()
        {
            InitializeComponent();
        }

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
            return myDeck;
        }

        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("----------------------");
        }

        private void btnSaveDeck_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);
            using (Stream output = File.Create("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, deckToWrite);
            }
            DealCards(deckToWrite, "What I just wrote to the file");
        }

        private void btnLoadDeck_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Deck deckFromFile = (Deck)bf.Deserialize(input);
                DealCards(deckFromFile, "What I read from the file");
            }
        }

        private void btnSaveDeck2_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i <= 5; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    bf.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, "Deck #" + i + " written");
                }
            }
        }

        private void btnLoadDeck2_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 0; i <= 5; i++)
                {
                    Deck deckToRead = (Deck)bf.Deserialize(input);
                    DealCards(deckToRead, "Deck #" + i + " read");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card threeOfClubs = new Card(Suits.Clubs,Values.Three);
            using (Stream output = File.Create("three-c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, threeOfClubs);
            }

            Card sixOfHearts = new Card(Suits.Hearts, Values.Six);
            using (Stream output = File.Create("six-h.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, sixOfHearts);
            }
        }

        private void btnCompareFiles_Click(object sender, EventArgs e)
        {
            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            firstFile[288] = (byte)Suits.Spades;
            firstFile[348] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);

            byte[] secondFile = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < firstFile.Length; i++)
            {
                if (firstFile[i] != secondFile[i])
                {
                    Console.WriteLine("Byte #{0}: {1} versus {2}", i, firstFile[i], secondFile[i]);
                }
            }


            using (Stream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Card kingOfSpades = (Card)bf.Deserialize(input);
                Console.WriteLine(kingOfSpades);
            }

            
        }

        private void btnHexDumper_Click(object sender, EventArgs e)
        {
            using(StreamReader reader = new StreamReader(@"c:\files\inputFile.txt"))
            using (StreamWriter writer = new StreamWriter(@"c:\files\outputFile.txt", false))
            {
                int position = 0;
                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", String.Format("{0:x4}", position));
                    position += charactersRead;

                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = String.Format("{0:x2}", (byte)buffer[i] );
                            writer.Write(hex + " ");
                        }
                        else
                        {
                            writer.Write("  ");
                        }

                        if (i == 7)
                        {
                            writer.Write("-- ");
                        }
                        if (buffer[i] < 32 || buffer[i] > 250)
                        {
                            buffer[i] = '.';
                        }
                    }

                    string bufferContents = new string(buffer);
                    writer.WriteLine("   " + bufferContents.Substring(0, charactersRead));
                }
            }
        }
    }
}
