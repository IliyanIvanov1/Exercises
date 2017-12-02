using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSplit
{
    public class Program
    {
       public static void Main()
        {
            var inputLine = Console.ReadLine();
            var delimeter = Console.ReadLine();

            var result = inputLine.Split(new[] { delimeter },StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("["+string.Join(", ",result)+"]");
        }
    }
}
