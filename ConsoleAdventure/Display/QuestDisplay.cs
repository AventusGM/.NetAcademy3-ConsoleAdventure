using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.Display
{
    public static class QuestDisplay
    {
        public static void NotifyNewQuest(Quest quest)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("NEW QUEST ADDED - {0}", quest.Name);
            Console.ResetColor();
        }
    }
}
