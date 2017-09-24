using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    public class Program
    {
        public static void Main()
        {
            var arrayOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var N = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < arrayOfDigits.Length; i++)
            {
                if (N == arrayOfDigits[i])
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
