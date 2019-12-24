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

		public override string ToString()
		{
			return "x = " + X.ToString() + "; Y = " + Y.ToString();
		}
	}
}
