using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Fly
{
    public class NoFly : IFlyable // класс, реализующий интерфейс полёта (вариант для нелетающих)
    {
        public void Fly()
        {
            Console.WriteLine("---");
        }
    }
}
