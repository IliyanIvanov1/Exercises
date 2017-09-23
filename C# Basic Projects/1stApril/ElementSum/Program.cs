using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var greatestNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > greatestNumber)
                {
                    if (greatestNumber != int.MinValue)
                    {
                        sum += greatestNumber;
                    }
                    greatestNumber = currentNumber;
                }
                else
                {
                    sum += currentNumber;
                }
            }
            if (greatestNumber==sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(greatestNumber-sum)}");
            }
           
            


        }
    }
}
