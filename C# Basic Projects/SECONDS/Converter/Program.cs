using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();

            var intermediateMetric = inputNumber;

            #region Input
            if (inputMetric == "mm")
            {
                intermediateMetric = inputNumber / 1000;
            }
            else if (inputMetric == "cm")
            {
                intermediateMetric = inputNumber / 100;
            }
            else if (inputMetric == "mi")
            {
                intermediateMetric = inputNumber / 0.000621371192;
            }
            else if (inputMetric == "in")
            {
                intermediateMetric = inputNumber / 39.3700787;
            }
            else if (inputMetric == "km")
            {
                intermediateMetric = inputNumber / 0.001;
            }
            else if (inputMetric == "ft")
            {
                intermediateMetric = inputNumber / 3.2808399;
            }
            else if (inputMetric == "yd")
            {
                intermediateMetric = inputNumber / 1.0936133;
            }

            #endregion
            var finalNumber = 0.0;
            #region Output
            if (outputMetric == "mm")
            {
                finalNumber = intermediateMetric * 1000;
            }
            else if (outputMetric == "cm")
            {
                finalNumber = intermediateMetric * 100;
            }
            else if (outputMetric == "mi")
            {
                finalNumber = intermediateMetric * 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                finalNumber = intermediateMetric * 39.3700787;
            }
            else if (outputMetric == "km")
            {
                finalNumber = intermediateMetric * 0.001;
            }
            else if (outputMetric == "ft")
            {
                finalNumber = intermediateMetric * 3.2808399;
            }
            else if (outputMetric == "yd")
            {
                finalNumber = intermediateMetric * 1.0936133;
            }
            else if (outputMetric == "m")
            {
                finalNumber = intermediateMetric;
            }
            #endregion
            Console.WriteLine($"{finalNumber} {outputMetric}" );
        }
    }
}
