namespace Head_First_Design_Patterns
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackBehavior CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackBehavior CreateRedHeadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackBehavior CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackBehavior CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
