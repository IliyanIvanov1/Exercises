namespace EntityFrameworkTesting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            Clubs = new HashSet<Club>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkersID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("Last name")]
        [Required]
        [StringLength(100)]
        public string Last_name { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        [Required]
        [StringLength(100)]
        public string PIN { get; set; }

        [Required]
        [StringLength(100)]
        public string Occupation { get; set; }

        [Column("Started work on:", TypeName = "date")]
        public DateTime Started_work_on_ { get; set; }

        public int DepartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Salary { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Club> Clubs { get; set; }

        public virtual Department Department { get; set; }
    }
}
