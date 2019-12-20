using System;

namespace ConsoleAdventure
{
    public struct Rarity
    {
        public string Name { get; set; }

        // In %
        public double DropChance { get; set; }
        ConsoleColor Color { get; set; }

        public Rarity(string name, double chance, ConsoleColor color)
        {
            Name = name;
            DropChance = chance;
            Color = color;
        }

        public static bool operator ==(Rarity l, Rarity r)
        {
            return (l.Name == r.Name);
        }

        public static bool operator !=(Rarity l, Rarity r)
        {
            return !(l == r);
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

    public static class Rarities
    {
        public static Rarity Common = new Rarity("Common", 20, ConsoleColor.White);
        public static Rarity Uncommon = new Rarity("Uncommon", 8, ConsoleColor.Blue);
        public static Rarity Legendary = new Rarity("Legendary", 3, ConsoleColor.Yellow);
        public static Rarity Arcane = new Rarity("Arcane", 0.5, ConsoleColor.Magenta);
    }
}