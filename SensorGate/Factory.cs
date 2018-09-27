using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using FileSaver;
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
            ConsoleA output = new ConsoleA();
            var protokolEngine = new FileAlert(System.Environment.CurrentDirectory);

            CheckStatus logic = new CheckStatus(sensors, output, protokolEngine);

            return logic;
        }
    }
}
