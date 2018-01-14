using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopDB.Models
{
    public enum Materials
    {
        Wood,Iron,Leather
    }

    public class Cage
    {
        [Key]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Notes { get; set; }
        

        public bool IsEmpty { get; set; }


        public Materials Matter { get; set; }


    }
}
