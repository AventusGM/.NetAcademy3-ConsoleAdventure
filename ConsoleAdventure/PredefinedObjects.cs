using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public static class PredefinedObjects
    {
        /// <summary>
        /// Contains all predefined items, including weapons and potions.
        /// </summary>
        /// <remarks>Does not include enemy loot such as Wolf leather</remarks>
        public static List<Item> Items = new List<Item>(new List<Item>()
        {
            // Weapons
            new Weapon("Wooden club", 1, Rarities.Common, 0.4),
            new Weapon("Short sword", 2, Rarities.Common, 0.8),
            new Weapon("Long sword", 5, Rarities.Common, 1.2),
            new Weapon("Sword", 5, Rarities.Common, 1),
            new Weapon("Axe", 6, Rarities.Common, 2.9),
            new Weapon("Rapier", 12, Rarities.Uncommon, 1.7),
            new Weapon("Claymore", 10, Rarities.Uncommon, 2.5),
            new Weapon("Broad sword", 10, Rarities.Uncommon, 2),
            new Weapon("Morgenstern", 20, Rarities.Legendary, 3),
            new Weapon("Shadow Blade", 20, Rarities.Legendary, 1.3),
            new Weapon("Boiko's Spear", 100, Rarities.Arcane, 5),
            new Weapon("Sorochak's Hammer", uint.MaxValue, Rarities.Arcane, 20),

            // Potions
            new HealthBoost("Small health potion", 30, Rarities.Common, 0.1),
            new HealthBoost("Health potion", 50, Rarities.Common, 0.25),
            new HealthBoost("Greater health potion", 100, Rarities.Uncommon, 0.30),
                });

        public static ReadOnlyCollection<Item> Loot = new ReadOnlyCollection<Item>(new List<Item>()
        {
            new Item("Wolf leather", Rarities.Common, 0.3),
            new Item("Wolf meat", Rarities.Common, 1),
        });

        public static ReadOnlyCollection<Enemy> Enemies = new ReadOnlyCollection<Enemy>(new List<Enemy>()
        {
            new Enemy { Name = "Wolf", Health = 80, BaseAttack = 20 },
            new Enemy { Name = "Forsaken", Health = 100, BaseAttack = 20, weapon = (Weapon)FindItem("Wooden club") },
            new Enemy { Name = "Rough", Health = 100, BaseAttack = 25, weapon = (Weapon)FindItem("Short sword") },
        });

        public static Item FindItem(string name)
        {
            return Items.ToList().Find(i => i.Name == name);
        }

        public static Item FindLoot(string name)
        {
            return Loot.ToList().Find(l => l.Name == name);
        }

        static PredefinedObjects()
        {
            Items = new List<Item>();
            Items.Add(new Weapon("Wooden club", 1, Rarities.Common, 0.4));
            Init();
        }

        static void Init()
        {
            Items = new List<Item>();
            Items.Add(new Weapon("Wooden club", 1, Rarities.Common, 0.4));
        }
    }
}
