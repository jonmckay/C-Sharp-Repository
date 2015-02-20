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
            if (random.Next(0,3) == 1)
            {
                this.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }

            // If near the player hit them for 3 damage
            if (this.NearPlayer())
            {
                game.HitPlayer(3, random);
            }
        }
    }
}
