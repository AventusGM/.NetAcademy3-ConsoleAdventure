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
        public HealthBoost(uint healAmount, Rarity rarity, double weight) : base(rarity, weight)
        {
            HealAmount = healAmount;
        }

        public void Use(Creature user)
        {
            if(user is Player)
            {
                ((Player)user).Heal(HealAmount);
            }
        }
    }

    public static class HealthBoosters
    {
        public static HealthBoost SmallHealthPotion = new HealthBoost(50, Rarities.Common, 0.1);
        public static HealthBoost HealthPotion = new HealthBoost(120, Rarities.Common, 0.25);
        public static HealthBoost GreaterHealthPotion = new HealthBoost(200, Rarities.Uncommon, 0.30);
    }
}
