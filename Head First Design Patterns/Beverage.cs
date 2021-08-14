namespace Head_First_Design_Patterns
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public abstract double Cost();
    }
}
