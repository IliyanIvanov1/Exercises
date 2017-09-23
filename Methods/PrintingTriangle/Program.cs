using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {

        static void Main(string[] args)
        {
            
            PrintTriangle();
        }

        static void PrintTriangle()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
               PrintLine(1,i);
            }
            for (int i = input-1; i >= 1; i--)
            {
                PrintLine(1,i);
            }
            
        }

        static void PrintLine(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " "); 
            }
            Console.WriteLine();
        }

    }
}
