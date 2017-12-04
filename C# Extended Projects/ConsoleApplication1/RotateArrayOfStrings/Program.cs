using System;
using System.Linq;

namespace RotateArrayOfStrings
{
   public class Program
    {
        public static void Main()
        {
            var arrayOfStrings = Console.ReadLine().Split(' ').ToArray();


            string[] newArray = new string[arrayOfStrings.Length];

            newArray[0] = arrayOfStrings[arrayOfStrings.Length-1];
            for (int i = 0; i < newArray.Length-1; i++)
            {
                newArray[i+1] = arrayOfStrings[i];
                
            }
            Console.WriteLine(string.Join(" ",newArray));
            
        }
    }
}
