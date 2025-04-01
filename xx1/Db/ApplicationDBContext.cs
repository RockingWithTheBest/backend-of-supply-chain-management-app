﻿using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using SupplyChain.Entities_Models_;
using xx1.Entities_Models_;
using xx1.Repository.Configurations;

namespace xx1.Db
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options)
        {
        }
     

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ChequeEntity> Cheques { get; set; }
        public DbSet<CashEntity> Cash { get; set; }
        public DbSet<DeliveryEntity> Deliveries { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ReturnEntity> Returns { get; set; }
        public DbSet<SupplierEntity> Supplies { get; set; }
        public DbSet<OrderCheckEntity> OrderChecks { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<InventoryEntity> Inventories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentEntity>()
                .HasOne(p => p.Cash) // PaymentEntity has one CashEntity
                .WithOne(c => c.Payment) // CashEntity has one PaymentEntity
                .HasForeignKey<CashEntity>(c => c.PaymentId); // Foreign key in CashEntity

            modelBuilder.Entity<PaymentEntity>()
                .HasOne(p => p.Cheque) // PaymentEntity has one ChequeEntity
                .WithOne(c => c.Payment) // CashEntity has one PaymentEntity
                .HasForeignKey<ChequeEntity>(c => c.PaymentId); // Foreign key in CashEntity

            modelBuilder.Entity<OrderCheckEntity>()
                .Property(o => o.Status)
                .HasDefaultValue("Order Supplied");

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
