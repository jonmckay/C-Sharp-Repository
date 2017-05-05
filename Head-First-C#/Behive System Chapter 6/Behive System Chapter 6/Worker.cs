using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behive_System_Chapter_6
{
    class Worker
    {
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return (shiftsToWork - shiftsWorked);
            }
        }

        private int shiftsToWork = 0;   // Shifts left in the current job to work
        private int shiftsWorked = 0;   // Shifts the worker bee worked
        private string[] jobsICanDo;     // Jobs the current worker bee can do

        /// <summary>
        /// Worker bee constructor
        /// Set the jobs the worker bee can perform
        /// </summary>
        /// <param name="jobs"></param>
        public Worker(string[] jobs)
        {
            jobsICanDo = jobs;
        }

        /// <summary>
        /// Have the worker bee work one shift if he can
        /// </summary>
        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            shiftsToWork -= 1;
            shiftsWorked += 1;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Assign a job to a worker bee if he can do that job and is NOT
        /// already doing a job.
        /// </summary>
        /// <param name="jobToBePerformed"></param>
        /// <param name="numOfShifts"></param>
        /// <returns></returns>
        public bool DoThisJob(string jobToBePerformed, int numOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == jobToBePerformed)    // Worker can do that job
                {
                    this.currentJob = jobToBePerformed;   // Assign the current job to this worker if the job can be performed
                    this.shiftsToWork = numOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }
    }
}
