namespace Head_First_Design_Patterns
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description
        {
            get => _beverage.Description + ", Whip";
            set => _description = value;
        }

        // public string Description()
        // {
        //     // delegate the call to know the description to the beverage object
        //     // then we add whip to it
        //     return _beverage.Description + "Whip";
        // }

        public override double Cost()
        {
            // delegate the call to know the cost to the beverage object
            // then we add the cost to it
            return _beverage.Cost() + .10;
        }
    }
}
