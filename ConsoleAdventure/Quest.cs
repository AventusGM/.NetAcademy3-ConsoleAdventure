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

    public class KillQuest<T> : Quest where T: Creature
    {
        T KillTarget { get; set; }
        KillQuest(string name, string description) : 
            base(name, description)
        {

        }
    }

    public static class QuestHelper
    {
        public static void GiveQuest(Quest quest)
        {
            //TODO
        }
    }

    public class QuestManager
    {
        private Player player;

        private List<Quest> Quests;
        public QuestManager(Player player)
        {
            Quests = new List<Quest>();
            this.player = player;
            this.player.KilledTheEnemy += Player_KilledTheEnemy;
        }

        public void AddQuest(Quest quest)
        {
            QuestDisplay.NotifyNewQuest(quest);
            Quests.Add(quest);
        }

        private void Player_KilledTheEnemy(object sender, KilledTheCreatureEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public static class Quests
    {
        public static Quest TheBeginning = new Quest("The beginning", "Kill your first enemy");
    }
}
