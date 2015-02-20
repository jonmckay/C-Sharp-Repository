using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace The_Quest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public Player(Game game, Point location)
            : base(game, location)
        {
            hitPoints = 10;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (game.WeaponInRoom.Nearby(this.location, 1))
                {
                    inventory.Add(game.WeaponInRoom);                    
                    game.WeaponInRoom.PickUpWeapon();
                    if (inventory.Count == 1)
                    {
                        game.Equip(game.WeaponInRoom.Name);
                    }
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            // If player has an equipped weapon
            if (this.equippedWeapon != null)
            {
                // Attack with equipped weapon in direction for random amount of damage
                equippedWeapon.Attack(direction, random);

                // If the weapon is a potion remove it from inventory after using
                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                }
            }
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

    }
}
