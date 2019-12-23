using ConsoleAdventure.Display;
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
            QuestManager questManager = new QuestManager();
            questManager.AddQuest(quest);
        }
    }

    public class QuestManager
    {
        private List<Quest> Quests;
        public QuestManager()
        {
            Quests = new List<Quest>();
        }

        public void AddQuest(Quest quest)
        {
            QuestDisplay.NotifyNewQuest(quest);
            Quests.Add(quest);
        }
    }

    public static class Quests
    {
        public static Quest TheBeginning = new Quest("The beginning", "Kill your first enemy");
    }
}
