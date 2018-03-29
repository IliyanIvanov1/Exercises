namespace WebServer.Server.Routing.Contracts
{
    using Enums;
    using global::WebServer.Server.Http.Contracts;
    using Handlers;
    using System;
    using System.Collections.Generic;


    public interface IAppRouteConfig
    {
        IReadOnlyDictionary<HttpRequestMethod,IDictionary<string,RequestHandler>> Routes { get; }

        void Get(string route, Func<IHttpRequest, IHttpResponse> handler);

        void Post(string route, Func<IHttpRequest, IHttpResponse> handler);

        void AddRoute(string route, RequestHandler handler);
    }
}
