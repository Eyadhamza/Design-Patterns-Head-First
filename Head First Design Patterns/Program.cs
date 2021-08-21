using System;

namespace Head_First_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nystore = new NyStylePizzaStore();

            Pizza pizza = nystore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.Name);
        }
    }
}
