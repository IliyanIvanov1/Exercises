using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellBound
{
    class Program
    {
        static void Main(string[] args)
        {
            var shells = new Dictionary<string, HashSet<int>>();
            var sumList = new List<int>();
            var sum = 0;
            var input = Console.ReadLine().Split(' ');

            while ((input[0] != "Aggregate"))
            {

                var region = input[0];
                var size = int.Parse(input[1]);


                if (!shells.ContainsKey(region))
                {
                    shells[region] = new HashSet<int>();
                }
                shells[region].Add(size);
                input = Console.ReadLine().Split(' ');

            }


            foreach (var regionSize in shells)
            {

                var region = regionSize.Key;
                var size = (regionSize.Value);
                sum = regionSize.Value.Sum();
                if (shells.Values.Count > 1)
                {
                    sum = sum - sum / shells[region].Count;
                }

                Console.WriteLine($"{region} -> {string.Join(", ", size)} ({sum})");

            }

        }
    }
}
