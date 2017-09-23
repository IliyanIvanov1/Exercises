using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();

            if (age < 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            if(age<16 && gender == "f")
            {
                Console.WriteLine("Miss");
            }
            else if(age>=16 && gender=="f")
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
