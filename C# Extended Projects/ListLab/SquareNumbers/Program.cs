using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var listOfSquareNumbers = new List<int>();

            foreach (var number in listOfDigits)
            {
                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    listOfSquareNumbers.Add(number);
                }
            }
            listOfSquareNumbers.Sort();
            listOfSquareNumbers.Reverse();
            Console.WriteLine(string.Join(" ",listOfSquareNumbers));
        }
        
    }
}
