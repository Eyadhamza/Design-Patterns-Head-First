using System;

namespace Head_First_Design_Patterns
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the coffee!");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk and other stuff related to coffee ");
        }
    }
}
