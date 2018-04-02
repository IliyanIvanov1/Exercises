namespace MyCoolWebServer.Application
{
    using Application.Controllers;
    using Server.Contracts;
    using Server.Routing.Contracts;

    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.Get(
                "/"
                , request => new HomeController().Index());
                
            //appRouteConfig
            //    .AddRoute("/about", new GetHandler(request => new HomeController().About()));

            appRouteConfig.Get(
                "/testsession",
                request => new HomeController().SessionTest(request));
                
        }
    }
}
