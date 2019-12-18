using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Location
    {
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public string[] PossibleEnemies { get; set; }

        public Location(string name, int difficulty, string[] possibleEnemies)
        {
            Name = name;
            Difficulty = difficulty;
            PossibleEnemies = possibleEnemies;
        }

        public string GetEnemyName()
        {
            Random random = new Random();
            return PossibleEnemies[random.Next(PossibleEnemies.Length)];
        }
    }
}
