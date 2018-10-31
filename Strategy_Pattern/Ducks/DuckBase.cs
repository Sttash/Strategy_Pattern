using Strategy_Pattern.Fly;
using Strategy_Pattern.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    public abstract class DuckBase // базовый класс утки
    {
        protected IFlyable flyBehaviour;        // интерфейсные поля, предназначенные
        protected IQuackable quackBehaviour;    // для переопределения в тех классах, где это необходимо

        public DuckBase()   // конструктор по умолчанию
        {
            flyBehaviour = new FlyWithWings();  // поведение "полёт" по умолчанию
            quackBehaviour = new SimpleQuack(); // поведение "кряканье" по умолчанию
        }

        public void SetQuackBehaviour(IQuackable newQuackBehaviour) // метод для динамического переопределения кряканья
        {
            quackBehaviour = newQuackBehaviour;
        }

        public void SetFlyBehaviour(IFlyable newFlyBehaviour)   // метод для динамического переопределения полёта
        {
            flyBehaviour = newFlyBehaviour;
        }

        public void Swim() // этот метод неизменяемый, поэтому реализация одна общая
        {
            Console.WriteLine("I can swim!"); 
        }

        public void Quack() // Quack и Swim - изменяемые методы, каждый класс выполняет подходящую реализацию
        {
            quackBehaviour.Quack(); // выполняется своя реализация интерфейса
        }

        public void Fly()
        {
            flyBehaviour.Fly();
        }

        public abstract void Display(); // абстрактный метод, реализуемый во всех классах по-своему
    }
}
