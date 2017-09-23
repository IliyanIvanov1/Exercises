using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please select your product: "  );
            var product = Console.ReadLine().ToLower();
            Console.Write("Please select your city: ");
            var city = Console.ReadLine().ToLower();
            Console.WriteLine("Please select the amount of the product you would like to purchase: ");
            var amount = double.Parse(Console.ReadLine());

            if (city == "Sofia" && product == "coffee")
            {
                Console.WriteLine(amount * 0.5);
            }
            else if (city == "Sofia" && product == "water")
            {
                Console.WriteLine(amount * 0.8);
            }
            else if (city == "Sofia" && product == "beer")
            {
                Console.WriteLine(amount * 1.2);
            }
            else if (city == "Sofia" && product == "sweets")
            {
                Console.WriteLine(amount * 1.45);
            }
            else if (city == "Sofia" && product == "peanuts")
            {
                Console.WriteLine(amount * 1.6);
            }
            if (city == "Plovdiv" && product == "coffee")
            {
                Console.WriteLine(amount * 0.4);
            }
            else if (city == "Plovdiv" && product == "water")
            {
                Console.WriteLine(amount * 0.7);
            }
            else if (city == "Plovdiv" && product == "beer")
            {
                Console.WriteLine(amount * 1.15);
            }

            else if (city == "Plovdiv" && product == "sweets")
            {
                Console.WriteLine(amount * 1.3);
            }
            else if (city == "Plovdiv" && product == "peanuts")
            {
                Console.WriteLine(amount * 1.5);
            }
            if (city == "Varna" && product == "coffee")
            {
                Console.WriteLine(amount * 0.45);
            }
            else if (city == "Varna" && product == "water")
            {
                Console.WriteLine(amount * 0.7);
            }
            else if (city == "Varna" && product == "beer")
            {
                Console.WriteLine(amount * 1.1);
            }
            else if (city == "Varna" && product == "sweets")
            {
                Console.WriteLine(amount * 1.35);
            }
            else if (city == "Varna" && product == "peanuts")
            {
                Console.WriteLine(amount * 1.55);
            }
            else
            {
                Console.WriteLine(  "Incorrect selection");
            }
        }
    }
}
