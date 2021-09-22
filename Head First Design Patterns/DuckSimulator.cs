using System;

namespace Head_First_Design_Patterns
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator duckSimulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            duckSimulator.Simulate(duckFactory);

        }

        private void Simulate(AbstractDuckFactory abstractDuckFactory)
        {
            IQuackBehavior mallardDuck = abstractDuckFactory.CreateMallardDuck();
            IQuackBehavior redheadDuck = abstractDuckFactory.CreateRedHeadDuck();
            IQuackBehavior duckCall = abstractDuckFactory.CreateDuckCall();
            IQuackBehavior rubberDuck = abstractDuckFactory.CreateRubberDuck();
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
