
namespace EulerFunc1
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var n = ulong.Parse(Console.ReadLine());

            var eulerFunction = new EulerFunction();
            Console.WriteLine(eulerFunction.EulerFunctionCalculator(n));
        }
        
    }
}
