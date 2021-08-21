namespace Head_First_Design_Patterns
{
    public class NyStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
               return new NyStyleCheesePizza();
            }

            if (type.Equals("pepperoni"))
            {
                return new NyStylePepperoniPizza();

            }

            if (type.Equals("clam"))
            {
                return new NyStyleClamPizza();

            }

            if (type.Equals("veggie"))
            {
                return new NyStyleVeggiePizza();

            }

            return null;
        }
    }
}
