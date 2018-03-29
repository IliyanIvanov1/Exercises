﻿namespace WebServer.Server.Http.Response
{
    using Common;
    using Server.Contracts;
    using Enums;
    using System.Text;
    using Server.Http.Contracts;

    public abstract class HttpResponse : IHttpResponse
    {
        private string statusCodeMessage => this.StatusCode.ToString();


        protected HttpResponse()
        {
            this.Headers = new HttpHeaderCollection(); 
        }
        
        public HttpHeaderCollection Headers { get; }

        public HttpStatusCode StatusCode { get; protected set; }


        public override string ToString()
        {
            var response = new StringBuilder();

            var statusCodeNumber = (int)this.StatusCode;
            response.AppendLine($"HTTP/1.1 {statusCodeNumber} {this.statusCodeMessage}");

            response.AppendLine(this.Headers.ToString());
            response.AppendLine();

            return response.ToString();
        }
    }
}
