using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_Seek_Chapter_7
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        private Location doorLocation;
        public Location DoorLocation 
        {
            get { return doorLocation; }
            set { doorLocation = value; }
        }

        private string doorDescription;
        public string DoorDescription 
        {
            get { return doorDescription;} 
        }

        public RoomWithDoor(string name, string decoration, string doorDescription, string hidingPlace) : base(name, decoration, hidingPlace)
        {
            this.doorDescription = doorDescription;
        }
    }
}
