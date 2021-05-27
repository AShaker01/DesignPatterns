using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    public abstract class Duck
    {
        protected IFlyBehaviour FlyBehaviour;
        protected IQuackBehaviour QuackBehaviour;
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            this.FlyBehaviour = flyBehaviour;
        }
        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            this.QuackBehaviour = quackBehaviour;
        }
        public void PerformQuack()
        {
            this.QuackBehaviour.SayQuack();
        }

        public void PerformFly()
        {
            this.FlyBehaviour.Fly();
        }

        public abstract void Display();
    }

    public class MallodDuck : Duck
    {
        public MallodDuck()
        {
            this.QuackBehaviour = new Quack();
            this.FlyBehaviour = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("MallodDuck Display");
        }
    }

    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            this.QuackBehaviour = new Squeak();
            this.FlyBehaviour = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("RedHeadDuck Display");
        }
    }

    public interface IFlyBehaviour
    {
        void Fly();
    }
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly With Wings");
        }
    }

    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Fly NoWay!!");
        }
    }

    public interface IQuackBehaviour
    {
        void SayQuack();
    }
    public class Quack : IQuackBehaviour
    {
        public void SayQuack()
        {
            Console.WriteLine("Say Quack");
        }
    }

    public class Squeak : IQuackBehaviour
    {
        public void SayQuack()
        {
            Console.WriteLine("Say Squack");
        }
    }

}
