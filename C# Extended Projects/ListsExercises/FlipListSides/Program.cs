using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1; i < listOfDigits.Count/2; i++)
            {
                var temp = listOfDigits[i];
                listOfDigits[i] = listOfDigits[listOfDigits.Count - 1 - i];
                listOfDigits[listOfDigits.Count - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ",listOfDigits));
        }
    }
}
