using System;
using System.Collections.Generic;
using System.Linq;
using SensorLogic.Interfaces;

namespace SensorLogic
{
    public class CheckStatus
    {
        private List<ISensor> _sensors;
        private IOutput _alert;
        private IProtokol _protokolAlert;

        public CheckStatus(List<ISensor> sensoren, IOutput alert, IProtokol protokolAlert)
        {
            _sensors = sensoren;
            _alert = alert;
            _protokolAlert = protokolAlert;
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

            if (alertedSensors.Any())
            {
                ProtokollSensors(alertedSensors);
            }
        }

        public void ProtokollSensors(List<ISensor> sensors)
        {
            var message = $"Eswurden {sensors.Count} ausgelöst mit den Nachrichten \"{string.Join(", ", sensors)}\"";

            _protokolAlert.ProtokollAlert(DateTime.Now, message);
        }
    }
}
