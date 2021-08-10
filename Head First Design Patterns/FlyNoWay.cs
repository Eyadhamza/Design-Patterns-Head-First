using System;

namespace Head_First_Design_Patterns
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("CANT FLY!");
        }
    }
}
