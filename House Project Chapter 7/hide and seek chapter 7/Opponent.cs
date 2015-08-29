using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_Seek_Chapter_7
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            this.myLocation = startingLocation;
            random = new Random();
        }

        public void Move()
        {
            // If in a room with a door
            if (myLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor LocationWithDoor = myLocation as IHasExteriorDoor;
                // Flip coin to decide whether or not to go through the door                
                // Go through door
                if (1 == random.Next(2))
                {
                    myLocation = LocationWithDoor.DoorLocation;                    
                }
            }
            bool hidden = false;
            while (!hidden)
            {
                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is IHidingPlace)
                {
                    hidden = true;
                }
            }
        }

        public bool Check(Location location)
        {
            if (location == this.myLocation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
