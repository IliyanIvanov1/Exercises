using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data
{
    public class Order
    {
        public int Id { get; set; }


        public int CustomerId { get; set; }


        public Customer Customer { get; set; }


        public List<ItemOrder> Items { get; set; } = new List<ItemOrder>(); //Many-to-Many 
    }
}
