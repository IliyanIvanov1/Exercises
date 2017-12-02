using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Cat(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
