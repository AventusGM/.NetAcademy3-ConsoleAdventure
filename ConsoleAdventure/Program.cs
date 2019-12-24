using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAdventure
{
    class Program
    {
        bool running;
        Player player;
        Location location;
        InputHandler input;

        List<Coords?> list;
        public static Coords enemy;

        static void Main(string[] args)
        {
            new Program().Start();

            Console.ReadKey();
        }

        void Start()
        {
            foreach(Item item in new TreasureChest(Rarities.Common).Content)
            {
                Console.WriteLine(item.Name);
            }
            
            running = true;
            list = new List<Coords?>();
            input = new InputHandler();
            location = new Location(Menu());
            player = new Player("Player", SpawnEnemies(list, 5) ,location);

            while (running)
            {
                input.Handle(player, location);
            }
        }

        static List<Coords?> SpawnEnemies(List<Coords?> enemies, int count)
        {
            Random rand = new Random();
            List<Coords?> list = new List<Coords?>();

            for (int i = 0; i < count; i++)
            {
                enemy = new Coords(rand.Next(1, 10), rand.Next(1, 10));
                list.Add(enemy);
            }

            return list;
        }

        string Menu()
        {
            string[] locations = { "Forest", "Mountains", "Cave", "Sea" };

            Console.WriteLine("Welcome to Console Adventure!");
            //Console.Write("Input your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + "!\n");
            Console.WriteLine("Available locations: ");

            foreach (var loc in locations)
                Console.WriteLine("\t[ " + loc + " ]");

            Console.Write("Type name of location: ");
            string input = Console.ReadLine();

            foreach (var loc in locations)
            {
                if (input.ToLower() == loc.ToLower())
                {
                    Console.WriteLine("Loading " + loc);
                    Thread.Sleep(1000);
                    Console.WriteLine("Load. Now you in " + loc);
                }
            }
            ShowHelp();
            return input;
        }

        public static void ShowHelp()
        {
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("| Help:                   |");
            Console.WriteLine("| Using WASD for movement |");
            Console.WriteLine("| Tab - inventory         |");
            Console.WriteLine("| Space - attack          |");
            Console.WriteLine("| E - using item          |");
            Console.WriteLine("| M - show map            |");
            Console.WriteLine("+-------------------------+");
        }
    }
}
