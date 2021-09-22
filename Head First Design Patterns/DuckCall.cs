using System;

namespace Head_First_Design_Patterns
{
    public class DuckCall : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("kwak");
        }
    }
}
