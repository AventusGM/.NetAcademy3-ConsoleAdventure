using System;
using ConsoleAdventure.Core.Game.Items;
using ConsoleAdventure.Core.Game;

namespace ConsoleAdventure.Core.Game.Entity
{
    class Player : Entity
    {
        public Player() : base()
        {
        }

        public Player(string name)
        {
            isAlive = true;
            Name = name;
            Health = 100;
            Weapon = new Weapons.Weapon();
        }

        public void PickWeapon(Weapons.Weapon weapon)
        {
            Weapon = weapon;
        }

        public int Hit()
        {
            return Weapon.Damage;
        }

        public void PickItem(Item item)
        {
        }

        public void UseItem(Item item)
        {
            item.Use();
        }

        public void Move()
        {
            Console.Write("Choose where you want to go (w, a, s, d): ");
            string direction = Console.ReadLine().ToLower();
            Random random = new Random();

            if (direction == "w")
            {
                Console.WriteLine("Moving forward");
            }
            else if (direction == "d")
            {
                Console.WriteLine("Moving right");
            }
            else if (direction == "s")
            {
                Console.WriteLine("Moving backward");
            }
            else if (direction == "a")
            {
                Console.WriteLine("Moving left");
            }
            else
            {
                Console.WriteLine("Standing here");
            }
        }
    }
}
