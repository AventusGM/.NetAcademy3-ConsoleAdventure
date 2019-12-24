using System;

namespace ConsoleAdventure
{
    public class Weapon : Item, ICloneable
    {
        public uint Damage { get; set; }

        public Weapon(string name, uint damage, Rarity rarity, double weight) 
            : base(name ,rarity, weight)
        {
            Damage = damage;
        }

        public Weapon(Weapon copyFrom)
            : this(copyFrom.Name, copyFrom.Damage, copyFrom.Rarity, copyFrom.Weight)
        { }

        public new object Clone()
        {
            return new Weapon(this);
        }
    }

    /// <summary>
    /// Contains samples of predefined weapons, do not reference to this objects, copy only.
    /// </summary>
    //public static class Weapons
    //{
    //    public static readonly Weapon WoodenClub = new Weapon("Wooden club", 1, Rarities.Common, 0.4);
    //    public static readonly Weapon ShortSword = new Weapon("Short sword", 2, Rarities.Common, 0.8);
    //    public static readonly Weapon LongSword = new Weapon("Long sword", 5, Rarities.Common, 1.2);
    //    public static readonly Weapon Sword = new Weapon("Sword", 5, Rarities.Common, 1);
    //    public static readonly Weapon Axe = new Weapon("Axe", 6, Rarities.Common, 2.9);
    //    public static readonly Weapon Rapier = new Weapon("Rapier", 12, Rarities.Uncommon, 1.7);
    //    public static readonly Weapon Claymore = new Weapon("Claymore", 10, Rarities.Uncommon, 2.5);
    //    public static readonly Weapon BroadSword = new Weapon("Broad sword", 10, Rarities.Uncommon, 2);
    //    public static readonly Weapon Morgenstern = new Weapon("Morgenstern", 20, Rarities.Legendary, 3);
    //    public static readonly Weapon ShadowBlade = new Weapon("Shadow Blade", 20, Rarities.Legendary, 1.3);
    //    public static readonly Weapon BoikosSpear = new Weapon("Boiko's Spear", 100, Rarities.Arcane, 5);
    //    public static readonly Weapon SorochaksHammer = new Weapon("Sorochak's Hammer", uint.MaxValue, Rarities.Arcane, 20);
    //    static Weapons()
    //    {
    //        Item.DefinedItems.AddRange(
    //        new Weapon[]
    //        {
    //            WoodenClub,
    //            ShortSword,
    //            LongSword,
    //            Sword,
    //            Axe,
    //            Rapier,
    //            Claymore,
    //            BroadSword,
    //            Morgenstern,
    //            ShadowBlade,
    //            BoikosSpear,
    //            SorochaksHammer,
    //        });
    //    }
    //}
}