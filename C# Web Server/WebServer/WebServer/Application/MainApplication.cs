namespace WebServer.Application
{
    using Server.Contracts;
    using Server.Handlers;
    using Server.Routing.Contracts;
    using WebServer.Application.Controllers;

    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig
                .Get("/", request => new HomeController().Index());
            //appRouteConfig
            //    .AddRoute("/about", new GetHandler(request => new HomeController().About()));
        }
    }
}
