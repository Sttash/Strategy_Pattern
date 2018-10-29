using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class ExoticDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("I'm an exotic duck!");
        }
    }
}
