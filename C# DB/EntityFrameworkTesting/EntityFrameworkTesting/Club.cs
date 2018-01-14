namespace EntityFrameworkTesting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Club
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Club()
        {
            Athletes = new HashSet<Athlete>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClubID { get; set; }

        [Column("Club Name")]
        [Required]
        [StringLength(50)]
        public string Club_Name { get; set; }

        public int ClubTrainerID { get; set; }

        [Column("Monthly Fee")]
        [Required]
        [StringLength(50)]
        public string Monthly_Fee { get; set; }

        [Column("Training Days")]
        [Required]
        [StringLength(50)]
        public string Training_Days { get; set; }

        [Column("Active Hours")]
        [Required]
        [StringLength(50)]
        public string Active_Hours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Athlete> Athletes { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
