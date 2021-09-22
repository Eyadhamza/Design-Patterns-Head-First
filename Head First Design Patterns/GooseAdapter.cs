namespace Head_First_Design_Patterns
{
    public class GooseAdapter : IQuackBehavior
    {
        private Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void DoQuack()
        {
            _goose.Honk();
        }
    }
}
