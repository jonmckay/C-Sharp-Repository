using System;
using System.Drawing;

namespace Beehive_Simulator_Chapter_12
{
    class Bee
    {
        /*********************************
        * FIELDS AND PROPERTIES
        *********************************/

        private const double HoneyConsumed = 0.5;
        private const int MoveRate = 3;
        private const double MinimumFlowerNectar = 1.5;
        private const int CareerSpan = 1000;

        public int Age { get; private set; }
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }

        private Point location;
        public Point Location { get { return location; } }

        private int ID;
        private Flower destinationFlower;

        private World world;
        private Hive hive;

        public BeeState CurrentState { get; private set; }

        public BeeMessage MessageSender;

        /*********************************
        * CONSTRUCTORS
        *********************************/

        public Bee(int id, Point location, Hive hive, World world)
        {
            this.ID = id;
            Age = 0;
            this.location = location;
            InsideHive = true;
            destinationFlower = null;
            NectarCollected = 0;
            CurrentState = BeeState.Idle;
            this.hive = hive;
            this.world = world;
        }

        /*********************************
        * FUNCTIONS
        *********************************/

        public void Go(Random random)
        {
            Age++;

            BeeState oldState = CurrentState;

            switch (CurrentState)
            {
                case BeeState.Idle:
                    if (Age > CareerSpan)
                    {
                        CurrentState = BeeState.Retired;
                    }
                    // See if there are flowers left, and then consume enough honey to keep going. Otherwise, we're stuck.
                    else if (world.Flowers.Count > 0 && hive.ConsumeHoney(HoneyConsumed))
                    {
                        // We need another living flower with nectar.
                        Flower flower = world.Flowers[random.Next(world.Flowers.Count)];

                        // Assuming that all works out, go to the new flower.
                        if (flower.Nectar >= MinimumFlowerNectar && flower.Alive)
                        {
                            destinationFlower = flower;
                            CurrentState = BeeState.FlyingToFlower;
                        }
                    }
                    break;
                case BeeState.FlyingToFlower:
                    {
                        // Make sure the flower hasn't died as we're heading towards it
                        if (!world.Flowers.Contains(destinationFlower))
                        {
                            CurrentState = BeeState.ReturningToHive;
                        }
                        // If we can get to the exit, then we're out of the hive. Update
                        // our location. Since we're now on the field form, we should fly
                        // out near the entrance.
                        else if (InsideHive)
                        {
                            if (MoveTowardsLocation(hive.GetLocation("Exit")))
                            {
                                InsideHive = false;

                                // This is why we passed a reference to the hive to the Bee constructor
                                location = hive.GetLocation("Entrance");
                            }
                        }
                        else
                        {
                            // If we're out of the hivem and the flower is alive, get to it and start gathering nectar.
                            if (MoveTowardsLocation(destinationFlower.Location))
                            {
                                CurrentState = BeeState.GatheringNectar;
                            }
                        }

                        break;
                    }
                case BeeState.GatheringNectar:
                    double nectar = destinationFlower.HarvestNectar();
                    if (nectar > 0)
                    {
                        NectarCollected += nectar;
                    }
                    else
                    {
                        CurrentState = BeeState.ReturningToHive;
                    }
                    break;
                case BeeState.ReturningToHive:
                    if (!InsideHive)
                    {
                        // If we've made it to the hive, update our location and the insideHive status
                        if (MoveTowardsLocation(hive.GetLocation("Entrance")))
                        {
                            InsideHive = true;
                            location = hive.GetLocation("Exit");
                        }
                    }
                    else
                    {
                        // If we're already in the hive, head to the honey factory
                        if (MoveTowardsLocation(hive.GetLocation("HoneyFactory")))
                        {
                            CurrentState = BeeState.MakingHoney;
                        }
                    }
                    break;
                case BeeState.MakingHoney:
                    if (NectarCollected < 0.5)
                    {
                        NectarCollected = 0;
                        CurrentState = BeeState.Idle;
                    }
                    else
                    {
                        // Try and give this nectar to the hive.
                        if (hive.AddHoney(0.5))
                        {
                            // If the hive could use the nectar to make honey
                            // ...remove it from the bee.
                            NectarCollected -= 0.5;
                        }
                        else
                        {
                            // If the hive's full, AddHoney() will return false, so the bee just dumps the rest of the nectar
                            // so he can fly out on another mission.
                            NectarCollected = 0;
                        }
                    }
                    break;
                case BeeState.Retired:
                    // Do nothing! We're retired!
                    break;
                default:
                    break;
            }

            if (oldState != CurrentState && MessageSender != null)
            {
                MessageSender(ID, CurrentState.ToString());
            }
        }

        private bool MoveTowardsLocation(Point destination)
        {
            if (Math.Abs(destination.X - location.X) <= MoveRate && Math.Abs(destination.Y - location.Y) <= MoveRate)
            {
                return true;
            }

            if (destination.X > location.X)
            {
                location.X += MoveRate;
            }
            else if (destination.X < location.X)
            {
                location.X -= MoveRate;
            }

            if (destination.Y > location.Y)
            {
                location.Y += MoveRate;
            }
            else if (destination.Y < location.Y)
            {
                location.Y -= MoveRate;
            }

            return false;
        }
    }
}
