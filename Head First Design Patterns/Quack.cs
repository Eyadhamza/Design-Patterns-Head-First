﻿using System;

namespace Head_First_Design_Patterns
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine(" quack");
        }
    }
}
