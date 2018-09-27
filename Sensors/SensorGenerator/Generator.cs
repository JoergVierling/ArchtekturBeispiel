using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SensorLogic;
using SensorLogic.Interfaces;
using SensorA = SensorImplementationA.Sensor;
using SensorB = SensorImplementationB.Sensor;


namespace SensorGenerator
{
    public static class Generator
    {
        public static IEnumerable<ISensor> Generate()
        {
            yield return new SensorA(3);
            yield return new SensorB(2);
        }
    }
}
