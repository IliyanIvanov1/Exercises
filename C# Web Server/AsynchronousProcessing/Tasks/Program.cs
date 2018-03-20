namespace Tasks
{
    using System;
    using System.Threading.Tasks;
    using System.IO;
    using System.Drawing;
    using System.Collections.Generic;

    public class Program
    {
       public static void Main(string[] args)
        {
           
            var directoryInfo = new DirectoryInfo("C:\\Users\\ilian\\source\\repos\\AsynchronousProcessing\\Tasks\\Images");

            var files = directoryInfo.GetFiles();

            const string resultDir = "C:\\Users\\ilian\\source\\repos\\AsynchronousProcessing\\Tasks\\Result";

            if (Directory.Exists(resultDir))
            {
                Directory.Delete(resultDir,true);
            }
            Directory.CreateDirectory(resultDir);

            var tasks = new List<Task>();

            foreach (var file in files)
            {
                var task= Task.Run(() =>
                {
                    var image = Image.FromFile(file.FullName);
                    image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    image.Save($"{resultDir}\\flip-{file.Name}");

                    Console.WriteLine($"{file.Name} processed ...");
                });

                tasks.Add(task); 
            }
            Task.WaitAll(tasks.ToArray());

            Console.WriteLine("Process finished!");
        }
    }
}
