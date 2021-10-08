namespace CommandPatternExample.Objects
{
    public class TurnTvOn : Command
    {
        private ElectronicDevice ElectronicDevice { get; set; }

        public TurnTvOn(ElectronicDevice electronicDevice)
        {
            ElectronicDevice = electronicDevice;
        }

        public void Execute()
        {
            ElectronicDevice.On();
        }
    }
}