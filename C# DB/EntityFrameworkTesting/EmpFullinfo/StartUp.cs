using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpFullinfo
{
    public class StartUp
    {
        public static void Main()
        {
            SoftUniContext context = new SoftUniContext();
            using (context)
            {
                //--3.	Employees full information
                //    IEnumerable<Employee> employees = context.Employees;
                //    foreach (var employee in employees)
                //    {
                //        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary}");
                //    }


                //--4.	Employees with Salary Over 50 000
                //    IEnumerable<string> employeesNames = context.Employees.Where(emp => emp.Salary > 50000).Select(emp=>emp.FirstName).OrderBy(emp=>emp);
                //    foreach (var employeesName in employeesNames)
                //    {
                //        Console.WriteLine(employeesName);
                //    }


                //--5.	Employees from Seattle

                //    var employees = context.Employees
                //        .Where(emp => emp.Department.Name == "Research and Development")
                //        .OrderBy(emp => emp.Salary)
                //        .OrderByDescending(emp => emp.FirstName);

                //    foreach (var employee in employees)
                //    {
                //        Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Department.Name} {employee.Salary}");
                //    }


                //--6.	Adding a New Address and Updating Employee

                //Address address = new Address { AddressText="Vitoshka 15", TownID=4};
                //context.Addresses.Add(address);
                //Employee nakov = context.Employees.FirstOrDefault(emp => emp.LastName == "Nakov");
                //nakov.AddressID=address.AddressID;
                //context.SaveChanges();

                //IEnumerable<Employee> employees = context.Employees.OrderByDescending(emp => emp.AddressID).Take(10);
                //foreach (var employee in employees)
                //{
                //    Console.WriteLine(employee.Address.AddressText);
                //}

                //--7.Delete Project by Id
                //var project = context.Projects.Find(2);
                //context.Employees.RemoveRange(project.Employees);

                //context.Projects.Remove(project);
                //context.SaveChanges();

                //IEnumerable<string> projects = context.Projects.Take(10).Select(proj => proj.Name);
                //foreach (var proj in projects)
                //{
                //    Console.WriteLine(proj);
                //}

                //--9.	Addresses by town name 
                var addresses = context.Addresses.OrderByDescending(adr => adr.AddressID == adr.AddressID);
            }
        }
    }
}
