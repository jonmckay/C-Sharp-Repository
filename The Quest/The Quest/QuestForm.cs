using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest
{
    public partial class QuestForm : Form
    {
        private Game game;
        private Random random = new Random();

        public QuestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the location of the player, enemies, and any weapons currently in the dungeon
        /// and moves the PictureBoxes to match them.
        /// </summary>
        private void UpdateCharacters()
        {
            throw new NotImplementedException();
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void MoveClick(object sender, EventArgs e)
        {
            if (sender == btnMoveUp)
            {
                game.Move(Direction.Up, random);
            }
            else if (sender == btnMoveDown)
            {
                game.Move(Direction.Down, random);
            }
            else if (sender == btnMoveLeft)
            {
                game.Move(Direction.Left, random);
            }
            else if (sender == btnMoveRight)
            {
                game.Move(Direction.Right, random);
            }
        }

        private void AttackClick(object sender, EventArgs e)
        {
            if (sender == btnAttackUp)
            {
                game.Attack(Direction.Up, random);
            }
            else if (sender == btnAttackDown)
            {
                game.Attack(Direction.Down, random);
            }
            else if (sender == btnAttackLeft)
            {
                game.Attack(Direction.Left, random);
            }
            else if (sender == btnAttackRight)
            {
                game.Attack(Direction.Right, random);
            }
        }

        private void InventoryItemClick(object sender, EventArgs e)
        {
            if (sender == pbBattleaxeInv)
            {
                pbBattleaxeInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Battleaxe");
            }
            else if (sender == pbQuiverInv)
            {
                pbQuiverInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Quiver");
            }
        }
    }
}
