using System;

namespace Head_First_Design_Patterns
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I CAN FLY!");
        }
    }
}
