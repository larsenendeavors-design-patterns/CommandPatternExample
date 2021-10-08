namespace CommandPatternExample.Objects
{
    public class TvRemote
    {
        public static ElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}