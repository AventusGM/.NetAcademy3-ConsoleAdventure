using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class TreasureChest
    {
        public IEnumerable<Item> Content { get; set; }
        public TreasureChest(params Rarity[] possibleRarities)
        {
            Content = LootController.GetLoot(1, possibleRarities);
        }
    }
}
