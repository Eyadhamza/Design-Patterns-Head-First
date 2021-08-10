using System;

namespace Head_First_Design_Patterns
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.PerformFly();
            mallard.PerformQuack();
        }
    }
}
