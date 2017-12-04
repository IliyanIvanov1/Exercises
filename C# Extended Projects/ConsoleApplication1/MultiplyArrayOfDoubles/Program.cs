using System;
using System.Linq;

namespace MultiplyArrayOfDoubles
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= p;
            }
            for (int i = 0; i <array.Length; i++)
            {
                Console.Write(array[i] +" ");
            }
            Console.WriteLine();
        }
    }
}
