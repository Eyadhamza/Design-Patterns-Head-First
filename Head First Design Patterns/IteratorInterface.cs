﻿namespace Head_First_Design_Patterns
{
    public interface IIterator
    {
        public bool HasNext();
        public MenuItem Next();
    }
}
