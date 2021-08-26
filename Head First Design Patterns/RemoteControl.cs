using System.Text;

namespace Head_First_Design_Patterns
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _currentCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();

            for (int i = 0; i < _onCommands.Length; i++)
            {
                // initialize all slots by a command that does nothing
                _offCommands[i] = noCommand;
                _onCommands[i] = noCommand;

            }

            _currentCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;

        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _currentCommand = _onCommands[slot];
        }
        public void OffButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _currentCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _currentCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < _onCommands.Length; i++) {
                stringBuff.Append("[slot " + i + "] " + _onCommands[i].GetType().Name
                                  + " " + _offCommands[i].GetType().Name + "\n");
            }
            return stringBuff.ToString();

        }
    }
}
