using System;

namespace Head_First_Design_Patterns
{
    public class RubberDuck : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
