using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        int value1 = int.Parse(Console.ReadLine());
                        int value2 = int.Parse(Console.ReadLine());
                        int biggerNumber = GetMax(value1, value2);
                        Console.WriteLine(biggerNumber);
                        break;
                    }
                case "char":
                    {
                        char value1 = char.Parse(Console.ReadLine());
                        char value2 = char.Parse(Console.ReadLine());
                        char biggerChar = GetMax(value1, value2);
                        Console.WriteLine(biggerChar);
                        break;
                    }
                case "string":
                    {
                        string value1 = Console.ReadLine();
                        string value2 = Console.ReadLine();
                        string biggerString = GetMax(value1,value2);
                        Console.WriteLine(biggerString);
                        break;
                    }
            }
        }

       static int GetMax(int value1, int value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            return value2;
        }
        static char GetMax(char value1, char value2)
        {
            if (value1 >= value2)
            {
                return value1;
            }
            return value2;
        }
        static string GetMax(string value1, string value2)
        {
            if (value1.CompareTo(value2)>=0) {
                return value1;
            }
            return value2;
        }
    }
}
