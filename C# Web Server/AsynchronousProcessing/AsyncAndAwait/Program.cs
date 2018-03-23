namespace AsyncAndAwait
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            DoWork();
        }

        public static async void DoWork()
        {
            var tasks = new List<Task>();
            var results = new List<bool>();

            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(async () =>
                {
                    var result = await SlowMethod();
                    results.Add(result);
                }));
            }
            await Task.WhenAll(tasks.ToArray()); // Frees current resources 

            Console.WriteLine("Finished!");
        }

        public static async Task<bool> SlowMethod()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Result!");

            return true;
        }
    }
}
