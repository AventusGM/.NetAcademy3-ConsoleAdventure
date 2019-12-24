using System;
using System.Collections.Generic;
using System.Text;

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
                    player.MoveUp(location);
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("\tMoving left");
                    player.MoveLeft(location);
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("\tMoving backward");
                    player.MoveDown(location);
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("\tMoving right");
                    player.MoveRight(location);
                    break;
                case ConsoleKey.E:
                    Console.WriteLine("\tUsing item");
                    break;
                case ConsoleKey.M:
                    Console.WriteLine("\tMap");
                    break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("\tFire");
                    break;
                case ConsoleKey.Tab:
                    Console.WriteLine("\tInventory");
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
