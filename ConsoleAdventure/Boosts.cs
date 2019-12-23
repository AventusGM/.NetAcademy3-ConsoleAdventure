using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class HealthBoost : Item, IUsable
    {
        public uint HealAmount { get; }
        public HealthBoost(string name, uint healAmount, Rarity rarity, double weight) : base(name, rarity, weight)
        {
            HealAmount = healAmount;
        }

        public void Use(Player user)
        {
            user.Heal(HealAmount);
        }
    }

    public static class HealthBoosters
    {
        public static HealthBoost SmallHealthPotion = new HealthBoost("Small health potion", 30, Rarities.Common, 0.1);
        public static HealthBoost HealthPotion = new HealthBoost("Health potion", 50, Rarities.Common, 0.25);
        public static HealthBoost GreaterHealthPotion = new HealthBoost("Greater health potion", 100, Rarities.Uncommon, 0.30);
    }
}
