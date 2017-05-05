﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumberjack_Chapter_8
{
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlajackCount
        { 
            get
            {
                return meal.Count;
            }
        } // return the count

        public void TakeFlapjack(Flapjack Food, int HowMany)
        {
            // Add some number of flapjacks to the Meal stack
            for (int i = 0; i < HowMany; i++)
            {
                meal.Push(Food);
            }            
        }

        public void EatFlapjacks()
        {
            // Write this output to the console
            Console.WriteLine(this.Name + "'s eating flapjacks");
            while (meal.Count > 0)
            {
                Console.WriteLine(this.Name + " ate a " + meal.Pop().ToString() + " flapjack" + Environment.NewLine);
            }
            
        }
    }
}
