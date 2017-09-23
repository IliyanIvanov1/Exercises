using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете вашето първо име: ");
            var firstName = Console.ReadLine();
            Console.Write("Въведете вашата фамилия: ");
            var lastName = Console.ReadLine();
            Console.Write("Въведете вашата възраст: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Въведете града , в който живеете: ");
            var town = Console.ReadLine();
            Console.WriteLine($"Здравейте , казвам се {firstName} {lastName}, на {age} години съм и живея в {town}.");
        }
    }
}
