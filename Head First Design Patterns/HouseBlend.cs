namespace Head_First_Design_Patterns
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "this is House Blend";
        }
        public override double Cost()
        {
            return .89;
        }
    }
}
