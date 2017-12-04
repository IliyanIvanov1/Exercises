using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = true;
            for (int i = 0; i < array.Length - 1; i++) //Important!!! 
            {
                if (array[i] < array[i + 1])
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break; //Important!!!
                }
            }
            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
             Console.WriteLine("No");
            }
                
        }
    }
}
