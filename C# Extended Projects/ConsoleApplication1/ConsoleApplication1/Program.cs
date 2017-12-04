using System;


namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main()
        {   //var numbers = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .Toarray();


            int numberOfElements = int.Parse(Console.ReadLine());

            int[] array = new int[numberOfElements];

            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i]  = int.Parse(Console.ReadLine());
                              
                sum += array[i];
            }
            Console.WriteLine(sum);


            
        }
    }
}
