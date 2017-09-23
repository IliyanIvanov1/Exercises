using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celz_and_Fahr
{
    class Program
    {
        static void Main(string[] args)
        {
            var celz = double.Parse(Console.ReadLine());
            var fahr= (celz * 9) / 5 + 32;
            Console.WriteLine(Math.Round(fahr,2));
        }
    }
}
