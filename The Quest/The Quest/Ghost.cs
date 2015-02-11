using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8){}

        public override void Move(Random random)
        {
            throw new NotImplementedException();
        }
    }
}
