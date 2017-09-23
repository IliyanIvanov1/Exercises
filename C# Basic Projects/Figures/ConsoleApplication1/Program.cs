using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n+1; row++)
            {
                Console.Write(new string(' ',n-row));
                Console.Write(new string('*',row));
                Console.Write(" | ");
                Console.WriteLine(new string('*',row));
            }
        }
    }
}
