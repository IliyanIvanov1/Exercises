using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarsLeva
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollar = double.Parse(Console.ReadLine());
            var leva = dollar * 1.79549;
            Console.Write(Math.Round(leva,2));
            Console.WriteLine(" BGN");
        }
    }
}
