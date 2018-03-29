namespace WebServer.Server.Http
{
    using Common;
    using Contracts;
    using System;
    using System.Collections.Generic;

    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly IDictionary<string, HttpHeader> headers; //= new Dictionary<string, HttpHeader>();

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }
        public void Add(HttpHeader header) //Add or Update
        {
            CoreValidator.ThrowIfNull(header, nameof(header));

            headers[header.Key] = header; //Презаписване 
        }

        public bool ContainsKey(string key)
        {
            CoreValidator.ThrowIfNull(key, nameof(key));

            return this.headers.ContainsKey(key);
        }

        public HttpHeader Get(string key)
        {
            CoreValidator.ThrowIfNull(key, nameof(key));

            if (!this.headers.ContainsKey(key))
            {
                throw new InvalidOperationException($"The given key {key} is not present in the header collection.");
            }

            return this.headers[key]; 
        }

        public override string ToString() => string.Join(Environment.NewLine, this.headers);
    }
}
