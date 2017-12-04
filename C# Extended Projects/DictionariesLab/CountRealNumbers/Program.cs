using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
   public class Program
    {
        public static void Main()
        {
            var realNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse);

            var sortedDict = new SortedDictionary<double, int>();

            foreach (var digit in realNumbers)
            {
                if (!sortedDict.ContainsKey(digit))
                {
                    sortedDict[digit] = 0;
                }
                sortedDict[digit]++;
            }
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
