namespace Head_First_Design_Patterns
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "this is espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
