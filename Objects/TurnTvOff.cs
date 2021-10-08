namespace CommandPatternExample.Objects
{
    public class TurnTvOff : Command
    {
        private ElectronicDevice ElectronicDevice { get; set; }

        public TurnTvOff(ElectronicDevice electronicDevice)
        {
            ElectronicDevice = electronicDevice;
        }

        public void Execute()
        {
            ElectronicDevice.Off();
        }
    }
}