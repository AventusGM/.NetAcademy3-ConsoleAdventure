using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Item
    {
        public static readonly List<Item> DefinedItems = new List<Item>();

        public string Name { get; set; }

        public Rarity Rarity { get; set; }

        // Let measure it in Kg
        public double Weight { get; set; }

        // This field defines if item 
        // could be found in chests or dropped from enemies
        public readonly bool CanDrop;

        public Item(string name, Rarity rarity, double weight)
        {
            Name = name;
            Rarity = rarity;
            Weight = weight;
            CanDrop = true;
            DefinedItems.Add(this);
        }
    }
}
