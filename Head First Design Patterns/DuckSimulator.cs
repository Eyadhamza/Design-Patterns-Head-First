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
            IQuackBehavior mallardDuck = new QuackCounter(new MallardDuck());
            IQuackBehavior redheadDuck = new QuackCounter(new RedheadDuck());
            IQuackBehavior duckCall = new QuackCounter(new DuckCall());
            IQuackBehavior rubberDuck = new QuackCounter(new RubberDuck());
            IQuackBehavior goose = new GooseAdapter(new Goose());

            Console.WriteLine("\n Duck Simulator");
            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(goose);
            Console.WriteLine("number of quacks = " + QuackCounter.NumberOfQuacks);
        }

        private void Simulate(IQuackBehavior duck)
        {
            duck.DoQuack();
        }
    }
}
