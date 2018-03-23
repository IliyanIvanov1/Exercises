using System;
using System.Text;

namespace BytesToString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Hello";

            var bytes = Encoding.UTF8.GetBytes(text);

            var result = Encoding.UTF8.GetString(bytes);

            Console.WriteLine(result);

            foreach (var byteSymbol in bytes)
            {
                Console.WriteLine(byteSymbol);
            }
        }
    }
}
