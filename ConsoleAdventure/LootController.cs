using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    /// <summary>
    /// Responsible for giving enemy specified loot or random, rarity constrained loot.
    /// </summary>
    public static class LootController
    {
        private static Random random = new Random();

        /// <summary>
        /// Returns a list of specified size of dropable rarity constrained items.
        /// </summary>
        /// <param name="count">Count of items</param>
        /// <param name="possibleRarities">Possible rarities of items</param>
        /// <remarks>Could be used for treasure chest content.</remarks>
        /// <returns>List of random items</returns>
        public static List<Item> GetLoot(int count, params Rarity[] possibleRarities)
        {
            List<Item> loot = new List<Item>();

            // Stores items with matching rarities.
            List<Item> rarityBuffer = GetItemsByRarity(possibleRarities);
            for(int i = 0; i < count; i++)
            {
                loot.Add(rarityBuffer[random.Next(0, rarityBuffer.Count)]);
            }

            return loot;
        }

        /// <summary>
        /// Returns a single random item of one of specified rarities.
        /// </summary>
        /// <returns>Random item</returns>
        public static Item GetLoot(params Rarity[] possibleRarities)
        {
            List<Item> rarityBuffer = new List<Item>();
            rarityBuffer = GetItemsByRarity(possibleRarities);
            return rarityBuffer[random.Next(0, rarityBuffer.Count)];
        }

        public static List<Item> GetRandomItems(int minCount, int maxCount, params Item[] possibleItems)
        {
            List<Item> items = new List<Item>();
            for(int i = 0; i < random.Next(minCount, maxCount); i++)
            {
                Item chosenItem = possibleItems[random.Next(0, possibleItems.Length)];
                if(!items.Contains(chosenItem))
                {
                    items.Add(chosenItem);
                }
            }
            return items;
        }

        private static List<Item> GetItemsByRarity(params Rarity[] rarities)
        {
            List<Item> items = new List<Item>();
            foreach(Rarity rarity in rarities)
            {
                foreach (Item item in Item.DefinedItems
                    .FindAll(i => i.Rarity == rarity && i.CanDrop))
                {
                    items.Add(item);
                }
            }
            return items;
        }

        /// <summary>
        /// Returns a list of predefined items that drop from specified creature
        /// </summary>
        /// <param name="creature">Creature to get loot from</param>
        public static List<Item> GetCreatureLoot(Creature creature)
        {
            switch (creature.Name)
            {
                // For example
                case "Wolf":
                    return GetRandomItems(0, 2, Loot.WolfLeather, Loot.WolfMeat);
                default:
                    return null;
            }
        }
    }

    /// <summary>
    /// Avalible loot
    /// </summary>
    public static class Loot
    {
        // For example
        public static Item WolfLeather = new Item(Rarities.Common, 0.3);
        public static Item WolfMeat = new Item(Rarities.Common, 1);
    }
}
