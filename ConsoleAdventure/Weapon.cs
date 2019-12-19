namespace ConsoleAdventure
{
    public class Weapon : Item
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Speed { get; set; }

        public Weapon(string name, double damage, double speed, Rarity rarity, double weight) 
            : base(rarity, weight)
        {
            Name = name;
            Damage = damage;
            Speed = speed;
        }
    }

    public static class Weapons
    {
        public static Weapon WoodenStick = new Weapon("Wooden stick", 1.0, 10, Rarities.Common, 0.4);
        public static Weapon ShortSword = new Weapon("Short sword", 5.0, 8, Rarities.Common, 2);
    }
}