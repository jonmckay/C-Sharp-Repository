﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game,location) { }

        public override string Name
        {
            get { return "Mace"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}
