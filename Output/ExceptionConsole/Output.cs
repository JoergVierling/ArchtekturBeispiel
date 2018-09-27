using System;
using SensorLogic;
using SensorLogic.Interfaces;

namespace ExceptionConsole
{
    public class Output : IOutput
    {
        public void GiveAlert(string message)
        {

            throw new Exception(message); 
        }
    }
}
