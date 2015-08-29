using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdayAtTheRaces
{
   public class Greyhound
    {
        public int StartingPosition = 39; // Where my PictureBox starts
        public int RacetrackLength = 550; // How long the racetrack is
        public PictureBox MyPictureBox; // My PictureBox object
        public int Location = 0; // My Location on the racetrack
        public Random Randomizer; // An instance of Random
        public Boolean won = false;
        Point p;

        public bool Run()
         {
            Randomizer = new Random();
            
            p = MyPictureBox.Location;
            
                Location += Randomizer.Next(5);
                p.X = Location;
                MyPictureBox.Location = p;
            
            // Move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of my PictureBox on the form
            // Return true if I won the race

              //  System.Diagnostics.Debug.Write("My Picture box location: " + p.X + "\n");
                if (Location >= RacetrackLength)
                {
                    won = true;
                }
            

            return won;
        }

        public void TakeStartingPosition()
        {
            won = false;
            Location = StartingPosition;
            p = MyPictureBox.Location;
            p.X = Location;
            MyPictureBox.Location = p;
        }
    }
}
