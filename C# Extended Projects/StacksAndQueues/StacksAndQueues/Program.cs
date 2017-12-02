using System;
using System.Collections.Generic;


namespace StacksAndQueues
{
    public class Program
    {
        public static void Main()
        {
            Stack<int> pushedNumbers = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            var n = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string command = input[0];
                if (command == "1")
                {
                    var toPushNumber = int.Parse(input[1]);
                    pushedNumbers.Push(toPushNumber);
                    if (maxNumbers.Count == 0 || toPushNumber >= maxNumbers.Peek())
                    {
                        maxNumbers.Push(toPushNumber);
                    }
                }
                else if (command == "2")
                {

                    var numberToDelete = pushedNumbers.Pop();
                    var currentMaxNumber = maxNumbers.Peek();
                
                    if (numberToDelete == currentMaxNumber)
                    {
                        maxNumbers.Pop();
                    }
                }
                else
                {
                    
                        Console.WriteLine(maxNumbers.Peek());
                }
            }

        }
    }
}
