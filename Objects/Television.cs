using System;

namespace CommandPatternExample.Objects
{
    public class Television : ElectronicDevice
    {
        private int _volume = 0;
        
        public void On()
        {
            Console.WriteLine("Tv is On!");
        }

        public void Off()
        {
            Console.WriteLine("Tv is Off!");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Volume increasing from " + _volume + " to " + ++_volume + "!");
            _volume = _volume++;
        }

        public void VolumeDown()
        {
            Console.WriteLine("Volume decreasing from " + _volume + " to " + --_volume + "!");
            _volume = _volume--;
        }
    }
}