namespace ConsoleAdventure
{
    public class Weapon : Item
    {
        public uint Damage { get; set; }
        public double Speed { get; set; }

        public Weapon(string name, uint damage, double speed, Rarity rarity, double weight) 
            : base(name ,rarity, weight)
        {
            Damage = damage;
            Speed = speed;
        }

        public Weapon(Weapon copyFrom)
            : base(copyFrom.Name, copyFrom.Rarity, copyFrom.Weight)
        {
            Damage = copyFrom.Damage;
            Speed = copyFrom.Speed;
        }
    }

    public static class Weapons
    {
        public static readonly Weapon WoodenStick = new Weapon("Wooden stick", 1, 15, Rarities.Common, 0.4);
        public static readonly Weapon ShortSword = new Weapon("Short sword", 5, 10, Rarities.Common, 0.8);
        public static readonly Weapon Sword = new Weapon("Sword", 10, 9, Rarities.Common, 1);
        public static readonly Weapon Claymore = new Weapon("Claymore", 15, 7, Rarities.Uncommon, 2.5);
        public static readonly Weapon SorochaksHammer = new Weapon("Sorochak's Hammer", 100, 6, Rarities.Arcane, 10);
    }
}