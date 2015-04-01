using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Handlers_Chapter_11
{
    public partial class BaseballForm : Form
    {
        Ball ball = new Ball();
        Pitcher pitcher;
        Fan fan;

        public BaseballForm()
        {
            InitializeComponent();
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        private void btnPlayBall_Click(object sender, EventArgs e)
        {
            Bat bat = ball.GetNewBat();
            BallEventArgs ballEventArgs = new BallEventArgs((int)nudTrajectory.Value, (int)nudDistance.Value);
            bat.HitTheBall(ballEventArgs);
        }
    }
}
