using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_System_Chapter_7
{
    class Bee : IStingPatrol
    {
        //private int alertLevel;
        public int AlertLevel { get {return AlertLevel;} }

        private int stingerLength;
        public int StingerLength { get { return stingerLength; } set { stingerLength = value; } }
        public string Job { get { throw new NotImplementedException(); } }
        public int ShiftsLeft { get { throw new NotImplementedException(); } }
        public bool DoThisJob(string job, int shifts) { throw new NotImplementedException(); }
        public void WorkOneShift() {}

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public int SharpenStinger(int Length)
        {
            throw new NotImplementedException();
        }
    }
}
