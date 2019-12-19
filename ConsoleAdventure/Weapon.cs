namespace ConsoleAdventure
{
    public class Weapon : Item
    {
        public string Name { get; set; }
        public uint Damage { get; set; }
        public double Speed { get; set; }

        public Weapon(string name, uint damage, double speed, Rarity rarity, double weight) 
            : base(rarity, weight)
        {
            Name = name;
            Damage = damage;
            Speed = speed;
        }
    }

    public static class Weapons
    {
        public static Weapon WoodenStick = new Weapon("Wooden stick", 1, 10, Rarities.Common, 0.4);
        public static Weapon ShortSword = new Weapon("Short sword", 5, 8, Rarities.Common, 2);
    }
}