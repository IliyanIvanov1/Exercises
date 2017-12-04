using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var resultList = new List<int>();

            var leftDigits = new List<int>();

            var rightDigits = new List<int>();
            for (int i = list.Count/2; i <list.Count; i++)
            {
                leftDigits.Add(list[i] / 10);
                rightDigits.Add(list[i] % 10);
                
                
            }
            for (int i = 0; i < list.Count/2; i++)
            {
                resultList.Add(leftDigits[i]);
                resultList.Add(list[i]);
                resultList.Add(rightDigits[i]);
            }
            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
