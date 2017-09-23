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
            var sum = 0.0;
            
            for (int i = 0; i < n; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }
            var avr = sum/n;
            
            Console.WriteLine($"sum={sum}");
            Console.WriteLine($"avr={avr}");
        }
    }
}
