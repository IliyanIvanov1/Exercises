namespace MyCoolWebServer
{
    using MyCoolWebServer.Application;
    using MyCoolWebServer.ByTheCakeApp;
    using Server;
    using Server.Contracts;
    using Server.Routing;
    using System.IO;

    public class Launcher : IRunnable
    {
        public static void Main()
        {
            new Launcher().Run();
        }

        public void Run()
        {
            var mainApplication = new ByTheCakeApplication();
            mainApplication.InitializeDatabase();

            var appRouteConfig = new AppRouteConfig();
            mainApplication.Configure(appRouteConfig);

            var webServer = new WebServer(1337, appRouteConfig);

            webServer.Run();
        }
    }
}
