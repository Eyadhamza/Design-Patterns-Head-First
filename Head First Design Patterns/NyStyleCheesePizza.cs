namespace Head_First_Design_Patterns
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            _name = "NY Style sauce and cheesse pizza";
            _dough = "Thin crust dough";
            _sauce = "Marintana sauce";

            _toppings.Add("Grated reggiano cheese");
        }
    }
}
