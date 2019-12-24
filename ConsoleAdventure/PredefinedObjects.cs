using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    static class PredefinedObjects
    {
        public static Item FindItem(string name)
        {
            return Items.ToList().Find(i => i.Name == name);
        }

        public static ReadOnlyCollection<Item> Items = new ReadOnlyCollection<Item>(new List<Item>()
        {
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

            new HealthBoost("Small health potion", 30, Rarities.Common, 0.1),
            new HealthBoost("Health potion", 50, Rarities.Common, 0.25),
            new HealthBoost("Greater health potion", 100, Rarities.Uncommon, 0.30),
        }
            );

    }
}
