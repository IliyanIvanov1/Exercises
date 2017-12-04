using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var listOfStrings = new List<int>();

            var insert = Console.ReadLine();
            while (insert!="end")
            {
                listOfStrings.Add(int.Parse(insert));
                insert = Console.ReadLine();
            }
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                var lengthOfDigit = listOfStrings[i].ToString().Count() - 1;
                var indexToInsertAt = (listOfStrings[i]) / (int)Math.Pow(10,lengthOfDigit);
                listOfDigits.Insert(indexToInsertAt, listOfStrings[i]);
            }
            Console.WriteLine(string.Join(" ",listOfDigits));
        }
    }
}
