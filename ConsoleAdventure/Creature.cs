using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	public abstract class Creature
	{
		public string Name { protected set; get; }
		public int Health { protected set; get; }

		public abstract void Hurt(Creature e);
		public abstract int GetDamage(uint damage);	//returns new Health
	}
}
