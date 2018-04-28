﻿namespace MyCoolWebServer.ByTheCakeApp.Controllers
{
    using Infrastructure;
    using Models;
    using Data;
    using Server.Http.Contracts;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class CakesController :Controller
    {
        private readonly CakesData cakesData;

        public CakesController()
        {
            this.cakesData = new CakesData();
        }

        public IHttpResponse Add()
        {
            this.ViewData["showResult"] = "none";

            return this.FileViewResponse(@"cakes\add");
        }

        public IHttpResponse Add(string name, string price)
        {
            var cake = new Cake
            {
                Name = name,
                Price = decimal.Parse(price)
            };
            


            this.cakesData.Add(name, price);

            this.ViewData["name"] = name;
            this.ViewData["price"] = price;
            this.ViewData["showResult"] = "block";

            return this.FileViewResponse(@"cakes\add");
        }

        public IHttpResponse Search(IHttpRequest req )
        {
            const string searchTermKey = "searchTerm";

            var urlParameters = req.UrlParameters;

            this.ViewData["results"] = string.Empty;
            this.ViewData["searchTerm"] = "Search...";

            if (urlParameters.ContainsKey(searchTermKey))
            {
                var searchTerm = urlParameters[searchTermKey];

                this.ViewData["searchTerm"] = searchTerm;

                var savedCakesAsDivs = this.cakesData
                    .All()
                    .Where(c => c.Name.ToLower().Contains(searchTerm.ToLower()))
                    .Select(c=> $@"<div>{c.Name} - ${c.Price} <a href=""/shopping/add/{c.Id}?searchTerm={searchTerm}"">Order</a> </div>");
                var results = string.Join(Environment.NewLine, savedCakesAsDivs);
                this.ViewData["results"] = results;

            }


            this.ViewData["showCart"] = "none";

            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);

            if (shoppingCart.Orders.Any())
            {
                var totalProducts = shoppingCart.Orders.Count;
                var totalProductsText = totalProducts != 1 ? "products" : "product";

                this.ViewData["showCart"] = "block";
                this.ViewData["products"] = $"{totalProducts} {totalProductsText}";
            }



            return this.FileViewResponse(@"cakes\search");
        }
    }
}
