using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace ConsoleAdventure
{
	public class KilledTheCreatureEventArgs : EventArgs
	{
		public Creature Enemy { protected set; get; }

		public KilledTheCreatureEventArgs(Creature enemy)
		{
			Enemy = enemy;
		}
	}
}
