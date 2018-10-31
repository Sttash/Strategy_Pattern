using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Quack
{
    public class NoQuack : IQuackable // класс, реализующий интерфейс кряканья (вариант пустой реализации)
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
