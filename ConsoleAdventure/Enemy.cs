using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    public class Enemy
    {
        Int32 Health;
        String Name;

        public Int32 health { get; set; }
        public String name
        { get; set; }
        public Enemy()
        {
            Health = health;
            Name = name;
        }
        void getDamage()
        {
            health -= 10;
        }
    }
    public class BigEvilWolf : Enemy
    {
       
    }
}
