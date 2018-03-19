

namespace Shop.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        public int SalesmanId { get; set; }


        public Salesman Salesman { get; set; }


        public List<Order> Orders { get; set; } = new List<Order>();


        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
