using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    class RubberDuck : DuckBase, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a rubber duck!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
