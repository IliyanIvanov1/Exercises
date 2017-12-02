using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittens
{
    public class CatCollection : IEnumerable<Cat> 
    {
        public readonly List<Cat> cats;

        public CatCollection()
        {
            this.cats = new List<Cat>();
        }

        public void Add(Cat cat)
        {
            this.cats.Add(cat);
        }


        public IEnumerator<Cat> GetEnumerator()
        {
            for (int i = 0; i < this.cats.Count; i++)
            {
                yield return this.cats[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
