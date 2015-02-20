using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }

        public override void Move(Random random)
        {
            // 50% chance to move towards player
            if (random.Next(0, 2) == 0)
            {
                this.Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
            }
            // 50% chance to move in a random direction
            else
            {
                var values = Enum.GetValues(typeof(Direction));
                Direction direction = (Direction)values.GetValue(random.Next(values.Length));
                this.location = this.Move(direction, game.Boundaries);
            }

            // After moving, check if near the player. If near the player, attack
            if (this.NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }
}
