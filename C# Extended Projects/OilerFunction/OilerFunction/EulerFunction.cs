namespace EulerFunc1
{
    using System;

    public class EulerFunction
    {
        public ulong CalculateGCD(ulong value1, ulong value2)
        {
            while (value1 != 0 && value2 != 0)
            {
                if (value1 > value2)
                {
                    value1 %= value2;
                }
                else
                {
                    value2 %= value1;
                }
            }
            return Math.Max(value1, value2) ;
        }
        public bool Coprime(ulong value1,ulong value2)
        {
            return CalculateGCD(value1, value2) == 1;
        }

        public int EulerFunctionCalculator(ulong n)
        {
            var count = 0;
            for (ulong i = 1; i < n; i++)
            {
                if (Coprime(i,n))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
