using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_Seek_Chapter_7
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        private string hidingPlace;
        public string HidingPlace
        {
            get { return hidingPlace; }
        }

        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(decoration, name)
        {
            this.hidingPlace = hidingPlace;
        }


    }
}
