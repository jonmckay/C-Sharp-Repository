using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Quest
{
    class BluePotion : Weapon
    {
        private Game game;
        private System.Drawing.Point point;

        public BluePotion(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }
    }
}
