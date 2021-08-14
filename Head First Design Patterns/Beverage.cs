namespace Head_First_Design_Patterns
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public abstract string Description { get; set; }
        public abstract double Cost();
    }
}
