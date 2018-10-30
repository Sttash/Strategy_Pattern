using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    public abstract class DuckBase
    {
        public void Swim()
        {
            Console.WriteLine("I can swim!");
        }

        public abstract void Display();
    }
}
