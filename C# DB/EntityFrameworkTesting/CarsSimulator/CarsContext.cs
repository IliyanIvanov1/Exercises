namespace CarsSimulator
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CarsSimulator.Models;
    public class CarsContext : DbContext
    {
        public CarsContext()
            : base("name=CarsContext")
        {

        }
        public virtual IDbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>()
            //    .Map<LuxuriousCar>(m => m.Requires("Type").HasValue("Lux"))    (1)
            //    .Map<BatMobile>(m => m.Requires("Type").HasValue("Batty"));

            modelBuilder.Entity<LuxuriousCar>().ToTable("LuxuriousCars");     // (2)
            modelBuilder.Entity<BatMobile>().ToTable("BatMobiles");

            //modelBuilder.Entity<LuxuriousCar>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("LuxuriousCars");                                    (3)  
            //});
            //
            //modelBuilder.Entity<BatMobile>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("Batmobiles");
            //});

            base.OnModelCreating(modelBuilder);
        }

    }
}