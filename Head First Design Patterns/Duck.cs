namespace Head_First_Design_Patterns
{
    public abstract class Duck
    {
        protected IQuackBehavior _quackBehavior;
        protected IFlyBehavior _flyBehavior;
    }
}
