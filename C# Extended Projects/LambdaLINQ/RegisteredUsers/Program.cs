using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var registeredUsers = new Dictionary<string, DateTime>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputParams = input.Split(new[] { " ","-",">" }, StringSplitOptions.RemoveEmptyEntries);

                var username = inputParams[0];
                var registryDate = DateTime.ParseExact(inputParams[1],"dd/MM/yyyy",CultureInfo.InvariantCulture);

                registeredUsers[username] = registryDate;

                input = Console.ReadLine();
            }
            var orderedUsernames = registeredUsers
                .Reverse()
                .OrderBy(x=>x.Value)
                .Take(5)
                .OrderByDescending(x=>x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(Environment.NewLine, orderedUsernames.Keys));
        }
    }
}