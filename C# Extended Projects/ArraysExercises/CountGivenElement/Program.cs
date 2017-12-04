using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountGivenElement
{
    public class Program
    {
       public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var givenNumber = double.Parse(Console.ReadLine());
            var countedNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] / givenNumber == 1)
                {
                    countedNumber += 1;
                }
            }
            Console.WriteLine(countedNumber);

        }
    }
}
