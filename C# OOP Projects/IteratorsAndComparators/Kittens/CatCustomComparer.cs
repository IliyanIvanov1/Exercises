using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittens
{
    public class CatCustomComparer : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        {
            return x.Color.CompareTo(y.Color);
        }
    }
}
