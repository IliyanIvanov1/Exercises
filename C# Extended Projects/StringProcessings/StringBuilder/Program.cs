using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.Append("Insert ","text " , "at ","once");
            sb.ToString();
            Console.WriteLine(sb);
        }
    }
}
