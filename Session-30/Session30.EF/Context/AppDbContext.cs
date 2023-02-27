using Microsoft.EntityFrameworkCore;
using Session30.EF.Configurations;
using Session30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session30.EF.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<TransactionLine> TransactionLines { get; set; } = null!;
        public DbSet<Rent> Rents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
            modelBuilder.ApplyConfiguration(new RentConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FuelStation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
