using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var OddSum = 0.0;
            var EvenSum = 0.0;
            double OddMax = int.MinValue;
            double OddMin = int.MaxValue;
            double EvenMax = int.MinValue;
            double EvenMin = int.MaxValue;
           
            for ( var i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
               {
                    EvenSum += number;
                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                    if(number<EvenMin)
                    {
                        EvenMin = number;
                    }
               }
                else
                {
                    OddSum += number;
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum=0,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n==1)
            {
                Console.WriteLine($"OddSum={OddSum}");
                Console.WriteLine($"OddMin={OddMin}");
                Console.WriteLine($"OddMax={OddMax}");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
           else
            {
                Console.WriteLine($"OddSum={OddSum}");
                Console.WriteLine($"OddMin={OddMin}");
                Console.WriteLine($"OddMax={OddMax}");
                Console.WriteLine($"EvenSum={EvenSum}");
                Console.WriteLine($"EvenMin={EvenMin}");
                Console.WriteLine($"EvenMax={EvenMax}");
            }

        }
    }
}
