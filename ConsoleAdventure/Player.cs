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
		public Inventory Inventory { private set; get; }
		public Item CurrentItem { set; get; }
		public QuestManager QuestManager { get; }

		public event EventHandler<KilledTheCreatureEventArgs> KilledTheCreature;

		public Player()
		{
			Name = null;
			Health = 100;
			Armor = 0;
			Inventory = new Inventory();
			CurrentItem = PredefinedObjects.FindItem("Wooden club");
			Coords = null;
			QuestManager = new QuestManager(this);
		}

		public Player(string name) : this()
		{
			Name = name;
		}

		public Player(string name, List<Coords?> otherCreaturesAndObjects, Location location) : this(name)
		{
			try
			{
				GenerateCoords(otherCreaturesAndObjects, location);
			}
			catch (ArgumentNullException)
			{
				throw;
			}
			catch (ArgumentException)
			{
				throw;
			}
			catch (Exception)
			{
				throw;
			}
		}

		protected virtual void OnKilledTheCreature(KilledTheCreatureEventArgs e)
		{
			EventHandler<KilledTheCreatureEventArgs> handler = KilledTheCreature;

			if (handler != null)
				handler(this, e);
		}

		public bool Run()
		{
			Random rand = new Random(2);

			int damageRandomizer = rand.Next();

			if (damageRandomizer != 0)
			{
				return true;
			}
			else
			{
				GetDamage(10);

				return false;
			}
		}

		public override void Hurt(Creature whoToHurt)
		{
			if (whoToHurt == null)
				throw new ArgumentNullException(nameof(whoToHurt));

			if (CurrentItem.GetType() == typeof(Weapon))
			{
				if (whoToHurt.GetDamage(((Weapon)CurrentItem).Damage) <= 0)
				{
					Heal(20);

					Inventory.Items.Concat(LootController.GetCreatureLoot(whoToHurt));

					KilledTheCreatureEventArgs args = new KilledTheCreatureEventArgs(whoToHurt);
					OnKilledTheCreature(args);
				}
			}
			else
			{
				if (whoToHurt.GetDamage(1) <= 0)
				{
					Heal(25);

					Inventory.Items.Concat(LootController.GetCreatureLoot(whoToHurt));

					KilledTheCreatureEventArgs args = new KilledTheCreatureEventArgs(whoToHurt);
					OnKilledTheCreature(args);
				}
			}
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

		public void SelectInventoryItem(int index) //you can use Inventory.Items.IndexOf()
		{
			if (index < 0 || index > Inventory.Items.Count)
				throw new IndexOutOfRangeException("public bool SelectInventoryItem(int index) in Class Player: index argument was outside of the bounds");

			Inventory.Items.Add(CurrentItem);

			CurrentItem = Inventory.Items[index];

			Inventory.Items.RemoveAt(index);
		}

		public bool UseCurrentItem()
		{
			if (CurrentItem is IUsable)
			{
				((IUsable)CurrentItem).Use(this);

				return true;
			}
			else
			{
				return false;
			}
		}

		public override bool MoveUp(Location currentLocation)
		{
			if (Coords == null)
				throw new NullReferenceException("public override bool MoveUp(Location currentLocation) in Class Player: Coords was null");

			if (currentLocation == null)
				throw new ArgumentNullException(nameof(currentLocation));

			Coords potentialCoords = new Coords
			{
				X = Coords.Value.X,
				Y = Coords.Value.Y
			};

			--potentialCoords.Y;

			if (potentialCoords.Y >= 0 && potentialCoords.Y < currentLocation.Size)
			{
				Coords = potentialCoords;
				return true;
			}

			return false;
		}

		public override bool MoveDown(Location currentLocation)
		{
			if (Coords == null)
				throw new NullReferenceException("public override bool MoveDown(Location currentLocation) in Class Player: Coords was null");

			if (currentLocation == null)
				throw new ArgumentNullException(nameof(currentLocation));

			Coords potentialCoords = new Coords
			{
				X = Coords.Value.X,
				Y = Coords.Value.Y
			};

			++potentialCoords.Y;

			if (potentialCoords.Y >= 0 && potentialCoords.Y < currentLocation.Size)
			{
				Coords = potentialCoords;
				return true;
			}

			return false;
		}

		public override bool MoveLeft(Location currentLocation)
		{
			if (Coords == null)
				throw new NullReferenceException("public override bool MoveLeft(Location currentLocation) in Class Player: Coords was null");

			if (currentLocation == null)
				throw new ArgumentNullException(nameof(currentLocation));

			Coords potentialCoords = new Coords
			{
				X = Coords.Value.X,
				Y = Coords.Value.Y
			};

			--potentialCoords.X;

			if (potentialCoords.X >= 0 && potentialCoords.X < currentLocation.Size)
			{
				Coords = potentialCoords;
				return true;
			}

			return false;
		}

		public override bool MoveRight(Location currentLocation)
		{
			if (Coords == null)
				throw new NullReferenceException("public override bool MoveRight(Location currentLocation) in Class Player: Coords was null");

			if (currentLocation == null)
				throw new ArgumentNullException(nameof(currentLocation));

			Coords potentialCoords = new Coords
			{
				X = Coords.Value.X,
				Y = Coords.Value.Y
			};

			++potentialCoords.X;

			if (potentialCoords.X >= 0 && potentialCoords.X < currentLocation.Size)
			{
				Coords = potentialCoords;
				return true;
			}

			return false;
		}
	}
}
