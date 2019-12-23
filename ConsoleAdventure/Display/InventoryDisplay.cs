using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.Display
{
    public static class InventoryDisplay
    {
        public static void DisplayInventory(Player player)
        {
            Inventory inventory = player.Inventory;
            if(inventory.Items.Count > 0)
            {
                int maxStr = inventory.Items.Max(i => i.Name.Length);
                int it = 1;
                Console.Write("╔══"); for (int i = 0; i < maxStr+inventory.Items.Count.ToString().Length+3; i++) Console.Write("═"); Console.WriteLine("══╗");
                foreach (Item item in inventory.Items)
                {
                    Console.Write("║  [{0}] ",it);
                    Console.ForegroundColor = item.Rarity.Color;
                    Console.Write(item.Name);
                    for (int j = 0; j < maxStr - item.Name.Length; j++) Console.Write(" ");
                    Console.ResetColor();
                    Console.WriteLine("  ║");
                    it++;
                }
                Console.Write("║  "); for (int j = 0; j < maxStr - inventory.TotalWeight.ToString().Length + inventory.Items.Count.ToString().Length+1; j++) Console.Write(" "); Console.WriteLine("{0}kg  ║", inventory.TotalWeight);
                Console.Write("╚══"); for (int i = 0; i < maxStr+inventory.Items.Count.ToString().Length + 3; i++) Console.Write("═"); Console.WriteLine("══╝");
                HandleInput(player);
            }
        }

        private static void HandleInput(Player player)
        {

        ReadItemInput:
            int itemIndex = (int)char.GetNumericValue(Console.ReadKey().KeyChar) - 1;
            if (itemIndex != null && itemIndex >= 0 && itemIndex < player.Inventory.Items.Count)
            {
                ItemHandleActions(player, player.Inventory.Items[itemIndex]);
            }
            else
            {
                goto ReadItemInput;
            }
        }

        private static void ItemHandleActions(Player player, Item item)
        {
            Console.ForegroundColor = item.Rarity.Color;
            Console.WriteLine("[{0}]", item.Name);
            Console.ResetColor();
            if(item is IUsable)
            {
                Console.WriteLine("[U] - Use");
            }
            if(item is Weapon)
            {
                Console.WriteLine("[E] - Equip");
            }

            ConsoleKey pressedKey = Console.ReadKey().Key;
            switch(pressedKey)
            {
                case ConsoleKey.U:
                    if (item is IUsable) ((IUsable)item).Use(player);
                    break;
                //case ConsoleKey.E:
                //    if (item is Weapon) // change player weapon.
                //        break;
            }
        }
    }
}
