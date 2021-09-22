namespace Head_First_Design_Patterns
{
    public class QuackCounter : IQuackBehavior
    {
        private IQuackBehavior _duck;
        public static int NumberOfQuacks { get; set; }

        public QuackCounter(IQuackBehavior duck)
        {
            _duck = duck;
        }
        public void DoQuack()
        {
            _duck.DoQuack();
            NumberOfQuacks++;
        }
    }
}
