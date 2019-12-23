using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace ConsoleAdventure
{
	public class KilledTheEnemyEventArgs : EventArgs
	{
		public string EnemyName { protected set; get; }

		public KilledTheEnemyEventArgs(string enemyName)
		{
			EnemyName = enemyName;
		}
	}
}
