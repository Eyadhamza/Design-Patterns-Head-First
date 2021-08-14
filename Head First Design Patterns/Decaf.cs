namespace Head_First_Design_Patterns
{
    public class Decaf : Beverage
    {

        public override string Description
        {
            get => "this is Decaf ";

            set { }
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
