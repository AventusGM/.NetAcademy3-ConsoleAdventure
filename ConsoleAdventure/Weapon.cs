namespace ConsoleAdventure
{
    public class Weapon
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Speed { get; set; }
        public Rarity Rarity { get; set; }

        public Weapon(string name, double damage, double speed, Rarity rarity)
        {
            Name = name;
            Damage = damage;
            Speed = speed;
            Rarity = rarity;
        }
    }

    public static sealed class Weapons
    {
        public static Weapon WoodenStick = new Weapon("Wooden stick", 1.0, 10, Rarities.Common);
        public static Weapon ShortSword = new Weapon("Short sword", 5.0, 8, Rarities.Common);
    }
}