using Strategy_Pattern.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>
            {
                new ExoticDuck(),
                new SimpleDuck()
            };

            foreach (var duckBase in ducks)
            {
                duckBase.Display();
                duckBase.Quack();
                duckBase.Swim();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
