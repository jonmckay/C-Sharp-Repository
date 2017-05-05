using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders_Lab
{
    public partial class InvadersForm : Form
    {
        private int counter = 0;
        private List<Keys> keysPressed = new List<Keys>();
        private bool gameOver;
        private Game game = new Game();

        public InvadersForm()
        {
            InitializeComponent();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Game.Twinkle();

            // A counter that cycles from 0 to 3 and then back down to 0
            // Updates animations
            counter++;
            if (counter >= 3)
            {
                counter = 0;
            }

            this.Refresh();
        }

        private void InvadersForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }

            if (gameOver)
            {
                if (e.KeyCode == Keys.S)
                {
                    // code to reset the game and restart the timers
                    return;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                game.FireShot();
            }
            if (keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }
            keysPressed.Add(e.KeyCode);
        }

        private void InvadersForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // The timer makes the game advance by one frame. This allows the gameplay to continue
            game.Go();

            foreach (Keys key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    return;
                }
            }
        }

        private void InvadersForm_Paint(object sender, PaintEventArgs e)
        {
            // Check gameOver. If its true, habe it write GAME OVER in big yellow letters in the middle of the screen.
            // Then have it write "Press S to start a new game or Q to quit" in the lower right-hand corner.
        }
    }
}
