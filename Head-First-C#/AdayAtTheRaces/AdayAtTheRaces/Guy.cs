using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdayAtTheRaces
{
    public class Guy
    {
        public string Name; // The guy's name
        public Bet MyBet = null; // An instance of Bet that has his bet
        public int Cash; // How much cash he has

        // The last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton; // My RadioButton
        public Label MyLabel; // My Label

        public void UpdateLabels()
        {
            if (MyBet == null)
            {
                MyBet = new Bet() { Bettor = this };
            }            
            this.MyLabel.Text = this.MyBet.GetDescription();
            // Set my label to my bet's description, and the label on my
            
            // radio button to show my cash ("Joe has 43 bucks")
            this.MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet() { this.MyBet.Amount = 0; } // Reset my bet so it's zero

        public bool PlaceBet(int Amount, int Dog)
        {
            
            // Place a new bet and store it in my bet field

            if (Amount > this.Cash)
            {
                return false;
            }
            else
            {
            // Return true if the guy had enough money to bet
                MyBet = new Bet() { Amount = Amount, Dog = Dog, Bettor = this };
                UpdateLabels();
                return true;
            }
            
        }

        public void Collect(int Winner) 
        {
            Cash = Cash + MyBet.PayOut(Winner);
        } // Ask my bet to pay out
    }
}
