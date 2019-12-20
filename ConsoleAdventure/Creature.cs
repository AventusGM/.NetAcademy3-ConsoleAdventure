using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public struct Coords
    {
        public uint x;
        public uint y;

        public Coords(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public abstract class Creature
	{
		public string Name { protected set; get; }
		public int Health { protected set; get; }
        public Coords coords { protected set; get; }

		public abstract void Hurt(Creature e);
		public abstract int GetDamage(uint damage);	//returns new Health
        //coords generate abstract method
	}
}
