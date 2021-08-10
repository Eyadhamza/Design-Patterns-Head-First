using System;

namespace Head_First_Design_Patterns
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("cant quack");
        }
    }
}
