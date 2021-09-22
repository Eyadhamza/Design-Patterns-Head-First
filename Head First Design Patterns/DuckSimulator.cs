using System;

namespace Head_First_Design_Patterns
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator duckSimulator = new DuckSimulator();

            duckSimulator.Simulate();

        }

        private void Simulate()
        {
            IQuackBehavior mallardDuck = new MallardDuck();
            IQuackBehavior redheadDuck = new RedheadDuck();
            IQuackBehavior duckCall = new DuckCall();
            IQuackBehavior rubberDuck = new RubberDuck();
            IQuackBehavior goose = new GooseAdapter(new Goose());

            Console.WriteLine("\n Duck Simulator");
            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(goose);
        }

        private void Simulate(IQuackBehavior duck)
        {
            duck.DoQuack();
        }
    }
}
