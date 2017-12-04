using System;
using System.Collections.Generic;


namespace TrackDownloader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var blacklist = Console.ReadLine().Split();

            var downloadedSongs = new List<string>() ;
            
            var input = Console.ReadLine();
            while (input!="end")
            {
                var isBlackListed = false;
                foreach (var blacklistedWord in blacklist)
                {
                    if (input.Contains(blacklistedWord))
                    {
                        isBlackListed = true;
                        break;
                    }
                }
                if (!isBlackListed)
                {
                    downloadedSongs.Add(input);
                }
                input = Console.ReadLine();
            }
            downloadedSongs.Sort();

            Console.WriteLine(string.Join(Environment.NewLine ,downloadedSongs));
        }
    }
}
