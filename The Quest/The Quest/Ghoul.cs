using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10) { }

        public override void Move(Random random)
        {
            if (random.Next(0,3) == 0 || random.Next(0,3) == 1)
            {
                this.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            if (this.NearPlayer())
            {
                game.HitPlayer(4, random);
            }
        }
    }
}
