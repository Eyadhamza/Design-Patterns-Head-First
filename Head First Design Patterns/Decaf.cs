namespace Head_First_Design_Patterns
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "this is Decaf";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
