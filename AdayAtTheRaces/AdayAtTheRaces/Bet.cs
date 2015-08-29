using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdayAtTheRaces
{
    public class Bet
    {
        public int Amount; // The amount of cash that was bet
        public int Dog; // The number of the dog the bet is on
        public Guy Bettor; // The guy who placed the bet

        public string GetDescription()
        {
            string description = "";
            // Return a string that say who placed the bet, how much
            // cash was bet, and which dog he bet on ("Joe Bets 8 on
            // dog #4"). If the amount is zero, no bet was placed
            // ("Joe hasn't placed a bet").

            if (Amount == 0)
            {
                description = Bettor.Name + " hasn't placed a bet";
            }
            else
            {
                description = Bettor.Name + " Bets " + this.Amount + " on dog #" + this.Dog;
            }

            return description;
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
            // The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of
            // the amount bet.
           
        }
    }
}
