using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handlers_Chapter_11
{
    class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPlay += ball_BallInPlay;
        }

        public void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance > 400) && (ballEventArgs.Trajectory > 30))
                {
                    TryToCatch();
                }
                else
                {
                    ScreamAndYell();
                }
            }
        }

        private void TryToCatch()
        {
            Console.WriteLine("Fan: Home run! I'm going for the ball!");
        }

        private void ScreamAndYell()
        {
            Console.WriteLine("Fan: Woo-hoo! Yeah!");
        }
    }
}
