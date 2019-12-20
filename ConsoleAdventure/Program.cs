using System;
using System.Threading;

namespace ConsoleAdventure
{
    class Program
    {
        bool running;
        Player player;
        InputHandler input;

        static void Main(string[] args)
        {
            new Program().Start();

            Console.ReadKey();
        }

        void Start()
        {
            running = true;
            input = new InputHandler();

            Menu();
            while (running)
            {
                input.Handle();
            }
        }

        void Menu()
        {
            string[] locations = { "Forest", "Mountains", "Cave", "Sea" };

            Console.WriteLine("Welcome to Console Adventure!");
            Console.Write("Input your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!\n");
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
        }

        void Update(Player player)
        {
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
