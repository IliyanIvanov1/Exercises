using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Data
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        public decimal Price { get; set; }


        public List<ItemOrder> Orders { get; set; } = new List<ItemOrder>(); //Many-to-Many


        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
