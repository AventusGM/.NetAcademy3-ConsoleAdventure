using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public struct Gold
    {
        public int Amount { get; set; }
        public Gold(int amount)
        {
            Amount = amount;
        }
        
        public static bool operator ==(Gold l, Gold r)
        {
            return l.Amount == r.Amount;
        }

        public static bool operator !=(Gold l, Gold r)
        {
            return l.Amount == r.Amount;
        }

        public static Gold operator +(Gold l, Gold r)
        {
            return new Gold(l.Amount + r.Amount);
        }

        public static Gold operator -(Gold l, Gold r)
        {
            return new Gold(l.Amount - r.Amount);
        }

        public static Gold operator *(Gold gold, int multiplier)
        {
            return new Gold(gold.Amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
