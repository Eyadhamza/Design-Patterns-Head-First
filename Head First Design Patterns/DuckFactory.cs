namespace Head_First_Design_Patterns
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackBehavior CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackBehavior CreateRedHeadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackBehavior CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackBehavior CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
