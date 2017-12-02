using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    public class Program
    {
        public static void Main()
        {
            //int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] array = new int[1000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length - i;
            }

            for (int i = 0; i < array.Length - i; i++)
            {
                var pos = 0;
                var currentElement = array[i];
                if (currentElement > array[pos])
                {
                    pos = i;
                }
                var temp = array[pos];
                array[pos] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, array));
        }
    }
}
