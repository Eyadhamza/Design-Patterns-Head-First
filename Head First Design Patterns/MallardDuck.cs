using System;

namespace Head_First_Design_Patterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
             QuackBehavior = new Quack();
             FlyBehavior = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("I'm a merllad duck ");
        }
    }
}
