using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	public struct Coords
	{
		public int x;
		public int y;

		public Coords(int x, int y)
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
				Coords = new Coords(rand.Next(), rand.Next());
			}
			else
			{
				do
				{
					Coords = new Coords(rand.Next(), rand.Next());
				} while (otherCreaturesAndObjects.Contains(Coords));
			}

			return Coords;
		}

		public abstract bool MoveUp(Location currentLocation);
		public abstract bool MoveDown(Location currentLocation);
		public abstract bool MoveLeft(Location currentLocation);
		public abstract bool MoveRight(Location currentLocation);
	}
}
