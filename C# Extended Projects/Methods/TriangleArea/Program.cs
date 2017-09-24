using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleCalcArea(width,height);
            Console.WriteLine(area);
        }

        private static double TriangleCalcArea(double width, double height)
        {
            double result = width * height / 2;
            return result;
            
        }
    }
}
