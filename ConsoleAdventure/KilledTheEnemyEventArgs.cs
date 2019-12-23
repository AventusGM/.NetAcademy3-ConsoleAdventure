using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace ConsoleAdventure
{
	public class KilledTheEnemyEventArgs : EventArgs
	{
		public Enemy Enemy { protected set; get; }

		public KilledTheEnemyEventArgs(Enemy enemy)
		{
			Enemy = enemy;
		}
	}
}
