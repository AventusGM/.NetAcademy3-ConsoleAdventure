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
		public Coords? Coords { protected set; get; }

		public abstract void Hurt(Creature e);
		public abstract int GetDamage(uint damage); //returns new Health

		public Coords? GenerateCoords(List<Coords?> otherCreaturesAndObjects, Location location)
		{
			if (location == null)
				throw new ArgumentNullException(nameof(location));

			if (location.Size == 0)
				throw new ArgumentException("location.Size was 0");

			if (Math.Pow(location.Size, 2) == otherCreaturesAndObjects.Count)
				throw new ArgumentException("location is already full (location.Size^2 == otherCreaturesAndObjects.Count)");

			Random rand = new Random((int)location.Size - 1);

			if (otherCreaturesAndObjects == null)
			{
				Coords = new Coords((uint)rand.Next(), (uint)rand.Next());
			}
			else
			{
				do
				{
					Coords = new Coords((uint)rand.Next(), (uint)rand.Next());
				} while (otherCreaturesAndObjects.Contains(Coords));
			}

			return Coords;
		}

		public abstract Coords? MoveUp(Location currentLocation);   //returns new Coords
		public abstract Coords? MoveDown(Location currentLocation);   //returns new Coords
		public abstract Coords? MoveLeft(Location currentLocation);   //returns new Coords
		public abstract Coords? MoveRight(Location currentLocation);   //returns new Coords
	}
}
