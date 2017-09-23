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
            var c = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = c * h / 2;
            Console.Write("Triangle are = ");
            Console.WriteLine(Math.Round(area,2));
        }
    }
}
