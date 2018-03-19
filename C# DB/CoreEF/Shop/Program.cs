namespace Shop
{
    using System;
    using Shop.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            using (var db = new ShopDbContext())
            {
                PrepareDatabase(db);
                SaveSalesmen(db);
                SaveItems(db);
                ProcessCommands(db);
                //PrintSalesmenWithCustomerCount(db);
                //PrintCustomersWithOrdersAndReviewsCount(db);
                //PrintCustomerOrdersAndReviews(db);
                //PrintCustomerData(db);
                PrintOrdersWithMoreThanOneItem(db);
            }
        }

        private static void PrepareDatabase(ShopDbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }

        private static void SaveSalesmen(ShopDbContext db)
        {
            var salesmen = Console.ReadLine().Split(";");

            foreach (var salesman in salesmen)
            {
                db.Add(new Salesman { Name = salesman });
            }
            db.SaveChanges();
        }


        private static void SaveItems(ShopDbContext db)
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var parts = line.Split(';');
                var itemName = parts[0];
                var itemPrice = decimal.Parse(parts[1]);

                db.Add(new Item
                {
                    Name = itemName,
                    Price = itemPrice
                });
            }

            db.SaveChanges();
        }

        private static void ProcessCommands(ShopDbContext db)
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                var parts = line.Split('-');
                var command = parts[0];
                var arguments = parts[1];

                switch (command)
                {
                    case "register":
                        RegisterCustomer(db, arguments);
                        break;
                    case "order":
                        SaveOrder(db, arguments);
                        break;
                    case "review":
                        SaveReview(db, arguments);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void RegisterCustomer(ShopDbContext db, string arguments)
        {
            var parts = arguments.Split(';');
            var customerName = parts[0];
            var salesmanId = int.Parse(parts[1]);

            db.Add(new Customer
            {
                Name = customerName,
                SalesmanId = salesmanId
            });

            db.SaveChanges();
        }

        private static void PrintSalesmenWithCustomerCount(ShopDbContext db)
        {
            // var salesmenData = db.Salesmen.Include(s => s.Customers).ToList(); Not optimized ... Gets unneeded data

            var salesmenData = db
                .Salesmen
                .Select(s => new
                {
                    s.Name,
                    Cusomers = s.Customers.Count
                })
                .OrderByDescending(s => s.Cusomers)
                .ThenBy(s => s.Name)
                .ToList();

            foreach (var salesman in salesmenData)
            {
                Console.WriteLine($"{salesman.Name} - {salesman.Cusomers} customers");
            }
        }
        private static void SaveOrder(ShopDbContext db, string arguments)
        {
            var parts = arguments.Split(';');
            var customerId = int.Parse(parts[0]);

            var order = new Order { CustomerId = customerId };

            for (int i = 1; i < parts.Length; i++)
            {
                var itemId = int.Parse(parts[i]);

                order.Items.Add(new ItemOrder
                {
                    ItemId = itemId
                });
            }

            db.Add(order);

            db.SaveChanges();
        }

        private static void SaveReview(ShopDbContext db, string arguments)
        {
            var parts = arguments.Split(';');
            var customerId = int.Parse(parts[0]);
            var itemId = int.Parse(parts[1]);

            db.Add(new Review
            {
                CustomerId = customerId,
                ItemId = itemId
            });

            db.SaveChanges();
        }

        private static void PrintCustomersWithOrdersAndReviewsCount(ShopDbContext db)
        {
            var customersData = db
                .Customers
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count
                })
                .OrderByDescending(c => c.Orders)
                .ThenByDescending(c => c.Reviews)
                .ToList();

            foreach (var customer in customersData)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine($"Orders: {customer.Orders}");
                Console.WriteLine($"Reviews: {customer.Reviews}");
            }
        }

        private static void PrintCustomerOrdersAndReviews(ShopDbContext db)
        {
            int customerId = int.Parse(Console.ReadLine());

            var customerData = db
                .Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    Orders = c
                    .Orders
                    .Select(o => new
                    {
                        o.Id,
                        Items = o.Items.Count
                    })
                    .OrderBy(o => o.Id),
                    Reviews = c.Reviews.Count
                })
                .FirstOrDefault();
        }

        private static void PrintCustomerData(ShopDbContext db)
        {
            int customerId = int.Parse(Console.ReadLine());

            var customerData = db
                .Customers
                .Where(c => c.Id == customerId)
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count,
                    Salesman = c.Salesman.Name
                })
                .FirstOrDefault();

            Console.WriteLine($"Customer: {customerData.Name}");
            Console.WriteLine($"Orders count: {customerData.Orders}");
            Console.WriteLine($"Reviews count: {customerData.Reviews}");
            Console.WriteLine($"Salesman: {customerData.Salesman}");
        }

        private static void PrintOrdersWithMoreThanOneItem(ShopDbContext db)
        {
            int customerId = int.Parse(Console.ReadLine());

            var orders = db
                .Orders
                .Where(o => o.CustomerId == customerId)
                .Where(o => o.Items.Count > 1)
                .Count();

            Console.WriteLine($"Orders: {orders}");
        }
    }
}
