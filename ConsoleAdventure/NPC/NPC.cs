using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.NPC
{
    // Work in progress
    public class NPC
    {
        public string Name { get; set; }
        public Dialog Dialog { get; set; }
        public NPC(string name, Dialog dialog)
        {
            Name = name;
            Dialog = dialog;
        }
    }

    // Feel free to edit and add new NPCs
    public static class NPCs
    {
        public static NPC Hryhorovych = new NPC(
            "Hryhorovych The Master",
            new Dialog("Hello stranger. Welcome to your adventure, a great accomplishments await you! " +
            "Do you need some help with your adventure?", new List<DialogResponse>
            {
                new DialogResponse("Yes I need.",
                    ()=> new Dialog("Great! TODO. Here is your first task, do you accept it?", new List<DialogResponse>
                    {
                        new DialogResponse("Yes.",() => QuestManager.GiveQuest(Quests.TheBeginning)),
                        new DialogResponse("No.", null),
                    }).Activate()),
                new DialogResponse("No, i want to figure everything by myself", null)
            }));
    }
}
