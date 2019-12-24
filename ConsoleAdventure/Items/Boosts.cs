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
}
