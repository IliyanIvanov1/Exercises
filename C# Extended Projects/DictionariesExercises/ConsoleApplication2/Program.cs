using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
   public class Program
    {
       public static void Main()
        {
            char[] chars = Console.ReadLine().ToArray();

            var dictOfChars = new Dictionary<char, int>();

            foreach (var charr in chars)
            {
                if (!dictOfChars.ContainsKey(charr))
                {
                    dictOfChars[charr] = 0;
                }
                dictOfChars[charr]++;
            }
            foreach (var kvp in dictOfChars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
