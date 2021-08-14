namespace Head_First_Design_Patterns
{
    public class DarkRoast : Beverage
    {


        public override string Description
        {
            get => "this is DarkRoast ";

            set { }
        }


        public override double Cost()
        {
            return .99;
        }
    }
}
