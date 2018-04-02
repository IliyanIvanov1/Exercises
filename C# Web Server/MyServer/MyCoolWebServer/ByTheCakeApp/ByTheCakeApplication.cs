namespace MyCoolWebServer.ByTheCakeApp
{
    using Controllers;
    using MyCoolWebServer.Server.Routing.Contracts;
    using Server.Contracts;
    public class ByTheCakeApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig
                .Get("/", req => new HomeController().Index());

            appRouteConfig
                .Get("/about", req => new HomeController().About());

            appRouteConfig
                .Get("/add", req => new CakesController().Add());

            appRouteConfig
                .Post("/add", req => new CakesController().Add(req.FormData["name"], req.FormData["price"]));
                                                            //name attribute=name      //name attribute=price

            appRouteConfig
                .Get("/search", req => new CakesController().Search(req.UrlParameters));
        }
    }
}
