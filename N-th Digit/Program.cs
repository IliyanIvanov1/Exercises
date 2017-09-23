using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_th_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            long getNumberPosition=FindNthDigit(number, index);
            Console.WriteLine(getNumberPosition);
        }

        static long FindNthDigit(long number, int index)
        {
            for (int i = 1; i < index; i++)
            {
                number /= 10;
            }
            var getNumberPos = number % 10;
            return getNumberPos;
        }
    }
}
