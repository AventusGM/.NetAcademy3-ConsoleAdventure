using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Item
    {
        public Rarity Rarity { get; set; }

        // Let measure it in Kg
        public double Weight { get; set; }
        public Item(Rarity rarity, double weight)
        {
            Rarity = rarity;
            Weight = weight;
        }
    }
}
