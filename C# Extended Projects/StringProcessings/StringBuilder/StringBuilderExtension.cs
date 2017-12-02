using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilders
{
   public static class StringBuilderExtension
    {
        public static StringBuilder Append(this StringBuilder sb,params string[] parameters)
        {
            foreach (var parameter in parameters)
            {
                sb.Append(parameter);
            }
            return sb;
        }
    }
}
