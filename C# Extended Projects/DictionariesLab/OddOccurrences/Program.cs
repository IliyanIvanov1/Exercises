using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }
                dict[word]++;
            }

            var oddNumberWords = new List<string>();
            foreach (var kvp in dict)
            {
                if (!(kvp.Value % 2 == 0))
                {
                    oddNumberWords.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",oddNumberWords));
        }
    }
}
