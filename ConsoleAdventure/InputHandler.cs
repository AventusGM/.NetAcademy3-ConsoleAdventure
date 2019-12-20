using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventure
{
    class InputHandler
    {
        public void Handle()
        {
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.W:
                    Console.WriteLine("\tMoving forward");
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("\tMoving left");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("\tMoving backward");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("\tMoving right");
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
