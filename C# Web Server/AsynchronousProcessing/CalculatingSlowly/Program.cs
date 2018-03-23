namespace CalculatingSlowly
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        private static string result;

        public static void Main(string[] args)
        {
            Console.WriteLine("Calculating...");
            Task.Run(() => Calculating());
            Console.WriteLine("Please enter a command:");

            

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "show")
                {
                    if (result==null)
                    {
                        Console.WriteLine("Still calculating ... Please wait!");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {result}");
                    }
                }
                if (line == "exit")
                {
                    break;
                }
            }
        }

        private static void Calculating()
        {
            Thread.Sleep(10000);
            result = "55";
        }
    }
}
