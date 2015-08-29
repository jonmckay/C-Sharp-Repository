using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_Seek_Chapter_7
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {

        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.doorDescription = doorDescription;
        }

        private Location doorLocation;
        public Location DoorLocation 
        { 
            get { return doorLocation;}
            set { doorLocation = value;} 
        }

        private string doorDescription;
        public string DoorDescription 
        { 
            get { return doorDescription; }
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + doorDescription + ".";
            }
        }
    }
}
