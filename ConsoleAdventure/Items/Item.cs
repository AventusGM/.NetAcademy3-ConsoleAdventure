using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Item : ICloneable
    {
        /// <summary>
        /// Contains every sample of defined items.
        /// </summary>
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
        }

        public Item(Item copyFrom)
            : this(copyFrom.Name, copyFrom.Rarity, copyFrom.Weight)
        { }

        public object Clone()
        {
            return new Item(this);
        }
    }
}
