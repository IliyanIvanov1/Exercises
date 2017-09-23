using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var inputParams = input.Split(new[] { " ", "-", ">" }, StringSplitOptions.RemoveEmptyEntries);

                var key = inputParams[0];
                var value = inputParams[1];

                dictionary[key] = value;

                    
                input = Console.ReadLine();
            }
            var defaultValue = Console.ReadLine();

            var unreplacedValues = dictionary.Where(x => x.Value != "null").OrderByDescending(x => x.Value.Length).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var kvp in unreplacedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

            var replacedValues = dictionary.Where(x => x.Value == "null").ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in replacedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {defaultValue}");
            }
        }
    }
}
