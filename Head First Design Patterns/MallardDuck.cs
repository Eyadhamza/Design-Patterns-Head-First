using System;

namespace Head_First_Design_Patterns
{
    public class MallardDuck : IQuackBehavior
    {
        public MallardDuck()
        {
        }

        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}
