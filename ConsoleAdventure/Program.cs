using System;
using System.Threading;

namespace ConsoleAdventure
{
    class Program
    {
        bool running;
        Player player;

        static void Main(string[] args)
        {
            new Program().Start();

            Console.ReadKey();
        }

        void Start()
        {
            running = true;
            
            Menu();
            while (running)
            {
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
        }

        void Update(Player player)
        {
        }
    }
}
