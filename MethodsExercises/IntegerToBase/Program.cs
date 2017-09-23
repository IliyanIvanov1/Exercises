using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            var basedNumber = IntegerBase(number,toBase);
            Console.WriteLine(basedNumber);
        }
        static string IntegerBase(long number, int toBase)
        {
            while (number != 0)
            {
                number % toBase;
            }
        }
    }
}
