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
            SimpleDuck simpleDuck = new SimpleDuck();
            ExoticDuck exoticDuck = new ExoticDuck();
            
            simpleDuck.Display();
            simpleDuck.Quack();
            simpleDuck.Swim();

            Console.WriteLine();

            exoticDuck.Display();
            exoticDuck.Quack();
            exoticDuck.Swim();

            Console.ReadKey();
        }
    }
}
