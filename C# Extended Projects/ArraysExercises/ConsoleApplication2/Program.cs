using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        public static void Main()
        {
            
            int numberOfElements = int.Parse(Console.ReadLine());
            var array = new int[numberOfElements];
            var maxValueOfArray = int.MinValue;
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (array[i]>maxValueOfArray)
                {
                    maxValueOfArray = array[i];
                
                }
            }
            Console.WriteLine(maxValueOfArray);
        }
    }
}
