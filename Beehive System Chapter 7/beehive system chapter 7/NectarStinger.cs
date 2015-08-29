using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_System_Chapter_7
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public int AlertLevel
        {
            get { return AlertLevel; }
        }

        public void WorkOneShift() {}
        public bool DoThisJob(string job, int shifts) { throw new NotImplementedException(); }
        public int ShiftsLeft { get { throw new NotImplementedException(); } }
        public string Job { get { throw new NotImplementedException(); } }

        private int stingerLength;
        public int StingerLength
        {
            get
            {
                return stingerLength;
            }

            set
            {
                stingerLength = value;
            }
        }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public int SharpenStinger(int length)
        {
            throw new NotImplementedException();
        }

        public void FindFlowers() { }
        public void GatherNectar() { }
        public void ReturnToHive() { }
    }
}
