using System;
using System.Collections.Generic;
using System.Text;

namespace TESTING3
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
