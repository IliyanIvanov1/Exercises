using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enc_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Carlos",20);

            Console.WriteLine(employee.Name);

            employee.MonthlySalary = 300;
            Console.WriteLine(employee.MonthlySalary);
            Console.WriteLine(employee.Age);
        }
    }
}
