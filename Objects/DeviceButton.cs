namespace CommandPatternExample.Objects
{
    public class DeviceButton
    {
        private Command Command { get; }

        public DeviceButton(Command command)
        {
            Command = command;
        }

        public void press()
        {
            Command.Execute();
        }
    }
}