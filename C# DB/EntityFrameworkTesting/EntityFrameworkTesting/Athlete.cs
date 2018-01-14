namespace EntityFrameworkTesting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Athlete
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column("Last Name", Order = 1)]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string PIN { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClubID { get; set; }

        public virtual Club Club { get; set; }

        public virtual Department Department { get; set; }
    }
}
