using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Enemy
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public uint Damage { get; set; }
        public uint BaseAttack { get; set; }
        public Weapon weapon { get; set; }

        public Enemy(int health, string name, uint damage, uint baseAttack)
        {
            Health = health;
            Name = name;
            Damage = damage;
            BaseAttack = baseAttack;
        }

        public Enemy()
        {
            Health = 100;
            BaseAttack = 5;
            Damage = weapon.Damage + BaseAttack;
        }

        public void GetDamage(Player p)
        {
            Health -= Convert.ToInt32(p.Weapon.Damage);
        }

        public void Hit(ref Player p)
        {
            p.GetDamage(Damage);
        }

        public class Enemies
        {
            Enemy wolf = new Enemy { Name = "The Big Evil Wolf", Health = 80, BaseAttack = 20 };
            Enemy forsaken = new Enemy { Name = "Forsaken", Health = 100, BaseAttack = 20, weapon = Weapons.WoodenStick };
            Enemy rough = new Enemy { Name = "Rough", Health = 100, BaseAttack = 25, weapon = Weapons.ShortSword };
        }
    }
}
