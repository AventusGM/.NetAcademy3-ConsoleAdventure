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
	}

	public static class Locations
	{
		public static Location HardLocation = new Location("hurt me", 4);
		public static Location MidLocation = new Location("challenge", 7);
		public static Location EasyLocation = new Location("i dont want to die", 15);
	}
}
