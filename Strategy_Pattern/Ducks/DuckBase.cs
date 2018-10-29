using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public abstract class DuckBase
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }

        public void Swim()
        {
            Console.WriteLine("I can swim!");
        }

        public abstract void Display();
    }
}
