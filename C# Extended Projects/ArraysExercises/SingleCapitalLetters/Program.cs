using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCapitalLetters
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var stringOfWords = Console.ReadLine().Split(' ').ToArray();
            var countedCapitalLetters = 0;
            for (int i = 0; i < stringOfWords.Length; i++)
            {
                string currentWord = stringOfWords[i];
                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];
                    if(character>='A' && character<='Z')
                    {
                        countedCapitalLetters++;
                    }
                }
            }
            Console.WriteLine(countedCapitalLetters);
        }
    }
}
