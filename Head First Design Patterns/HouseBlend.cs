namespace Head_First_Design_Patterns
{
    public class HouseBlend : Beverage
    {


        public override string Description
        {
            get => "this is House Blend ";

            set { }
        }


        public override double Cost()
        {
            return .89;
        }
    }
}
