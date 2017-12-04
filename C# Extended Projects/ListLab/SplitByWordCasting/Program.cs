using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfWords = Console.ReadLine().Split(' ', ':', ',', ';', '.', '!', '(', ')', '"', '\'', '[', ']', '/', '\\').ToList();
            arrayOfWords.RemoveAll(string.IsNullOrWhiteSpace); //маха празни стрингове " "
            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixedCaseList = new List<string>();



            foreach (var word in arrayOfWords)
            {
                bool isLowerCase = true; // true стойностите трябва да се връщат за всяка дума
                bool isUpperCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isLowerCase = false;
                    }

                    else if (char.IsLower(word[i]))
                    {
                        isUpperCase = false;
                    }
                    else
                    {
                        isUpperCase = false;
                        isLowerCase = false;
                    }
                }
                if (isLowerCase)
                {
                    lowerCaseList.Add(word);
                }
                else if (isUpperCase)
                {
                    upperCaseList.Add(word);
                }
                else
                {
                    mixedCaseList.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: { string.Join(", ", lowerCaseList)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseList)}");
            Console.WriteLine($"Upper-case: { string.Join(", ", upperCaseList)}");
        }
    }
}
