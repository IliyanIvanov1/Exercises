using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var sortedArray=ArraySorting(arrayOfDigits);
            Console.WriteLine(string.Join(" ",sortedArray));
        }

        private static int[] ArraySorting(int[] arrayOfDigits)
        {
            int temp = 0;

            for (int i = 0; i < arrayOfDigits.Length; i++)
            {
                for (int j = i+1; j < arrayOfDigits.Length; j++)
                {
                    if (arrayOfDigits[i] > arrayOfDigits[j])
                    {
                        temp = arrayOfDigits[i];
                        arrayOfDigits[i] = arrayOfDigits[j];
                        arrayOfDigits[j] = temp;
                    }
                }
            }
            return arrayOfDigits;
        }
    }
}
