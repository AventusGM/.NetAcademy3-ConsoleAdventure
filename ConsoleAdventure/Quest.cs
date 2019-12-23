using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Quest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Quest(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    public static class QuestHelper
    {
        public static void GiveQuest(Quest quest)
        {
            //TODO
            //player.Quests.Add(quest);
        }
    }

    public class QuestManager
    {
        public List<Quest> Quests { get; protected set; }
        private readonly Player player;

        public QuestManager(Player player)
        {
            Quests = new List<Quest>();
            this.player = player;
        }
    }

    public static class Quests
    {
        public static Quest TheBeginning = new Quest("The beginning", "Kill your first enemy");
    }
}
