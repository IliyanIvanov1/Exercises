namespace MyCoolWebServer.Server.Http
{
    using System.Collections.Concurrent;
   public static class SessionStore
    {
      public  const string SessionCookieKey = "MY_SID";

        public const string CurrentUserKey = "^%Current_User_Session_Key%^";

        private static readonly ConcurrentDictionary<string, HttpSession> session =
            new ConcurrentDictionary<string, HttpSession>();

        public static HttpSession Get(string id)
            => session.GetOrAdd(id, _ => new HttpSession(id));
    }
}
