using System;

namespace Head_First_Design_Patterns
{
    public class MuteQuack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("cant quack");
        }
    }
}
