using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            #region first line
            Console.Write("+ ");
            for (var i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");

            #endregion


            #region middle
            for (int i = 0; i < n - 2; i++)
            {


                Console.Write("| ");
                for (var k = 0; k < n - 2; k++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("| ");
            }
            #endregion

            #region last line
            Console.Write("+ ");
            for (var i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+ ");
            #endregion

        }
    }
}
