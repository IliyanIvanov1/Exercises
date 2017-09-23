using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());
            double bonus;
            if (points % 2 == 1 && points % 10 != 5)

            {


                if (points <= 100)
                {
                    Console.WriteLine("5");
                    Console.WriteLine(points + 5);
                }
                else if (points > 100 && points < 1001)
                {
                    bonus = points * 0.2;
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);
                }
                else if (points > 1000)
                {

                    bonus = points * 0.1;
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);

                }
            }
            else if (points % 2 == 0)
            {
                if (points <= 100)
                {
                    Console.WriteLine("6");
                    Console.WriteLine(points + 6);
                }
                else if (points > 100 && points < 1001)
                {
                    bonus = points * 0.2 + 1;
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);
                }
                else if (points > 1000)
                {

                    bonus = points * 0.1 + 1;
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);

                }
            }
            else if (points % 10 == 5)
            {
                if (points <= 100)
                {
                    Console.WriteLine("7");
                    Console.WriteLine(points + 7);
                }
                else if (points > 100 && points < 1001)
                {
                    bonus = points * 0.2 + 2;
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);
                }
                else if (points > 1000)
                {

                    bonus = points * 0.1 + 2;
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);
                }

            }
        }
    }
}
