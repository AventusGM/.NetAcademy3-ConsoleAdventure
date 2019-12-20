using System;
using System.Threading;

namespace ConsoleAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();

            Console.ReadKey();
        }

        public static void Init()
        {
            string[] locations = { "forest", "mountains", "cave", "sea" };

            Console.WriteLine("Welcome to Random Adventure!");
            Console.WriteLine("____________________________");
            Console.Write("Input here name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!\n");

            Console.WriteLine("Here is list of available locations:");
            foreach (var loc in locations)
            {
                Console.WriteLine("\t->" + loc);
            }
            Console.WriteLine("Input location, where you want to relocate: ");

            string input = Console.ReadLine();
            input.ToLower();
            foreach (var loc in locations)
            {
                if (input == loc)
                {
                    Console.WriteLine("You've been move to " + loc + " in a while");
                    Thread.Sleep(3000);
                    Console.WriteLine("You in " + loc + "!");
                }
            }
        }
    }
}
