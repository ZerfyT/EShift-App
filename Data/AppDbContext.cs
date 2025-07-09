using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShift_App.Model;
using Microsoft.EntityFrameworkCore;

namespace EShift_App.Data
{
    public class AppDbContext:DbContext
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
            modelBuilder.Entity<Load>()
                .HasOne(l => l.Container)
                .WithMany(c => c.Loads)
                .HasForeignKey(l => l.ContainerID);
        }
    }
}
