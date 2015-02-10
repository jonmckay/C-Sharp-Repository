using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Quest
{
    class Bat : Enemy
    {
        private Game game;
        private System.Drawing.Point point;

        public Bat(Game game, System.Drawing.Point point)
        {
            // TODO: Complete member initialization
            this.game = game;
            this.point = point;
        }
    }
}
