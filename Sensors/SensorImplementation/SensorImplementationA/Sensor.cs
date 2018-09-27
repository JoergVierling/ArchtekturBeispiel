using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorLogic;
using SensorLogic.Interfaces;

namespace SensorImplementationA
{
    public class Sensor : ISensor
    {
        private double _value;
        public Sensor(double value)
        {
            _value = value;
        }

        public string Name => "Implementation of Type A";
        public double Calculate()
        {
            return _value;
        }
    }
}
