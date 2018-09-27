using System;
using SensorLogic;
using SensorLogic.Interfaces;

namespace ExceptionConsole
{
    public class Output : IAlertOperation
    {
        public void GiveAlert(string message)
        {

            throw new Exception(message); 
        }
    }
}
