namespace ConsoleAdventure
{
    internal class Rarity
    {
        public string Name { get; set; }

        // In %
        public double DropChance { get; set; }

        public Rarity(string name, double chance)
        {
            Name = name;
            DropChance = chance;
        }
    }

    public static class Rarities
    {
        public static Rarity Common = new Rarity("Common", 20);
        public static Rarity Uncommon = new Rarity("Uncommon", 8);
        public static Rarity Legendary = new Rarity("Legendary", 3);
        public static Rarity Arcane = new Rarity("Arcane", 0.5);
    }
}