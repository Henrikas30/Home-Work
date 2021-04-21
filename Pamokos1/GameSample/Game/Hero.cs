using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamokos1.GameSample.Game1
{
    class Hero
    {
        private int x;
        private int y;
        private string name;


        public Hero(int x, int y, string name)
        {
            x = x;
            y = y;
            name = name;
        }

        public void MoveRight()
        {
            x++;
        }

        public void MoveLeft()
        {
            x--;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hero {name} is at {x}x{y}");
        }
    }
}
