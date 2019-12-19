using System;
using ConsoleAdventure.Core.Game.Weapons;

namespace ConsoleAdventure.Core.Game.Entity
{
    class Entity
    {
        public bool isAlive { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public Weapon Weapon { get; set; }

        public Entity()
        {
            isAlive = true;
            Name = "Entity";
            Health = 100;
            Weapon = new Weapon();
        }

        public Entity(string name, int health, Weapon weapon)
        {
            isAlive = true;
            Name = name;
            Health = health;
            Weapon = weapon;
        }

        public void GetDamage(int damage)
        {
            if (Health >= 0)
                isAlive = false;
            else
                Health -= damage;
        }

    }
}
