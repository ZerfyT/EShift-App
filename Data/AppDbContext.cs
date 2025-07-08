using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data
{
    internal class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Load> Loads { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Lorry> Lorries { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<TransportUnit> TransportUnits { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Job>()
                .HasOne(j => j.Customer)
                .WithMany(c => c.Jobs)
                .HasForeignKey(j => j.CustomerID);
            modelBuilder.Entity<Load>()
                .HasOne(l => l.Job)
                .WithMany(j => j.Loads)
                .HasForeignKey(l => l.JobID);
            modelBuilder.Entity<Load>()
                .HasOne(l => l.TransportUnit)
                .WithMany()
                .HasForeignKey(l => l.TransportUnitID);
            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Lorry)
                .WithMany(l => l.Drivers)
                .HasForeignKey(d => d.LorryID);
            modelBuilder.Entity<Assistant>()
                .HasOne(a => a.Lorry)
                .WithMany(l => l.Assistants)
                .HasForeignKey(a => a.LorryID);
            modelBuilder.Entity<Container>()
                .HasOne(c => c.TransportUnit)
                .WithMany(t => t.Containers)
                .HasForeignKey(c => c.TransportUnitID);
            modelBuilder.Entity<TransportUnit>()
                .HasMany(t => t.Containers)
                .WithOne(c => c.TransportUnit)
                .HasForeignKey(c => c.TransportUnitID);
            modelBuilder.Entity<TransportUnit>()
                .HasMany(t => t.Loads)
                .WithOne(l => l.TransportUnit)
                .HasForeignKey(l => l.TransportUnitID);
            modelBuilder.Entity<TransportUnit>()
                .HasMany(t => t.Jobs)
                .WithOne(j => j.TransportUnit)
                .HasForeignKey(j => j.TransportUnitID);
            modelBuilder.Entity<TransportUnit>()
                .HasMany(t => t.Drivers)
                .WithOne(d => d.TransportUnit)
                .HasForeignKey(d => d.TransportUnitID);
        }
    }
}
