using System;
using SensorLogic;
using SensorLogic.Interfaces;

namespace ConsolOutput
{
    public class Output : IOutput
    {
        public void GiveAlert(string message)
        {
            Console.WriteLine(message);
        }
    }
}
