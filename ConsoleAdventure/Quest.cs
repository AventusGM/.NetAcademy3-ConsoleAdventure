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
        public bool Completed { get; set; }
        public IEnumerable<Item> Reward { get; set; }

        public Quest(string name, string description, IEnumerable<Item> reward)
        {
            Name = name;
            Description = description;
            Reward = reward;
        }
    }

    // Using generics here causes more 
    // problems in below code than it solves.
    public class KillQuest : Quest
    {
        public Type TargetCreature { get; }
        public int TargetCount { get; }

        private int actualCount;
        public int ActualCount
        {
            get => actualCount;
            set
            {
                actualCount = value;
                if (actualCount >= TargetCount) Completed = true;
            }
        }

        public KillQuest(string name, string description, IEnumerable<Item> reward, Type creatureType, int count) 
            : base(name, description, reward)
        {
            TargetCreature = creatureType;
            TargetCount = count;
            ActualCount = 0;
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
            this.player.KilledTheCreature += Player_KilledTheCreature;
        }

        private void Player_KilledTheCreature(object sender, KilledTheCreatureEventArgs e)
        {
            foreach(Quest quest in Quests)
            {
                if(quest is KillQuest)
                {
                    if (e.Creature.GetType() == ((KillQuest)quest).TargetCreature)
                        ((KillQuest)quest).ActualCount++;
                }
                if (quest.Completed) player.Inventory.Items.Concat(quest.Reward);
            }
        }

        public void AddQuest(Quest quest)
        {
            QuestDisplay.NotifyNewQuest(quest);
            Quests.Add(quest);
        }
    }

    public static class Quests
    {
        public static Quest TheBeginning = new KillQuest("The beginning", "Kill your first enemy"
            ,new List<Item>() { Weapons.Sword, HealthBoosters.HealthPotion }
            ,typeof(Creature), 1);
    }
}
