using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public struct Coords
    {
        public uint x;
        public uint y;

        public Coords(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Location
    {
        public string Title { get; set; }
        private uint size;
        //Player player { set; get; }?
        //Enemy Enemy { set; get; }?

        protected Location()
        {
            Title = null;
            size = 0;
        }

        public Location(string titlle, uint size)
        {
            Title = titlle;
            this.size = size;

            //generate coords for player and enemy?
        }

        public Coords GeneratePlayerCoords()
        {
            Random rand = new Random((int)size - 1);

            Coords playerCoords = new Coords((uint)rand.Next(), (uint)rand.Next());

            return playerCoords;
        }

        public Coords GenerateEnemyCoords(Coords playerCoords)
        {
            Random rand = new Random((int)size - 1);

            Coords enemyCoords;

            do
            {
                enemyCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
            } while (enemyCoords.x == playerCoords.x && enemyCoords.y == playerCoords.y);

            return enemyCoords;
        }

        /*public int Difficulty { get; set; }
        public string[] PossibleEnemies { get; set; }*/

        /*public Location(string name, int difficulty, string[] possibleEnemies)
        {
            Name = name;
            Difficulty = difficulty;
            PossibleEnemies = possibleEnemies;
        }

        public string GetEnemyName()
        {
            Random random = new Random();
            return PossibleEnemies[random.Next(PossibleEnemies.Length)];
        }*/


    }
}
