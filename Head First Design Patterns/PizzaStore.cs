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

        protected abstract Pizza CreatePizza(string type); // factory method is here into play!
    }
}
