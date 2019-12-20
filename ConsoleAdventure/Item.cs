using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Item
    {
        public static readonly List<Item> DefinedItems;

        public Rarity Rarity { get; set; }

        // Let measure it in Kg
        public double Weight { get; set; }

        // This field defines if item 
        // could be found in chests or dropped from enemies
        public readonly bool CanDrop;

        public Item(Rarity rarity, double weight)
        {
            Rarity = rarity;
            Weight = weight;
            CanDrop = true;
            DefinedItems.Add(this);
        }

        public void Use()
        {
            // todo
        }
    }
}
