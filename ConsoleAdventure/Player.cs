using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	public class Player
	{
		public string Name { private set; get; }
		public int Health { private set; get; }
		public int Armor { private set; get; }
		public Weapon weapon { private set; get; }

		public Player(string name)
		{
			Name = name;
			Health = 100;
			Armor = 0;
			weapon = new Weapon("shotgun", 20, 350);
		}

		public void Run()
		{
			Random rand = new Random(49);

			int damage = rand.Next();

			if (damage % 2 == 0)
				Health -= damage;
		}

		public void Hurt(Enemy e)
		{
			if (e.GetDamage() <= 0)
				Health = 100;
		}

		public void GetDamage(uint damage)
		{
			Health -= (int)damage;
		}

		public void Heal(uint heal)
		{
			Health += (int)heal;

			if (Health > 100)
				Health = 100;
		}

		public void GetArmor(uint armor)
		{
			Armor += (int)armor;
		}
	}
}
