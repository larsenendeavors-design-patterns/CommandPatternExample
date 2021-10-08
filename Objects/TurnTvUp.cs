namespace CommandPatternExample.Objects
{
    public class TurnTvUp : Command
    {
        private ElectronicDevice ElectronicDevice { get; set; }

        public TurnTvUp(ElectronicDevice electronicDevice)
        {
            ElectronicDevice = electronicDevice;
        }

        public void Execute()
        {
            ElectronicDevice.VolumeUp();
        }
    }
}