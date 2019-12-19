using System;
using System.Threading;

namespace ConsoleAdventure.Core.Game.Items
{
    class Item
    {
        public string Name { get; set; }

        public Item()
        {
        }

        public void Use()
        {
            Console.WriteLine("Please wait, using " + Name);
            Thread.Sleep(2000);
            Console.WriteLine("Done!");
        }
    }
}
