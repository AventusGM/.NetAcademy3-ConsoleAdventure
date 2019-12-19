using System;
using System.Collections.Generic;

namespace ConsoleAdventure.Core.Game.Level
{
    class Level
    {
        //TODO: Add coordinates

        public string Name { get; set; }
        public int EnemiesCount { get; set; }

        public Level()
        {
        }

        public Level(int enemies)
        {
            EnemiesCount = enemies;
        }

    }
}
