namespace Head_First_Design_Patterns
{
    public abstract class PizzaStore
    {

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // the factory method returns a product!
        protected abstract Pizza CreatePizza(string type); // factory method is here into play!

        // we count on the subclasses to handle object creation!

    }
}
