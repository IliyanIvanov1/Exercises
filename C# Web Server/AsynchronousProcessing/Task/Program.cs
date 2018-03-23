namespace Task1
{
    using System;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            var task=Task.Run(() =>
            {
                return 100;
            });

            var result = task.GetAwaiter().GetResult(); // task.Result гърми понякога :/
            Console.WriteLine(result);
        }
    }
}
