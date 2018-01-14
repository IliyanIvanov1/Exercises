using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEmployeesInPeriod
{
    public class StartUp
    {
       public static void Main()
        {
            SoftUniContext context = new SoftUniContext();
            using (context)
            {
                IEnumerable<Employee> employees = context.Employees
                    .Where(emp => emp.Projects.Count(proj => proj.StartDate.Year >= 2001 && proj.StartDate.Year <= 2003) > 0)
                    .Take(30);
                foreach (var  employee in employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Employee1.FirstName}");
                    foreach (var project in employee.Projects)
                    {
                        Console.WriteLine($"--{project.Name} {project.StartDate} {project.EndDate}");
                    }
                }
            }
        }
    }
}
