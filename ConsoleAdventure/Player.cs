using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	public class Player : Creature
	{
		public uint Armor { private set; get; }
		public Weapon Weapon { set; get; }

        //! add inventory using Inventory class

		public Player()
		{
			Name = null;
			Health = 100;
			Armor = 0;
			Weapon = null;
		}

		public Player(string name, Weapon weapon)
		{
			Name = name;
			Health = 100;
			Armor = 0;
			Weapon = weapon;
		}

		public void Run()
		{
			Random rand = new Random(1);

			int damage = rand.Next();

			if (damage == 1)
				Health -= damage;
		}

		public override void Hurt(Creature e)
		{
			if (e.GetDamage(Weapon.Damage) <= 0)
				Health = 100;
		}

		public override int GetDamage(uint damage)
		{
			if (Armor >= damage)
			{
				Armor -= damage;
			}
			else if (Armor < damage && Armor > 0)
			{
				damage -= Armor;
				Armor = 0;
				Health -= (int)damage;
			}
			else
			{
				Health -= (int)damage;
			}

			return Health;
		}

		public void Heal(uint heal)
		{
			Health += (int)heal;

			if (Health > 100)
				Health = 100;
		}

		public void GetArmor(uint armor)
		{
			Armor += armor;
		}
	}
}
