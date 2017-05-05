using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game,location){}

        public override string Name
        {
            get { return "Sword"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            if (direction == Direction.Up)
            {
                if(!DamageEnemy(direction, 15, 3, random))
                {
                    if(!DamageEnemy(Direction.Right, 15, 3, random))
                    {
                        DamageEnemy(Direction.Left, 15, 3, random);
                    }
                }
            }
            else if (direction == Direction.Down)
            {
                if (!DamageEnemy(direction, 15, 3, random))
                {
                    if (!DamageEnemy(Direction.Left, 15, 3, random))
                    {
                        DamageEnemy(Direction.Right, 15, 3, random);
                    }
                }
            }
            if (direction == Direction.Left)
            {
                if (!DamageEnemy(direction, 15, 3, random))
                {
                    if (!DamageEnemy(Direction.Up, 15, 3, random))
                    {
                        DamageEnemy(Direction.Down, 15, 3, random);
                    }
                }
            }
            if (direction == Direction.Right)
            {
                if (!DamageEnemy(direction, 15, 3, random))
                {
                    if (!DamageEnemy(Direction.Down, 15, 3, random))
                    {
                        DamageEnemy(Direction.Up, 15, 3, random);
                    }
                }
            }
        }
    }
}
