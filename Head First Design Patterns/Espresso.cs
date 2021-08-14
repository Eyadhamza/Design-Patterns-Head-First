namespace Head_First_Design_Patterns
{
    public class Espresso : Beverage
    {

        public override string Description
        {
            get => "this is espresso ";

            set { }
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
