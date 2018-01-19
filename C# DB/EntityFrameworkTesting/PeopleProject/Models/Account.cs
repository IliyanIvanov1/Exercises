

namespace PeopleProject.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [ComplexType]
    public class Account
    {
        public decimal Balance { get; set; }


        public decimal MonthRate { get; set; }


        public string AccountNumber { get; set; }
    }
}
