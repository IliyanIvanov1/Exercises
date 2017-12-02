using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Startup
    {
        public static void Main()
        {
            var typeOfCat = typeof(Cat);
            foreach (var prop in typeOfCat.GetProperties())
            {
                Console.WriteLine(prop.Name + " " + prop.PropertyType.Name);
            }

            Console.WriteLine(GetTypeName<Cat>());

            var typesInCurrentAssembly = Assembly.GetEntryAssembly().GetTypes();//.Where(t => t.IsInterface);
            foreach (var type in typesInCurrentAssembly)
            {
                Console.WriteLine(type);
            }
        }
        public static string GetTypeName<T>()
        {
            return typeof(T).Name;
        }
    }

}
