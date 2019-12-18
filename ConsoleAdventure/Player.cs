using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	class Player
	{
		string Name { set; get; }
		int Health { set; get; }
		//int Stamina { set; get; }

		public Player(string name)
		{
			Name = name;
			Health = 100;
		}

		public void run()
		{
			Random rand = new Random(49);

			int damage = rand.Next();

			if (damage % 2 == 0)
				Health -= damage;
		}

		public void hurt(ref Enemy e)
		{
			if (e.getDamage() <= 0)
				Health = 100;
		}

		public void getDamage(int enemyDamage)
		{
			Health -= enemyDamage;
		}
	}
}
