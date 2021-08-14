namespace Head_First_Design_Patterns
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public string Description
        {
            get => _description + "Soy";
            set => _description = value;
        }
        public override double Cost()
        {
            // delegate the call to know the cost to the beverage object
            return _beverage.Cost() + .15;
        }
    }
}
