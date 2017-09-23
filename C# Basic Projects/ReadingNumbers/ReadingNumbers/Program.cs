using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNumbers
{
    class Program
    {
       static void Main(string[] args)
       {
            Console.Write("Въведи първото число: ");
            var firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Въведи второто число: " );
            var secondNumber = double.Parse(Console.ReadLine());
           
            var sum = firstNumber + secondNumber;
            Console.WriteLine("Сумата от двете въведени числа е "+sum);
       }
    } 
}
