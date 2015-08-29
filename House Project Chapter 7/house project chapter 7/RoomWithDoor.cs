using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Project_Chapter_7
{
    class RoomWithDoor : Room, IHasExteriorDoor
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

        public RoomWithDoor(string name, string decoration, string doorDescription) : base(decoration, name)
        {
            this.doorDescription = doorDescription;
        }
    }
}
