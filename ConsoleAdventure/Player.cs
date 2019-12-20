using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
	public class Player : Creature
	{
		public uint Armor { private set; get; }
		public Weapon Weapon
		{
			set
			{
				Weapon = value;

				if (!Inventory.Items.Contains(value))
					AddToInventory(value);
			}
			get => Weapon;
		}
		public Inventory Inventory { private set; get; }
		public uint InventoryCurrent { private set; get; }

		public Player()
		{
			Name = null;
			Health = 100;
			Armor = 0;
			Inventory = new Inventory();
			Inventory.Items.Add(Weapons.Sword);
			InventoryCurrent = 0;
			Weapon = (Weapon)Inventory.Items[0];
		}

		public Player(string name) : this()
		{
			Name = name;
		}

		public void Run()
		{
			Random rand = new Random(2);

			uint damageChance = (uint)rand.Next();

			if (damageChance == 0)
				GetDamage(10);
		}

		public override void Hurt(Creature whoToHurt)
		{
			if (whoToHurt.GetDamage(Weapon.Damage) <= 0)
				Heal(25);
		}

		public override int GetDamage(uint damage)
		{
			if (Armor >= damage)
			{
				Armor -= damage;
			}
			else if (Armor < damage && Armor > 0)
			{
				damage -= Armor;
				Armor = 0;
				Health -= (int)damage;
			}
			else
			{
				Health -= (int)damage;
			}

			return Health;
		}

		public void Heal(uint heal)
		{
			Health += (int)heal;

			if (Health > 100)
				Health = 100;
		}

		public void GetArmor(uint armor)
		{
			Armor += armor;
		}

		public Item AddToInventory(Item item)
		{
			Inventory.Items.Add(item);

			return item;
		}

		public bool RmCurrentFromInventory()
		{
			if (Inventory.Items.Count > 0)
			{
				Inventory.Items.RemoveAt((int)InventoryCurrent);
				return true;
			}
			else
			{
				Console.WriteLine("can not remove the only element from the inventory");
				return false;
			}
		}

		public bool SelectInventoryItem(uint index)
		{
			if (index < Inventory.Items.Count)
			{
				InventoryCurrent = index;

				if (Inventory.Items[(int)InventoryCurrent].GetType() == typeof(Weapon))
					Weapon = (Weapon)Inventory.Items[(int)InventoryCurrent];

				return true;
			}
			else
			{
				return false;
			}
		}

		public void UseCurrentItem()
		{
			if (Inventory.Items[(int)InventoryCurrent].GetType() == typeof(Weapon))
				Console.WriteLine("this is weapon, you can only hurt someone with it");
			else
				Inventory.Items[(int)InventoryCurrent].Use();
		}

		//add coords generate methods
	}
}
