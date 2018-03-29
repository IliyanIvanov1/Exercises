namespace WebServer.Server.Http.Contracts
{
    public interface IHttpHeaderCollection
    {
        void Add(HttpHeader header);

        bool ContainsKey(string key);

        HttpHeader Get(string key);
    }
}
