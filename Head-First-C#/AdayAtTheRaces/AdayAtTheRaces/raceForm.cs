using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdayAtTheRaces
{
    public partial class RaceForm : Form
    {
        public Greyhound[] dogsArray;
        public Guy[] guyArray;

        public RaceForm()
        {
            InitializeComponent();

            // Initialize the dog objects and array
            dogsArray = new Greyhound[4];
            dogsArray[0] = new Greyhound() {MyPictureBox = pbDog1, Location = pbDog1.Location.X, RacetrackLength = pictureBox1.Width};
            dogsArray[1] = new Greyhound() { MyPictureBox = pbDog2, Location = pbDog2.Location.X, RacetrackLength = pictureBox1.Width };
            dogsArray[2] = new Greyhound() { MyPictureBox = pbDog3, Location = pbDog3.Location.X, RacetrackLength = pictureBox1.Width };
            dogsArray[3] = new Greyhound() { MyPictureBox = pbDog4, Location = pbDog4.Location.X, RacetrackLength = pictureBox1.Width };

           // Initialize the guy objects and array
           guyArray = new Guy[3];
           guyArray[0] = new Guy() { Name = "Joe", MyLabel = lblJoesBet, Cash = 50, MyRadioButton = rbJoe};
           guyArray[1] = new Guy() { Name = "Bob", MyLabel = lblBobsBet, Cash = 75, MyRadioButton = rbBob};
           guyArray[2] = new Guy() { Name = "Al", MyLabel = lblAlsBet, Cash = 45, MyRadioButton = rbAl};

           // Update labels for the guys bets
           guyArray[0].UpdateLabels();
           guyArray[1].UpdateLabels();
           guyArray[2].UpdateLabels();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            
            int winningDog = 0;
            int winners = 0;

            while (winners == 0)
            {
                for (int i = 0; i < dogsArray.Length; i++)
                {
                    if (dogsArray[i].Run())
                    {
                        winners++;
                        winningDog = i + 1;                       
                    }                    
                    System.Threading.Thread.Sleep(3);
                }
            }
            MessageBox.Show("Dog number: " + winningDog + " Won");
            for (int k = 0; k < guyArray.Length; k++)
            {
                guyArray[k].Collect(winningDog);
                guyArray[k].ClearBet();
                guyArray[k].UpdateLabels();
            }

            for (int j = 0; j < dogsArray.Length; j++)
            {
                dogsArray[j].TakeStartingPosition();
            }
        }

        private void btnBets_Click(object sender, EventArgs e)
        {
            if (!(numericUpDown1.Value >= 5 && numericUpDown1.Value <= 15 && numericUpDown2.Value > 0 && numericUpDown2.Value < 5))
            {
                MessageBox.Show("Minimum bet value is $5, Maximum bet value is $15 and dog #'s are 1-4", "Minimum Bet");
            }
            else
            {
                if (lblBettor.Text == guyArray[0].Name)
                {
                    guyArray[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
                else if (lblBettor.Text == guyArray[1].Name)
                {
                    guyArray[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
                else
                {
                    guyArray[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                }
            }
        }

        private void rbJoe_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = guyArray[0].Name;
        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = guyArray[1].Name;
        }

        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            lblBettor.Text = guyArray[2].Name;
        } 
      
    }
}
