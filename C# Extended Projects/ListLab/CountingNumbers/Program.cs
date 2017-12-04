using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingNumbers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            listOfDigits.Sort();

            var count = 1;

            for (int i = 1; i <= listOfDigits.Count; i++)
            {
               
                var previousElement = listOfDigits[i - 1];
                var lengthOfList = listOfDigits.Count;
                if (i == lengthOfList)
                {
                    Console.WriteLine($"{previousElement} -> {count}");
                    break;
                }
                if (previousElement == listOfDigits[i])
                {
                    count++;
                    if (i == lengthOfList - 1)
                    {
                        Console.WriteLine($"{previousElement} -> {count}");
                        count = 1;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{previousElement} -> {count}");
                    count = 1;
                }
            }
        }
    }
}
