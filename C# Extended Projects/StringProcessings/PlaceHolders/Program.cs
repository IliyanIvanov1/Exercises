using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceHolders
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            
            while (!(input == "end"))
            {
                var splitiInput = input.Split(new[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);
                var sentence = splitiInput[0].Trim();
                var placeWords = splitiInput[1].Trim().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
                var numberOfPlaceWords = placeWords.Count();

                for (int i = 0; i < numberOfPlaceWords; i++)
                {
                    var placeHolder = $"{{{i}}}";
                    sentence = sentence.Replace(placeHolder, placeWords[i]);
                }
                Console.WriteLine(sentence);

                input = Console.ReadLine();
            }
        }
    }
}
