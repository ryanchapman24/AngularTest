namespace AngularTest
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AngularDB : DbContext
    {
        public AngularDB()
            : base("name=AngularDB")
        {
        }

        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<LabOrder> LabOrders { get; set; }
        public virtual DbSet<LabTest> LabTests { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facility>()
                .HasMany(e => e.LabOrders)
                .WithRequired(e => e.Facility)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LabOrder>()
                .Property(e => e.AmountBilled)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LabOrder>()
                .Property(e => e.AmountCollected)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LabTest>()
                .HasMany(e => e.LabOrders)
                .WithRequired(e => e.LabTest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.LabOrders)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);
        }
    }
}
