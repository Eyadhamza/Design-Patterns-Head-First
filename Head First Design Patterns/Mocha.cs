namespace Head_First_Design_Patterns
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description
        {
            get => _beverage.Description + ", Mocha";
            set => _description = value;
        }
        public override double Cost()
        {
            // delegate the call to know the cost to the beverage object
            return _beverage.Cost() + .20;
        }
    }
}
