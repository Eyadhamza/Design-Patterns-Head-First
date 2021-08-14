namespace Head_First_Design_Patterns
{
    public abstract class CondimentDecorator : Beverage
    {
        private Beverage _beverage;

        public string Description
        {
            get => _description;
            set => _description = value;
        }

    }
}
