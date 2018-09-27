using SensorLogic;
using SensorLogic.Interfaces;

namespace SensorImplementationB
{
    public class Sensor : ISensor
    {
        private double _value;
        public Sensor(double value)
        {
            _value = value;
        }

        public string Name => "Implementation of Type B";
        public double Calculate()
        {
            return _value;
        }
    }
}
