using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedDictionariesContinents
{
    class Program
    {
        static void Main(string[] args)
        {
            var continentsDict = new Dictionary<string, Dictionary<string, List<string>>>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!continentsDict.ContainsKey(continent))
                {
                    continentsDict[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentsDict[continent].ContainsKey(country))
                {
                    continentsDict[continent][country] = new List<string>();
                }
                continentsDict[continent][country].Add(city);
            }
            foreach (var continentCountries in continentsDict)
            {
                var continent = continentCountries.Key;
                var countryDict = continentCountries.Value;
                Console.WriteLine($"{continent}:");
                foreach (var countryCities in countryDict)
                {
                    var country = countryCities.Key;
                    var city = countryCities.Value;
                    Console.WriteLine($"{country} -> {string.Join(", ",city)}");
                }
            }
        }
    }
}
