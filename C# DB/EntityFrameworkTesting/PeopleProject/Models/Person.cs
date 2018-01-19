using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject.Models
{
    using PeopleProject.Attributes;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PeopleInformation")]
    public class Person
    {
        public Person()
        {
            Account = new Account();
        }
        //[Key]
        public int ID { get; set; }

        [NameValidation] //using Custom Attribute
        public string Name { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }


        public Account Account { get; set; }    
    }
}
