using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Sales
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sales CreateSale(string saleAsString)
        {
            var saleParts = saleAsString.Split(' ');

            return new Sales
            {
                Town = saleParts[0],
                Product = saleParts[1],
                Price=decimal.Parse(saleParts[2]),
                Quantity=decimal.Parse(saleParts[3])

            };

        }
    }
}
