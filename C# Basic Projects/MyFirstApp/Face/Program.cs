using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на триъгълника със страни " +a+ " и " +b+ " е:" +a*b);
        }
    }
}
