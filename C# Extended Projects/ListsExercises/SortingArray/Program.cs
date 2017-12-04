using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    public class Program
    {
        
        public static void Main()
        {
            var arrayOfDigits = new int[1000000];
            for (int i = 1000000; i >0 ; i--)
            {
                arrayOfDigits[arrayOfDigits.Length - i] = i;
            }

            for (int i = 0; i < arrayOfDigits.Length - i; i++) // -i because we need 1 previous position everytime we swap
            {
                var lastPos = arrayOfDigits.Length - 1 - i; //lastPos is ..-1-i because after we swap the largest
                                                            //number with the last position we need the PREVIOUS position
                                                            //for the next number       
                if (arrayOfDigits[i] > arrayOfDigits[lastPos])
                {
                    SwapingPositions(arrayOfDigits, i, lastPos);
                }
            }
            Console.WriteLine(string.Join(" ",arrayOfDigits));
        }

        private static void SwapingPositions(int[] arrayOfDigits, int i, int lastPos)
        {
            var temp = arrayOfDigits[lastPos];
            arrayOfDigits[lastPos] = arrayOfDigits[i];
            arrayOfDigits[i] = temp;
        }
    }
}
