using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	public class Location
	{
		public string Title { set; get; }
		public uint Size { private set; get; }

		protected Location()
		{
			Title = null;
			Size = 0;
		}

		public Location(string title, uint size)
		{
			Title = title;
			Size = size;
		}

		/*public Coords GeneratePlayerCoords(Coords? enemyCoords) //move it to Creature as an abstract method
		{
			Random rand = new Random((int)Size - 1);
			Coords playerCoords;

			if (enemyCoords == null)
			{
				playerCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
			}
			else
			{
				do
				{
					playerCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
				} while (enemyCoords.Value.x == playerCoords.x && enemyCoords.Value.y == playerCoords.y);
			}

			return playerCoords;
		}

		public Coords GenerateEnemyCoords(Coords? playerCoords) //move it to Creature as an abstract method
		{
			Random rand = new Random((int)Size - 1);
			Coords enemyCoords;

			if (playerCoords == null)
			{
				enemyCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
			}
			else
			{
				do
				{
					enemyCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
				} while (enemyCoords.x == playerCoords.Value.x && enemyCoords.y == playerCoords.Value.y);
			}

			return enemyCoords;
		}*/
	}

	public static class Locations
	{
		public static Location HardLocation = new Location("hurt me", 4);
		public static Location MidLocation = new Location("challenge", 7);
		public static Location EasyLocation = new Location("i dont want to die", 15);
	}
}
