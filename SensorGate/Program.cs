using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorGate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sensors");

            Factory.Build().Operate(2);

            Console.ReadLine();
        }
    }
}
