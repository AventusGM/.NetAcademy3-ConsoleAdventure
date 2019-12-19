using System;
using System.Threading;
using ConsoleAdventure.Core.Game.Entity;
using ConsoleAdventure.Core.Game.Level;

namespace ConsoleAdventure.Core.Game
{
    class Game
    {
        private bool running = false;
        
        Level.Level level;
        Entity.Player player;

        static void Main()
        {
            new Game().Init();
        }

        void Init()
        {
            running = true;
            player = new Entity.Player();

            Menu();
            
            while (running)
            {
                Update(player);
                //Render();
            }
        }


        void Update(Entity.Player player)
        {
            player.Move();
            // handle game loop
        }

        void Render()
        {
            // show text info
        }

        void Menu()
        {
            Console.WriteLine("Welcome to Console Adventure!");
            Console.Write("Input your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("Pick level, where you want to start:");
            Console.WriteLine("[1] Forest");
            Console.WriteLine("[2] Cave");
            Console.WriteLine("[3] Mountain");
            Console.WriteLine("[4] Sea");
            Console.WriteLine("[0] Exit");
            Console.Write("-> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    level = new Forest();
                    break;
                case 2:
                    level = new Cave();
                    break;
                case 3:
                    level = new Mountains();
                    break;
                case 4:
                    level = new Sea();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Loading to " + level.Name);
            Thread.Sleep(1000);
            Console.WriteLine("Done!");
        }

    }
}
