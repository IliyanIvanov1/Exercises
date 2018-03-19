using System;

namespace Testing
{
    public class Program
    {
        public static void Main()
        {
            MyDbContext db = new MyDbContext();
                db.Database.EnsureDeleted();
         db.Database.EnsureCreated();

                var department = new Department { Name="C-level"};

                for (int i = 0; i < 10; i++)
                {
                    db.Employees.Add(new Employee { Name = $"Emp №{i}" });

                }
            
                db.SaveChanges();
        }
        
    }
}
