using System;

namespace Head_First_Design_Patterns
{
    public class RedheadDuck : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
