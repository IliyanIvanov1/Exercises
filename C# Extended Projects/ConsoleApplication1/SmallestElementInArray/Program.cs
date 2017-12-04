using System;
using System.Linq;

namespace SmallestElementInArray
{
   public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
               var minValue = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
              
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
               
            }
            Console.WriteLine(minValue);
        }
    }
}
