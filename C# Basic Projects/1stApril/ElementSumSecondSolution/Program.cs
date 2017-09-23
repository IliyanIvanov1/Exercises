using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementSumSecondSolution
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
                sum += currentNumber;
                if (currentNumber > greatestNumber)
                {
                   
                    greatestNumber = currentNumber;
                }
               
            }
            sum -= greatestNumber;
            if (greatestNumber == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(greatestNumber - sum)}");
            }
        }
    }
}
