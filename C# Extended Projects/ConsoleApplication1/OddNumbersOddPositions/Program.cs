using System;
using System.Linq;

namespace OddNumbersOddPositions
{
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if(i%2==1 && (array[i]%2==1 || array[i] % 2 == -1))
                {
                    Console.WriteLine($"Index {i} -> {array[i]}");
                }
            }
        }
    }
}
