namespace MyCoolWebServer.ByTheCakeApp.ViewModels
{
    using MyCoolWebServer.ByTheCakeApp.Data.Models;
    using System.Collections.Generic;

    public class ShoppingCart
    {
        public const string SessionKey = "%^Current_Shopping_Cart^%";

        public List<int> ProductIds { get; private set; } = new List<int>();
    }
}
