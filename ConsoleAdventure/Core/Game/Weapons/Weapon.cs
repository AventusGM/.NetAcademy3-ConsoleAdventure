namespace ConsoleAdventure.Core.Game.Weapons
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon()
        {
            Name = "Hands";
            Damage = 5;
        }

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public int Hit()
        {
            return Damage;
        }
    }
}