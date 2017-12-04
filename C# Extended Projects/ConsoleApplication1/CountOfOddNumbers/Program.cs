using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var countOfOddNumbers = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                var elements = arrayOfNumbers[i];
                if (elements % 2 == 1 || elements % 2 == -1)
                {
                    countOfOddNumbers += 1;
                }
            }
            Console.WriteLine(countOfOddNumbers);
        }
    }
}
