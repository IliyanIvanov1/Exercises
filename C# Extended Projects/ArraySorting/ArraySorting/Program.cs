namespace ArraySorting
{
    using System;
    public class Program
    {
        public static void Main()
        {
           //int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] array = new int[100000];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length - i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                var pos = 0;
                for (int j = 0; j < array.Length-i; j++)
                {
                    var currentElement = array[j];
                    if (currentElement > array[pos])
                    {
                        pos = j;
                    }
                }
                var temp = array[pos];
                array[pos] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine,array));
        }
    }
}
