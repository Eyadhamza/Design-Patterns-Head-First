using System;

namespace Head_First_Design_Patterns
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea!");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk and other stuff");
        }
    }
}
