using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
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

        public Location(string title, uint size)
        {
            Title = title;
            this.size = size;

            //generate coords for player and enemy?
        }

        //add overloaded constructors (with name or player object etc)?

        public Coords GeneratePlayerCoords(Coords? enemyCoords) //move it to Creature as an abstract method
        {
            Random rand = new Random((int)size - 1);
            Coords playerCoords;

            if (enemyCoords == null)
            {
                playerCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
            }
            else
            {
                do
                {
                    playerCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
                } while (enemyCoords.Value.x == playerCoords.x && enemyCoords.Value.y == playerCoords.y);
            }

            return playerCoords;
        }

        public Coords GenerateEnemyCoords(Coords? playerCoords) //move it to Creature as an abstract method
        {
            Random rand = new Random((int)size - 1);
            Coords enemyCoords;

            if (playerCoords == null)
            {
                enemyCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
            }
            else
            {
                do
                {
                    enemyCoords = new Coords((uint)rand.Next(), (uint)rand.Next());
                } while (enemyCoords.x == playerCoords.Value.x && enemyCoords.y == playerCoords.Value.y);
            }

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
