using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    class BluePotion : Weapon, IPotion
    {
        private bool used;
        public bool Used
        {
            get { return used; }
            set { used = value; }
        }
        

        public BluePotion(Game game, Point location) : base(game, location) { }

        public override string Name
        {
            get { return "BluePotion"; }
        }

        public override void Attack(Direction direction, Random random)
        {
            // Increase the players health by 5 points
            game.IncreasePlayerHealth(10, random);

            used = true;
        }
    }
}
