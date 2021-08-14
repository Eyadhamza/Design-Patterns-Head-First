﻿namespace Head_First_Design_Patterns
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        public override string Description
        {
            get => _description;
            set => _description = value;
        }

    }
}
