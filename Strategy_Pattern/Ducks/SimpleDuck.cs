using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("I'm a simple duck!");
        }
    }
}
