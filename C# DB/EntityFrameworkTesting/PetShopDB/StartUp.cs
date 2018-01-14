using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopDB.Models
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            PetshopContext context = new PetshopContext();

            
            try
            {
                //Cat cat = new Cat
                //{
                //    StockName = "Kote"
                //};

                //Cat cat2 = new Cat
                //{
                //    StockName = "Kote"
                //};
                //context.Cats.Add(cat);
                //context.Cats.Add(cat2);

                Person person = new Person
                {
                    FirstName="Nasko",
                    LastName="Ivanov",
                    Age = 70
                };
                context.People.Add(person);

                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var EntityValidationResult in ex.EntityValidationErrors)
                {
                    foreach (var ValidationError in EntityValidationResult.ValidationErrors)
                    {
                        Console.WriteLine(ValidationError.ErrorMessage);
                    }
                }   
            }
        }
    }
}
