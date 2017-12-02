
namespace StringProcessings
{
    using System;
    public class Program
    {

        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            var index = -1;
            var count = 0;

            while (true)
            {               
                index = text.IndexOf(pattern, index + 1);

                if (index < 0)
                    break;

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
