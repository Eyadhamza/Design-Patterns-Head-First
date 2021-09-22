namespace Head_First_Design_Patterns
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackBehavior CreateMallardDuck();
        public abstract IQuackBehavior CreateRedHeadDuck();
        public abstract IQuackBehavior CreateDuckCall();
        public abstract IQuackBehavior CreateRubberDuck();

    }
}
