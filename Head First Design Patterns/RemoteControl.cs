namespace Head_First_Design_Patterns
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand currentCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for (int i = 0; i < _onCommands.Length; i++)
            {
                // initialize all slots by a command that does nothing
                _offCommands[0] = noCommand;
                _onCommands[0] = noCommand;

            }

            currentCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;

        }

    }
}
