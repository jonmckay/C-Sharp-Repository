using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_Seek_Chapter_7
{
    class OutsideWithHidingPlace : Outside, IHidingPlace 
    {
        private string hidingPlace;
        public string HidingPlace
        {
            get
            {
                return hidingPlace;
            }
        }

        public OutsideWithHidingPlace(string name, bool hot, string HidingPlace) : base (name, hot)
        {
            this.hidingPlace = HidingPlace;
        }

        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + hidingPlace + ".";
            }
        }
    }
}
