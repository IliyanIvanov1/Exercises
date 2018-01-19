using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject.Models
{
    public class Startup
    {
        public static void Main()
        {
            PeopleContext context = new PeopleContext();
            //Person personOne = new Person
            //{
            //    Name = "Ivan"
            //};

            //Person personTwo = new Person
            //{
            //    Name = "Stamat"
            //};

            //context.People.Add(personOne);
            ////context.People.Add(personTwo);


            //Person ivanPerson = context.People.First();
            //ivanPerson.Name = "Yani";


            try
            {
                Person person = new Person();
                
                person.Name = "ivailo";
                person.Account.AccountNumber = "12356789";
                person.Account.MonthRate = 1000;
                person.Account.Balance = 30000;

                context.People.Add(person);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var DBEntityValidationResults in ex.EntityValidationErrors)
                {
                    foreach (var DBValidationError in DBEntityValidationResults.ValidationErrors)
                    {
                        Console.WriteLine(DBValidationError.ErrorMessage);
                    }
                }
                
            }


        }
    }
}
