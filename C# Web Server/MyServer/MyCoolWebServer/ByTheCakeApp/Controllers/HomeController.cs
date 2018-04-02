namespace MyCoolWebServer.ByTheCakeApp.Controllers
{
    using MyCoolWebServer.ByTheCakeApp.Infrastructure;
    using MyCoolWebServer.ByTheCakeApp.VIews.Home;
    using MyCoolWebServer.Server.Http.Contracts;
    using MyCoolWebServer.Server.Http.Response;
    using Server.Enums;
    using System.IO;

    public class HomeController : Controller
    {
        public IHttpResponse Index() => this.FileViewResponse(@"home\index");
        
        public IHttpResponse About() => this.FileViewResponse(@"home\about");
    }
}
