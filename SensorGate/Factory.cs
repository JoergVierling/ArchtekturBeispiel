using System.Collections.Generic;
using System.Linq;
using SensorGenerator;
using SensorLogic;
using SensorLogic.Interfaces;
using ConsoleA = ConsolOutput.Output;

namespace SensorGate
{
    public class Factory
    {
        public static CheckStatus Build()
        {
            List<ISensor> sensors = Generator.Generate().ToList();
            var output = new ConsoleA();

            CheckStatus logic = new CheckStatus(sensors, output);

            return logic;
        }
    }
}
