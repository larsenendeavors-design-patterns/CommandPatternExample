using System;

namespace CommandPatternExample.Objects
{
    public class SwitchBoard
    {
        public static DeviceButton GetButtonPressed(ElectronicDevice device)
        {
            Console.WriteLine("Which button do you press?");
            Console.WriteLine("O: Tv On");
            Console.WriteLine("P: Tv Off");
            Console.WriteLine("U: Volume Up.");
            Console.WriteLine("D: Volume Down.");
            
            try
            {
                var input = Console.ReadLine() ?? " ";
                var sanitizedInput = input.ToUpper().ToCharArray()[0];
                return sanitizedInput switch
                {
                    'O' => new DeviceButton(new TurnTvOn(device)),
                    'P' => new DeviceButton(new TurnTvOff(device)),
                    'U' => new DeviceButton(new TurnTvUp(device)),
                    'D' => new DeviceButton(new TurnTvDown(device)),
                    _ => throw new Exception("No Command related to " + sanitizedInput + " key.")
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}