using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	public struct Coords
	{
		public int X;
		public int Y;

		public Coords(int x, int y)
		{
			X = x;
			Y = y;
		}

		public override bool Equals(object obj)
		{
			if (obj == null || !this.GetType().Equals(obj.GetType()))
				return false;
			else
				return X == ((Coords)obj).X && Y == ((Coords)obj).Y;
		}

		public static bool operator ==(Coords a, Coords b) => a.Equals(b);

		public static bool operator !=(Coords a, Coords b) => !a.Equals(b);

		public override int GetHashCode() => Tuple.Create(X, Y).GetHashCode();
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
				throw new ArgumentException("public Coords? GenerateCoords(List<Coords?> otherCreaturesAndObjects, Location location) in Class Creature: location.Size was 0");

			if (Math.Pow(location.Size, 2) == otherCreaturesAndObjects.Count)
				throw new ArgumentException("public Coords? GenerateCoords(List<Coords?> otherCreaturesAndObjects, Location location) in Class Creature: location is already full (location.Size^2 == otherCreaturesAndObjects.Count)");

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
