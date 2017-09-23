using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secs
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSeconds = int.Parse(Console.ReadLine());
            var secondSeconds = int.Parse(Console.ReadLine());
            var thirdSeconds = int.Parse(Console.ReadLine());

            var totalSeconds = firstSeconds + secondSeconds + thirdSeconds;
            var minute = totalSeconds / 60;
            var seconds = totalSeconds % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minute}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minute}:{seconds}");
            }
        }
    }
}
