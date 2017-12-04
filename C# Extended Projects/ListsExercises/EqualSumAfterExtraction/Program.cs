using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sumList1 = 0;
            var sumList2 = 0;

            for (int i = 0; i < list1.Count; i++)
            {
                sumList1 += list1[i];
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list2.Remove(list1[i]);
                        j--;                                   
                    }
                }
            }
            sumList2=list2.Sum();
            if (sumList1 == sumList2)
            {
                Console.WriteLine($"Yes. Sum: {sumList2}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumList1-sumList2)}");
            }
        }
    }
}
