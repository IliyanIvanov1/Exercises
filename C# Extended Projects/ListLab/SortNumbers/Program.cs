using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            listOfNumbers.Sort();
            Console.WriteLine(string.Join(" <= ",listOfNumbers));
        }
    }
}
