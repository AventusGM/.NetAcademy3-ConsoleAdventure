using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAdventure.Display;

namespace ConsoleAdventure
{
    class InputHandler
    {
        public void Handle(Player player, Location location)
        {
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.W:
                    Console.WriteLine("\tMoving forward");
                    if (!player.MoveUp(location))
                        Console.WriteLine("End of the map!");

                    break;
                case ConsoleKey.A:
                    Console.WriteLine("\tMoving left");
                    if (!player.MoveLeft(location))
                        Console.WriteLine("End of the map!"); 

                    break;
                case ConsoleKey.S:
                    Console.WriteLine("\tMoving backward");
                    if (!player.MoveDown(location))
                        Console.WriteLine("End of the map!");

                    break;
                case ConsoleKey.D:
                    Console.WriteLine("\tMoving right");
                    if (!player.MoveRight(location))
                        Console.WriteLine("End of the map!");

                    break;
                case ConsoleKey.E:
                    Console.WriteLine("\tUsing item");
                    if (player.UseCurrentItem())
                        Console.WriteLine("You can't use item!");

                    break;
                case ConsoleKey.M:
                    Console.WriteLine("\tMap");
                    Console.WriteLine("X: " + player.Coords.Value.X + " | Y: " + player.Coords.Value.Y);
                    break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("\tFire");
                    break;
                case ConsoleKey.Tab:
                    Console.WriteLine("\tInventory");
                    InventoryDisplay.DisplayInventory(player);
                    break;
                case ConsoleKey.H:
                    Console.Clear();
                    Program.ShowHelp();
                    break;
                default:
                    Console.WriteLine("\tInvalid operation!");
                    break;
            }
        }
    }
}
