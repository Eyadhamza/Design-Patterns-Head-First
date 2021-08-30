using System;

namespace Head_First_Design_Patterns
{
    public abstract class CaffeineBeverage
    {
        // our template method
        void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        protected virtual void BoilWater()
        {
           Console.WriteLine("Boiling Water");
        }
        protected virtual void PourInCup()
        {
            Console.WriteLine("Pouring in Cup");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();


    }
}
