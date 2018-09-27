using System;
using SensorLogic;
using SensorLogic.Interfaces;

namespace ConsolOutput
{
    public class Output : IAlertOperation
    {
        public void GiveAlert(string message)
        {
            Console.WriteLine(message);
        }
    }
}
