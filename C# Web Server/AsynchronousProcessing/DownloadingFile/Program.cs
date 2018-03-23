namespace DownloadingFile
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            //Task
            //    .Run(async () =>
            //    {
            //    await DownloadFileAsync();
            //    })
            //    .GetAwaiter()
            //    .GetResult();  //Main method waits the task before stopping

            //Task
            //    .Run(async () =>
            //    {
            //        var httpClient = new HttpClient();
            //        var result = await httpClient.GetStringAsync("https://www.facebook.com/");   //Usual syntax 
            //        Console.WriteLine(result);
            //    })
            //    .GetAwaiter()
            //    .GetResult();

            Task.Run(async () =>
            {
                await GetHeaders("https://softuni.bg");
            })
            .GetAwaiter()
            .GetResult();

        }

        public static async Task GetHeaders(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var contentToSent = new StringContent("Hello");
                var response = await httpClient.PostAsync(url,contentToSent);

                if (response.IsSuccessStatusCode)
                {
                    var headers = response.Headers;

                    foreach (var header in headers)
                    {
                        Console.WriteLine(header.Key + ": " + string.Join(',', header.Value));
                    }

                    var content = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                }
            }
        }

        public static async Task DownloadFileAsync()
        {
            var webClient = new WebClient();

            Console.WriteLine("Downloading...");

            await webClient.DownloadFileTaskAsync("https://www.facebook.com/", "ïndex.html");

            Console.WriteLine("Finished!");
        }
    }
}
