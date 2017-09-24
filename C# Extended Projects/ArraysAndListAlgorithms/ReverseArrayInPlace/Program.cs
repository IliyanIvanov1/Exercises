using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
   public class Program
    {
       public static void Main()
        {
            var arrayOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arrayOfDigits.Length/2; i++)
            {
                var temp = arrayOfDigits[i];
                arrayOfDigits[i] = arrayOfDigits[arrayOfDigits.Length - 1 - i];

                arrayOfDigits[arrayOfDigits.Length-1-i]= temp;
            }
            Console.WriteLine(string.Join(" ",arrayOfDigits));
        }

    }
}
