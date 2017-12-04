using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class Program
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();

            phoneBook["Ivan"] = "+34234234234";
            phoneBook["Gosho"] = "+1232323434";
            phoneBook["Kolio"] = "+42394934803";
            phoneBook["Pesho"] = "+92342983413";

            foreach (var kvp in phoneBook)
            {
                var key = kvp.Key;
                var value = kvp.Value;

                Console.WriteLine($"{key} -> {value}")
                    ;
            }
            foreach (var key in phoneBook.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(phoneBook[key]);

                Console.WriteLine("---");
            }

            string text = "1234s";

            int number;

            bool parsed = int.TryParse(text, out number);


            var words = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            var text2 = "even";

            var result = text2 == "even" ? 2 : 3;  //same as if(text2=="even"){ var result=2 } else { var result=3 }
        }
    }
}
