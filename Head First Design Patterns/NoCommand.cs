﻿namespace Head_First_Design_Patterns
{
    public class NoCommand : ICommand
    {
        public NoCommand()
        {

        }
        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}