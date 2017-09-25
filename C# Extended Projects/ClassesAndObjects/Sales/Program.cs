using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
   public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var dictOfSales = new SortedDictionary<string, decimal>();
            
            for (int i = 0; i < n; i++)
            {
                var saleAsString = Console.ReadLine();
                var currentSale = Sales.CreateSale(saleAsString);


                if (!dictOfSales.ContainsKey(currentSale.Town))
                {
                    dictOfSales[currentSale.Town] = 0;
                }
                var totalSale = currentSale.Price * currentSale.Quantity;
                dictOfSales[currentSale.Town] += totalSale;
            }
            foreach (var townTotalSales in dictOfSales)
            {
                Console.WriteLine($"{townTotalSales.Key} -> {townTotalSales.Value:F2}");
            }
        }
    }
}
