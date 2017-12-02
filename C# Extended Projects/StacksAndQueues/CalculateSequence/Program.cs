using System;
using System.Collections.Generic;


namespace CalculateSequence
{
    public class Program
    {
        public static void Main()
        {
            var sequenceOfNumbers = new Queue<long>();
            var result = new List<long>();

            var n = long.Parse(Console.ReadLine());
            result.Add(n);

            sequenceOfNumbers.Enqueue(n);

            while (result.Count < 50)
            {
                long currentNumber = sequenceOfNumbers.Dequeue();
                long firstNumber = currentNumber+1;
                long secondNumber =currentNumber*2 +1 ;
                long thirdNumber = currentNumber+2;

                sequenceOfNumbers.Enqueue(firstNumber);
                sequenceOfNumbers.Enqueue(secondNumber);
                sequenceOfNumbers.Enqueue(thirdNumber);
                

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);
                
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
