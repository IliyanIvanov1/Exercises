using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kittens
{
    public class Startup
    {
        public static void Main()
        {
            var kitties = new CatCollection();

            kitties.Add(new Cat { Name = "Sparkles", Age = 3, Color = "White" });
            kitties.Add(new Cat { Name = "Minzi", Age = 4, Color = "Black" });
            kitties.Add(new Cat { Name = "Roxie", Age = 5, Color = "Brown" });
            kitties.Add(new Cat { Name = "Pesho", Age = 6, Color = "Orange" });

            foreach (var cat in kitties)
            {
                Console.WriteLine($"Name: {cat.Name} | Age: {cat.Age} | Color: {cat.Color}");
            }

            Console.WriteLine(new string('-', 40));

            var catCollection = new SortedSet<Cat>();

            catCollection.Add(new Cat { Name = "Sparkles", Age = 3, Color = "White" });
            catCollection.Add(new Cat { Name = "Minzi", Age = 4, Color = "Black" });
            catCollection.Add(new Cat { Name = "Minzi", Age = 1, Color = "Grey" });
            catCollection.Add(new Cat { Name = "Roxie", Age = 5, Color = "Brown" });
            catCollection.Add(new Cat { Name = "Pesho", Age = 6, Color = "Orange" });

            foreach (var cat in catCollection)
            {
                Console.WriteLine($"Name: {cat.Name} | Age: {cat.Age} | Color: {cat.Color}");
            }

            Console.WriteLine(new string('-',40));

            IComparer<Cat> comparer = new CatCustomComparer();
            var catCollection2 = new SortedSet<Cat>(comparer); 

            catCollection2.Add(new Cat { Name = "Sparkles", Age = 3, Color = "White" });
            catCollection2.Add(new Cat { Name = "Minzi", Age = 4, Color = "Black" });
            catCollection2.Add(new Cat { Name = "Minzi", Age = 1, Color = "Grey" });
            catCollection2.Add(new Cat { Name = "Roxie", Age = 5, Color = "Brown" });
            catCollection2.Add(new Cat { Name = "Pesho", Age = 6, Color = "Orange" });

            foreach (var cat in catCollection2)
            {
                Console.WriteLine($"Name: {cat.Name} | Age: {cat.Age} | Color: {cat.Color}");
            }
        }
    }
}
