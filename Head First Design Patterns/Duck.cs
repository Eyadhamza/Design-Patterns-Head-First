using System;

namespace Head_First_Design_Patterns
{
    public abstract class Duck
    {
        protected IQuackBehavior QuackBehavior;
        protected IFlyBehavior FlyBehavior;

        public abstract void Display();
        public void PerformQuack()
        {
            QuackBehavior.quack();
        }
        public void PerformFly()
        {
            FlyBehavior.fly();
        }

        public void Swim()
        {
            Console.WriteLine("all ducks swim man");
        }
    }
}
