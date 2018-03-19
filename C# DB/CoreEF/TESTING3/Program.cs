using System;
using System.Linq;

namespace TESTING3
{
    public class Program
    {
        public static void Main()
        {
            var department = 1;
            using (var db= new MyDbContext())
            {
                // db.Database.EnsureDeleted();
                // db.Database.EnsureCreated();
                //
                // var department = new Department { Name = "C-Level" };
                //
                // for (int i = 0; i < 10; i++)
                // {
                //     department.Employees.Add(new Employee { Name = $"Emp №{i}" });
                // }
                // db.Add(department);
                // db.SaveChanges();

                var result = db
                    .Departments
                    .Where(d => d.Id == department)
                    .Select(d => new
                    {
                        d.Name,
                        Employees = d.Employees.Count
                    })
                    .FirstOrDefault();
            }
        }
    }
}
