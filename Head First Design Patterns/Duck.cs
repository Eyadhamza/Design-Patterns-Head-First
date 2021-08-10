namespace Head_First_Design_Patterns
{
    public abstract class Duck
    {
        protected IQuackBehavior QuackBehavior;
        protected IFlyBehavior FlyBehavior;

        public void PerformQuack()
        {
            QuackBehavior.quack();
        }
        public void PerformFly()
        {
            FlyBehavior.fly();
        }
    }
}
