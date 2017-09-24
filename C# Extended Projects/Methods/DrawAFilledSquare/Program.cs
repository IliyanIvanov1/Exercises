using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawSquare(n);
        }

        static void DrawSquare(int n)
        {
            PrintHeaderOrFooter(n);
            for (int i = 0; i <n-2; i++)
            {
               PrintBody(n);
            }

            PrintHeaderOrFooter(n);
        }

        private static void PrintBody(int n)
        {
            string body = "-";
            
            for (int i = 0; i < n-1; i++)
            {
                body += @"\/";
            }
            body += "-";
            Console.WriteLine(body);
        }

        static void PrintHeaderOrFooter(int n)
        {
            Console.WriteLine(new string('-' , 2*n));
        }
    }
}
