﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overhauled_Beehive_Simulator_Chapter_12
{
    [Serializable]
    public class Hive
    {
        /*******************************************
        * FIELDS AND PROPERTIES
        *******************************************/
        private const int InitialBees = 6;
        private const double InitialHoney = 3.2;
        private const double MaximumHoney = 15.0;
        private const double NectarHoneyRatio = .25;
        private const double MinimumHoneyForCreatingBees = 4.0;
        private const int MaximumBees = 8;

        private Dictionary<string, Point> locations;
        private int beeCount;

        private World world;

        public double Honey { get; private set; }

        [NonSerialized]
        public BeeMessage MessageSender;

        /*******************************************
        * CONSTRUCTORS
        *******************************************/

        public Hive(World worldObj, BeeMessage MessageSender)
        {
            this.MessageSender = MessageSender;
            this.world = worldObj;
            Honey = InitialHoney;
            InitializeLocations();
            Random random = new Random();
            AddBee(random);
        }

        /*******************************************
        * FUNCTIONS
        *******************************************/

        private void InitializeLocations()
        {
            locations = new Dictionary<string, Point>();
            locations.Add("Entrance", new Point(590, 83));
            locations.Add("Nursery", new Point(212, 470));
            locations.Add("HoneyFactory", new Point(412, 242));
            locations.Add("Exit", new Point(430, 560));
        }

        public bool AddHoney(double nectar)
        {
            // First, we figure out how much honey this nectar can be converted to...
            double honeyToAdd = nectar * NectarHoneyRatio;

            // ...and then see if there's room in the hive for that much more honey
            if (honeyToAdd + Honey > MaximumHoney)
            {
                return false;
            }
            // If there's room, we add the honey to the hive
            Honey += honeyToAdd;
            return true;
        }

        public bool ConsumeHoney(double amount)
        {
            // If there's not enough honey in the hive to meet the demand, we return false;
            if (amount > Honey)
            {
                return false;
            }
            // If there's enough, remove it from the hive's stores and return true
            else
            {
                Honey -= amount;
                return true;
            }
        }

        private void AddBee(Random random)
        {
                beeCount++;

                // This creates a point within 50 units in both the X and Y direction from the nursery location
                int r1 = random.Next(100) - 50;
                int r2 = random.Next(100) - 50;
                Point startPoint = new Point(locations["Nursery"].X + r1, locations["Nursery"].Y + r2);

                Bee newBee = new Bee(beeCount, startPoint, this, world);
                newBee.MessageSender += this.MessageSender;
                // We add the new bee to the world's overall bee list
                world.Bees.Add(newBee);
        }

        public void Go(Random random)
        {
            // If there is enough honey to create a bee you have a 1 in 10 chance of creating a bee
            if (world.Bees.Count < MaximumBees && Honey > MinimumHoneyForCreatingBees && random.Next(10) == 1)
            {
                AddBee(random);
            }
        }

        public Point GetLocation(string location)
        {
            if (locations.ContainsKey(location))
            {
                return locations[location];
            }
            else
            {
                throw new ArgumentException("Unknown location: " + location);
            }
        }

    }
}
