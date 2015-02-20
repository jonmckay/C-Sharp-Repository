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
                UpdateCharacters();
            }
            else if (sender == btnMoveDown)
            {
                game.Move(Direction.Down, random);
                UpdateCharacters();
            }
            else if (sender == btnMoveLeft)
            {
                game.Move(Direction.Left, random);
                UpdateCharacters();
            }
            else if (sender == btnMoveRight)
            {
                game.Move(Direction.Right, random);
                UpdateCharacters();
            }
        }

        private void AttackClick(object sender, EventArgs e)
        {
            if (sender == btnAttackUp)
            {
                game.Attack(Direction.Up, random);
                UpdateCharacters();
            }
            else if (sender == btnAttackDown)
            {
                game.Attack(Direction.Down, random);
                UpdateCharacters();
            }
            else if (sender == btnAttackLeft)
            {
                game.Attack(Direction.Left, random);
                UpdateCharacters();
            }
            else if (sender == btnAttackRight)
            {
                game.Attack(Direction.Right, random);
                UpdateCharacters();
            }
        }

        private void InventoryItemClick(object sender, EventArgs e)
        {
            if (sender == pbBattleaxeInv)
            {
                pbBattleaxeInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Battleaxe");
            }
            else if (sender == pbSwordInv)
            {
                pbSwordInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Sword");
            }
            else if (sender == pbBluePotInv)
            {
                pbBluePotInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("BluePotion");
            }
            else if (sender == pbRedPotInv)
            {
                pbRedPotInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("RedPotion");
            }
            else if (sender == pbBombInv)
            {
                pbBombInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Bomb");
            }
            else if (sender == pbMaceInv)
            {
                pbMaceInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Mace");
            }
            else if (sender == pbBowInv)
            {
                pbBowInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Bow");
            }
            else if (sender == pbQuiverInv)
            {
                pbQuiverInv.BorderStyle = BorderStyle.FixedSingle;
                game.Equip("Quiver");
            }
        }

        public void UpdateCharacters()
        {
            pbPlayer.Location = game.PlayerLocation;
            lblPlayerHitPoint.Text = game.PlayerHitPoints.ToString();
            pbPlayer.Visible = true;

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    pbBat.Location = enemy.Location;
                    lblBatHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghost)
                {
                    pbGhost.Location = enemy.Location;
                    lblGhostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
            }
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghoul)
                {
                    pbGhoul.Location = enemy.Location;
                    lblGhoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            // If an enemy dies set the hit points to zero and stop displaying the picture box
            if (!showBat)
            {
                pbBat.Visible = false;
                lblBatHitPoints.Text = "0";
            }
            else
            {
                pbBat.Visible = true;
            }
            if (!showGhost)
            {
                pbGhost.Visible = false;
                lblGhostHitPoints.Text = "0";
            }
            else
            {
                pbGhost.Visible = true;
            }
            if (!showGhoul)
            {
                pbGhoul.Visible = false;
                lblGhoulHitPoints.Text = "0";
            }
            else
            {
                pbGhoul.Visible = true;
            }

            ///////////////////////////////////
            // Update the weapon picture boxes
            ///////////////////////////////////

            // Dungeon weapons
            pbSword.Visible = false;
            pbRedPot.Visible = false;
            pbBluePot.Visible = false;
            pbMace.Visible = false;
            pbQuiver.Visible = false;
            pbBow.Visible = false;
            pbBomb.Visible = false;
            pbBattleaxe.Visible = false;

            // Inventory weapons
            pbMaceInv.Visible = false;
            pbSwordInv.Visible = false;
            pbBluePotInv.Visible = false;
            pbRedPotInv.Visible = false;
            pbQuiverInv.Visible = false;
            pbBowInv.Visible = false;
            pbBattleaxeInv.Visible = false;
            pbBombInv.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = pbSword;
                    break;
                case "Battleaxe":
                    weaponControl = pbBattleaxe;
                    break;
                case "Bow":
                    weaponControl = pbBow;
                    break;
                case "Mace":
                    weaponControl = pbMace;
                    break;
                case "Bomb":
                    weaponControl = pbBomb;
                    break;
                case "RedPotion":
                    weaponControl = pbRedPot;
                    break;
                case "BluePotion":
                    weaponControl = pbBluePot;
                    break;
                case "Quiver":
                    weaponControl = pbQuiver;
                    break;
                default:
                    break;
            }
            weaponControl.Visible = true;

            ///////////////////////
            // Inventory handling
            ///////////////////////

            if (game.CheckPlayerInventory("Sword"))
            {
                pbSwordInv.Visible = true;
            }
            else if (game.CheckPlayerInventory("Bow"))
            {
                pbBowInv.Visible = true;
            }
            else if (game.CheckPlayerInventory("Bomb"))
            {
                pbBombInv.Visible = true;
            }
            else if (game.CheckPlayerInventory("RedPotion"))
            {
                pbRedPotInv.Visible = true;
            }
            else if (game.CheckPlayerInventory("BluePotion"))
            {
                pbBluePotInv.Visible = true;
            }
            else if (game.CheckPlayerInventory("Mace"))
            {
                pbMaceInv.Visible = true;
            }
            else if (game.CheckPlayerInventory("Battleaxe"))
            {
                pbBattleaxeInv.Visible = true;
            }
            else if (game.CheckPlayerInventory("Quiver"))
            {
                pbQuiverInv.Visible = true;
            }

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        /// <summary>
        /// Uses W,A,S,D for player movement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuestForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    e.Handled = true;
                    btnMoveUp.PerformClick();
                    break;
                case Keys.D:
                    e.Handled = true;
                    btnMoveRight.PerformClick();
                    break;
                case Keys.A:
                    e.Handled = true;
                    btnMoveLeft.PerformClick();
                    break;
                case Keys.S:
                    e.Handled = true;
                    btnMoveDown.PerformClick();
                    break;
                default:
                    break;
            }
        }

    }
}
