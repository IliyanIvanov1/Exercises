
namespace PetShopDB.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cat
    {
        private string stockname;

        public int Id { get; set; }

       // [Index(IsUnique = true)]
       // [Required]
        public string StockName { get; set; }

        public string Breed { get; set; }
    }
}
