﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Example_Chapter_14
{
    static class SuperSoldierSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            return ("I broke through a wall of " + wallDensity + " density.");
        }
    }
}
