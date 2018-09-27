using System;
using System.Collections.Generic;
using SensorLogic.Interfaces;

namespace SensorLogic
{
    public class CheckStatus
    {
        private List<ISensor> _sensors;
        private IAlertOperation _alert;
        
        public CheckStatus(List<ISensor> sensoren, IAlertOperation alert)
        {
            _sensors = sensoren;
            _alert = alert;
        }

        public void Operate(double grenzWert)
        {
            List<ISensor> alertedSensors = new List<ISensor>();

            foreach (ISensor sensor in _sensors)
            {
                var wert = sensor.Calculate();

                if (wert > grenzWert)
                {
                    _alert.GiveAlert($"Sensor {sensor.Name} hat den Grenzwert von {grenzWert} überschrieten");
                    alertedSensors.Add(sensor);
                }
            }
        }

        //public void ProtokollSensors(List<ISensor> sensors)
        //{
        //    var message = $"Eswurden {sensors.Count} ausgelöst mit den Nachrichten \"{string.Join(", ", sensors)}\"";

        //    _protokolAlert.ProtokollAlert(DateTime.Now, message);
        //}
    }
}
