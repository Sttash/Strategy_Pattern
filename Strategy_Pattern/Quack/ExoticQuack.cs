using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Quack
{
    public class ExoticQuack : IQuackable // реализация интерфейса для ExoticDuck
    {
        public void Quack() // реализация единственного метода интерфейса
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
