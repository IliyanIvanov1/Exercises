using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();

            for (int i = 0; i < listOfDigits.Count; i++)
            {
                if (listOfDigits[i] > 0)
                {
                    result.Add(listOfDigits[i]);
                }
            }
            if (result.Count > 0)
            {
                result.Reverse();
                Console.Write(string.Join(" ",result ));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
