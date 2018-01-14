namespace EntityFrameworkTesting
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SportComplexContext : DbContext
    {
        public SportComplexContext()
            : base("name=SportComplexContext")
        {
        }

        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<Athlete> Athletes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .Property(e => e.Club_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.Monthly_Fee)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.Training_Days)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .Property(e => e.Active_Hours)
                .IsUnicode(false);

            modelBuilder.Entity<Club>()
                .HasMany(e => e.Athletes)
                .WithRequired(e => e.Club)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.DepartmentName)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Athletes)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Workers)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.PIN)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Occupation)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .Property(e => e.Salary)
                .IsUnicode(false);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Clubs)
                .WithRequired(e => e.Worker)
                .HasForeignKey(e => e.ClubTrainerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Athlete>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Athlete>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Athlete>()
                .Property(e => e.PIN)
                .IsUnicode(false);
        }
    }
}
