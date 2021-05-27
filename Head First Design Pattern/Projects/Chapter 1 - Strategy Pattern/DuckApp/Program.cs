using System;

namespace DuckApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck mallodDuck = new MallodDuck();
            mallodDuck.Display();
            mallodDuck.PerformFly();
            mallodDuck.PerformQuack();

            // change flying and quack behviour at run time.
            mallodDuck.SetFlyBehaviour(new FlyNoWay());
            mallodDuck.SetQuackBehaviour(new Squeak());
            mallodDuck.PerformFly();
            mallodDuck.PerformQuack();

            Duck redHeadDuck = new RedHeadDuck();
            redHeadDuck.Display();
            redHeadDuck.PerformFly();
            redHeadDuck.PerformQuack();

            Console.ReadLine();
        }
    }
}
