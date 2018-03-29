namespace WebServer.Server.Handlers
{
    using Common;
    using Handlers.Contracts;
    using Http;
    using Http.Contracts;
    using System;

    public abstract class RequestHandler : IRequestHandler
    {
        private readonly Func<IHttpRequest, IHttpResponse> handlingFunc;

        protected RequestHandler(Func<IHttpRequest, IHttpResponse> handlingFunc) //Gets request and returns a response
        {
            CoreValidator.ThrowIfNull(handlingFunc, nameof(handlingFunc));

            this.handlingFunc = handlingFunc;
        }

        public IHttpResponse Handle(IHttpContext context)
        {
            var response = this.handlingFunc(context.Request);

            response.Headers.Add(new HttpHeader("Content-Type", "text/plain"));

            return response;
        }
    }
}
