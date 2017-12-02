using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittens
{
   public class Cat : IComparable<Cat>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public int CompareTo(Cat other)
        {
            var nameCompare = this.Name.CompareTo(other.Name);
            if (nameCompare!=0)
            {
                return nameCompare;
            }

            return this.Age.CompareTo(other.Age);
        }
    }
}
