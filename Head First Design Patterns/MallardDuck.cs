namespace Head_First_Design_Patterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
             _quackBehavior = new Quack();
             _flyBehavior = new FlyWithWings();
        }
    }
}
