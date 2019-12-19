using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class HealthBoost : Item, IUsable
    {
        public int HealAmount { get; }
        public HealthBoost(int healAmount, Rarity rarity, double weight) : base(rarity, weight)
        {
            HealAmount = healAmount;
        }

        public void Use()
        {

        }
    }
}
