using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Enemy
    {
        Int32 health;
        String name;
        UInt32 damage;
        Weapon weapon;
        UInt32 baseAttack;


        public Int32 Health { get; set; }
        public String Name { get; set; }
        public UInt32 Damage { get; set; }
        public Weapons Weapons { get; }
        public UInt32 BaseAttack { get; set; }
        public Enemy(Int32 health, String name, UInt32 damage, Weapons weapons, UInt32 baseAttack)
        {
            Health = health;
            Name = name;
            Damage = damage;
            Weapons = weapons;
            BaseAttack = baseAttack;
        }
        public Enemy()
        {
            health = 100;
            baseAttack = 5;
            damage = weapon.Damage + baseAttack;
        }
        public void GetDamage(Player p)
        {
            Health -= p.Weapon.Damage;
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
