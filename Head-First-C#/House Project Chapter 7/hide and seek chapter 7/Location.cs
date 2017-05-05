using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_Seek_Chapter_7
{
    abstract class Location
    {
        private string name;    // The name of the location I.E. (Kitchen)
        public string Name
        {
            get { return name; }
        }

        public Location[] Exits;    // An array of Location objects that the current location connects to

        /// <summary>
        /// Constructor that takes a name of a location and sets to private property
        /// </summary>
        /// <param name="name"></param>
        public Location(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Get the description of which room you are located in and where the exits are.
        /// </summary>
        public virtual string Description
        {
            get
            {
                string description = "You're standing in the " + name + ". You see exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }
        }
    }
}
