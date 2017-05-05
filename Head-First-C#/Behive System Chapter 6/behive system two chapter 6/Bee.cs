using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behive_System_Two_Chapter_6
{
    class Bee
    {
        public virtual int ShiftsLeft { get { return 0; } }
        private double beeWeight = 0;

        /// <summary>
        /// Bee constructor that takes in the bee's weight
        /// </summary>
        /// <param name="beeWeight"></param>
        public Bee(double beeWeight)
        {
            this.beeWeight = beeWeight;
        }

        /// <summary>
        /// Calculates the amount of honey that a bee uses
        /// </summary>
        /// <returns></returns>
        public virtual double GetHoneyConsumption()
        {
            double honeyConsumption = 0.0;  // How much honey this bee consumes

            // If bee is working, get honey consumption by adding 9 to the shifts left
            if (0 < ShiftsLeft)
            {
                honeyConsumption = ShiftsLeft + 9;
            }
            // If the bee doesn't have a job then it uses 7.5 units of honey
            else if (0 == ShiftsLeft)
            {
                honeyConsumption = 7.5;
            }

            // If the bee weighs over 150 milligrams, then that bee consumes 35% more honey
            if (this.beeWeight > 150)
            {
                honeyConsumption *= 1.35; 
            }

            return honeyConsumption;
        }
    }
}
