using System;

namespace Head_First_Design_Patterns
{
    class StarbuzzCoffee
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + "$" + beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());
        }
    }
}
