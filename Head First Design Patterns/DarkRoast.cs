namespace Head_First_Design_Patterns
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "this is DarkRoast";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
