using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPositions
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var listOfWords = Console.ReadLine().Split(' ').ToList();

            var listOfEvenElements = new List<string>();

            for (int i = 0; i < listOfWords.Count; i++)
            {
                if (i % 2 == 1)
                {
                    listOfEvenElements.Add(listOfWords[i]);
                }
            }
            Console.WriteLine(string.Join("",listOfEvenElements));
        }
    }
}
