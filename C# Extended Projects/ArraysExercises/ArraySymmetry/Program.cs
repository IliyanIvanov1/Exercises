using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            bool isItSymmetry = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[0 + i] != array[array.Length -1- i])
                {
                    isItSymmetry = false;
                    break;
                }
                else
                {
                    isItSymmetry = true;
                }
            }
            if (isItSymmetry == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
