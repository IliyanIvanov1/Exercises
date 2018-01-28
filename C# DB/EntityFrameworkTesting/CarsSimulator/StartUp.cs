using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSimulator
{
    using CarsSimulator.Models;
    public class StartUp
    {
        public static void Main()
        {
            CarsContext context = new CarsContext();
             context.Cars.Add(new BatMobile()
             {
               //Id = 1, 
                 Logo = "iBat",
                 Manufacturer = "Lada",
                 Model = "Special",
                 NumberOfWings = 2,
                 Price = 20.1m
             });
            
             context.Cars.Add(new LuxuriousCar()
             {
               //Id = 2,
                 Manufacturer="FakeCompany",
                 Model="Taxi",
                 Price=10.30m,
                 HotTubeModel="Night",
                 LitersOfChampagne=2
             });
            //context.Cars.OfType<BatMobile>().First();

            context.SaveChanges();  
        }
    }
}
