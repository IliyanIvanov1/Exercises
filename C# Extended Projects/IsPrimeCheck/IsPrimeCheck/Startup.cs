using System;

namespace IsPrimeCheck
{
    public class Startup
    {
       public static void Main()
        {
            var number = ulong.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is prime.");
            }
            else
            {
                Console.WriteLine($"{number} is not prime");
            }

        }
        public static bool IsPrime(ulong n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if(n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (ulong i = 5; i*i < n; i+=6)
            {
                if(n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
