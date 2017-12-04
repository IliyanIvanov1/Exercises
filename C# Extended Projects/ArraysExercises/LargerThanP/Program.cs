using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanP
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());
            var countedTimes = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>p)
                {
                    countedTimes += 1;
                }
            }
            Console.WriteLine(countedTimes);
        }
    }
}
