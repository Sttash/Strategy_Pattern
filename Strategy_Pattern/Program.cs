using Strategy_Pattern.Ducks;
using Strategy_Pattern.Fly;
using Strategy_Pattern.Quack;
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
            List<DuckBase> ducks = new List<DuckBase>   // список универсального типа, в данном случае содержит
            {                                           // объекты класса DuckBase
                new ExoticDuck(),
                new SimpleDuck(),
                new WoodenDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks) // вызов всех методов каждого объекта
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }

            DuckBase upgradableDuck = new UpgradableDuck(); // динамический объект, поддерживающий изменения
            upgradableDuck.Display();
            upgradableDuck.Swim();
            upgradableDuck.Quack();
            upgradableDuck.Fly();

            upgradableDuck.SetFlyBehaviour(new FlyWithWings()); // пример переопределения непостоянных методов
            upgradableDuck.SetQuackBehaviour(new ExoticQuack());// (переприсваивается нужная реализация интерфейса)
            upgradableDuck.Quack(); // повторный вызов изменённых методов
            upgradableDuck.Fly();

            Console.ReadKey(); // задержка ввода
        }
    }
}
