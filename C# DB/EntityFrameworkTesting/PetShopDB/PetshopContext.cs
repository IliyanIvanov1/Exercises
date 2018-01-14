namespace PetShopDB.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PetshopContext : DbContext
    {
        // Your context has been configured to use a 'PetshopContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PetShopDB.PetshopContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PetshopContext' 
        // connection string in the application configuration file.
        public PetshopContext()
            : base("name=PetshopContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual IDbSet<Cat> Cats { get; set; }

        public virtual IDbSet<Dog> Dogs { get; set; }

        public virtual IDbSet<Cage> Cages { get; set; }

        public virtual IDbSet<Person> People { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}