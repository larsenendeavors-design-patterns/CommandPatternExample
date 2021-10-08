namespace CommandPatternExample.Objects
{
    public class TurnTvDown : Command
    {
        private ElectronicDevice ElectronicDevice { get; set; }

        public TurnTvDown(ElectronicDevice electronicDevice)
        {
            ElectronicDevice = electronicDevice;
        }

        public void Execute()
        {
            ElectronicDevice.VolumeDown();
        }
    }
}