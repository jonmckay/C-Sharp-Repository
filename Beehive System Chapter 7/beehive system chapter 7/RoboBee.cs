using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_System_Chapter_7
{
    class RoboBee : Robot, IWorker
    {
        private int shiftsToWork;
        private int shiftsWorked;
        public int ShiftsLeft
        { get { return shiftsToWork - shiftsWorked; } }
        public string Job { get; private set; }
        public bool DoThisJob(string job, int shiftsToWork) { throw new NotImplementedException(); }
        public void WorkOneShift() { }
    }
}
