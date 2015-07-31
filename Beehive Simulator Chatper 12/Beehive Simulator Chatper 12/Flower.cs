using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Simulator_Chapter_12
{
    [Serializable]
    class Flower
    {

        /*********************************
        * GLOBAL VARIABLES AND PROPERTIES
        *********************************/

        private const int LifeSpanMin = 15000;                  // The shortest flower lifespan
        private const int LifeSpanMax = 30000;                  // The longest flower lifespan
        private const double InitialNectar = 1.5;               // How much nectar a flower starts with
        private const double MaxNectar = 5.0;                        // How much nectar a flower can hold
        private const double NectarAddedPerTurn = 0.01;         // How much nectar gets added each time the flower grows older
        private const double NectarGatheredPerTurn = 0.3;       // How much nectar gets collected during a cycle

        public Point Location { get; private set; }
        public int Age { get; private set; }
        public bool Alive { get; private set; }
        public double Nectar { get; private set; }
        public double NectarHarvested { get; set; }

        private int lifespan;

        /******************************
        * CONSTRUCTORS
        ******************************/

        public Flower(Point flowerLocation, Random random)
        {
            this.Location = flowerLocation;
            this.Age = 0;
            this.Alive = true;
            this.Nectar = InitialNectar;
            this.NectarHarvested = 0;

            lifespan = random.Next(LifeSpanMin, LifeSpanMax + 1);
        }


        /******************************
        * FUNCTIONS
        ******************************/

        public double HarvestNectar()
        {
            if (NectarGatheredPerTurn > Nectar)
            {
                return 0;
            }
            else
            {
                Nectar -= NectarGatheredPerTurn;
                NectarHarvested += NectarGatheredPerTurn;
                return NectarGatheredPerTurn;
            }
        }

        public void Go()
        {
            Age++;
            if (Age > lifespan)
            {
                Alive = false;
            }
            else
            {
                Nectar += NectarAddedPerTurn;       // The amount of nectar each flower gets in a cycle
                if (Nectar > MaxNectar)
                {
                    Nectar = MaxNectar;
                }
            }
        }


    }
}
