namespace Head_First_Design_Patterns
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public string Description
        {
            get => _description + "Mocha";
            set => _description = value;
        }
        public override double Cost()
        {
            // delegate the call to know the cost to the beverage object
            return _beverage.Cost() + .20;
        }
    }
}
