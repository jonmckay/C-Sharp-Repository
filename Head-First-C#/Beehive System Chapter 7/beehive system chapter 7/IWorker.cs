using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_System_Chapter_7
{
    interface IWorker
    {
        string Job { get; }
        int ShiftsLeft { get; }
        bool DoThisJob(string job, int shifts);
        void WorkOneShift();
    }
}
