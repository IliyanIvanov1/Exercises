namespace MyCoolWebServer.ByTheCakeApp.Infrastructure
{
    using MyCoolWebServer.ByTheCakeApp.VIews.Home;
    using MyCoolWebServer.Server.Enums;
    using MyCoolWebServer.Server.Http.Contracts;
    using MyCoolWebServer.Server.Http.Response;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public abstract class Controller
    {
        public const string DefaultPath = @"C:\Users\ilian\Desktop\MyServer\MyCoolWebServer\ByTheCakeApp\Resources\{0}.html";
        public const string ContentPlaceHolder = "{{{content}}}";

        public IHttpResponse FileViewResponse(string fileName)
        {
            var result = ProcessFileHtml(fileName);
           
            return new ViewResponse(HttpStatusCode.Ok, new FileView(result));
        }

        public IHttpResponse FileViewResponse(string fileName, Dictionary<string,string> values)
        {
            var result = this.ProcessFileHtml(fileName);

            if (values != null && values.Any())
            {
                foreach (var value in values)
                {
                    result = result.Replace($"{{{{{{{value.Key}}}}}}}", value.Value);
                }
            }

            return new ViewResponse(HttpStatusCode.Ok, new FileView(result));
        }

        private string ProcessFileHtml(string fileName)
        {
            var layoutHtml = File.ReadAllText(string.Format(DefaultPath, "layout"));

            var fileHtml = File
                .ReadAllText(string.Format(DefaultPath, fileName));

            var result = layoutHtml.Replace(ContentPlaceHolder, fileHtml);

            return result;
        }
    }
}
