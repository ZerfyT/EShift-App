using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Load> Loads { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Lorry> Lorries { get; set; }
        //public DbSet<Container> Containers { get; set; }
        public DbSet<TransportUnit> TransportUnits { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.PhoneNumber)
                .IsUnique();

            modelBuilder.Entity<Driver>()
                .HasIndex(d => d.LicenseNumber)
                .IsUnique();

            modelBuilder.Entity<Lorry>()
                .HasIndex(l => l.RegistrationNumber)
                .IsUnique();

            //modelBuilder.Entity<Container>()
            //    .HasIndex(c => c.ContainerNumber)
            //    .IsUnique();

            modelBuilder.Entity<Job>()
                .HasIndex(j => j.JobNumber)
                .IsUnique();

            modelBuilder.Entity<Load>()
                .HasIndex(l => l.LoadNumber)
                .IsUnique();

            // Customer -> Jobs (One-to-Many)
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Jobs)
                .WithOne(j => j.Customer)
                .HasForeignKey(j => j.CustomerID)
                .OnDelete(DeleteBehavior.Cascade);

            // Job -> Loads (One-to-Many)
            modelBuilder.Entity<Job>()
                .HasMany(j => j.Loads)
                .WithOne(l => l.Job)
                .HasForeignKey(l => l.JobID)
                .OnDelete(DeleteBehavior.Cascade);

            // Load -> TransportUnit (One-to-One, optional)
            modelBuilder.Entity<TransportUnit>()
                .HasMany(tu => tu.Loads)
                .WithOne(l => l.TransportUnit)
                .HasForeignKey(l => l.TransportUnitID)
                .OnDelete(DeleteBehavior.SetNull);

            // TransportUnit
            modelBuilder.Entity<Lorry>()
                .HasMany(l => l.TransportUnits)
                .WithOne(tu => tu.Lorry)
                .HasForeignKey(tu => tu.LorryID);

            modelBuilder.Entity<Driver>()
                .HasMany(d => d.TransportUnits)
                .WithOne(tu => tu.Driver)
                .HasForeignKey(tu => tu.DriverID);

            modelBuilder.Entity<Assistant>()
                .HasMany(a => a.TransportUnits)
                .WithOne(tu => tu.Assistant)
                .HasForeignKey(tu => tu.AssistantID);
        }
    }
}
