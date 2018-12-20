namespace PenaltyManager
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RoadPenaltyContext : DbContext
    {
        public RoadPenaltyContext()
            : base("name=RoadPenaltiesContext")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Automobile> Automobiles { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Violation> Violations { get; set; }
        public virtual DbSet<ViolationType> ViolationTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automobile>()
                .HasMany(e => e.Violations)
                .WithRequired(e => e.Automobile)
                .HasForeignKey(e => e.Automobile_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Automobile>()
                .HasMany(e => e.Drivers)
                .WithMany(e => e.Automobiles)
                .Map(m => m.ToTable("Cars_Drivers").MapLeftKey("Car_id"));

            modelBuilder.Entity<Color>()
                .Property(e => e.ColorName)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.Color)
                .HasForeignKey(e => e.Color_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.License)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Violations)
                .WithRequired(e => e.Driver)
                .HasForeignKey(e => e.Driver_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Insurance>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Insurance>()
                .HasMany(e => e.Automobiles)
                .WithOptional(e => e.Insurance)
                .HasForeignKey(e => e.Insurance_id);

            modelBuilder.Entity<Insurance>()
                .HasMany(e => e.Drivers)
                .WithMany(e => e.Insurances)
                .Map(m => m.ToTable("Insurance_Driver"));

            modelBuilder.Entity<Manufacturer>()
                .Property(e => e.ManufacturerName)
                .IsUnicode(false);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Models)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.Manufacturer_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.Model1)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Automobiles)
                .WithRequired(e => e.Model)
                .HasForeignKey(e => e.Model_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Violation>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Violation>()
                .Property(e => e.Date)
                .IsRequired();

            modelBuilder.Entity<ViolationType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<ViolationType>()
                .HasMany(e => e.Violations)
                .WithRequired(e => e.ViolationType)
                .WillCascadeOnDelete(false);
        }
    }
}
