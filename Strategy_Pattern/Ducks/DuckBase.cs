using Strategy_Pattern.Fly;
using Strategy_Pattern.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;

        public DuckBase()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }

        public virtual void Quack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("I can swim!");
        }

        public virtual void Fly()
        {
            flyBehaviour.Fly();
        }

        public abstract void Display();
    }
}
