using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    class SimpleDuck : DuckBase, IQuackable, IFlyable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a simple duck!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
