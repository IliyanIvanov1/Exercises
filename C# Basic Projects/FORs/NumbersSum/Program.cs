using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersSum
{
    class Program
    {
        static void Main(string[] args)

        {
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var greatestNumber = double.MinValue;
            for(int i = 1; i <= numberOfNumbers; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (greatestNumber < number)
                {
                    greatestNumber = number;
                }
            }
            Console.WriteLine(greatestNumber);
        }
    }
}
