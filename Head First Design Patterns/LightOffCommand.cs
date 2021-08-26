namespace Head_First_Design_Patterns
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _livingRoomLight;

        public LightOffCommand(Light livingRoomLight)
        {
            _livingRoomLight = livingRoomLight;
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
