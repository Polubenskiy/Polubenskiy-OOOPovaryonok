using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OOOPovaryonok.Entities
{
    public partial class Trade : DbContext
    {
        public Trade()
            : base("name=TradeMainPC")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufacture> Manufacture { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderContent> OrderContent { get; set; }
        public virtual DbSet<PointIssue> PointIssue { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacture>()
                .Property(e => e.ManufactureName)
                .IsUnicode(false);

            modelBuilder.Entity<Manufacture>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Manufacture)
                .HasForeignKey(e => e.ProductManufacturerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderContent)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderContentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PointIssue>()
                .Property(e => e.PointIssueName)
                .IsUnicode(false);

            modelBuilder.Entity<PointIssue>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.PointIssue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderContent)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.OrderContentProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provider>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Provider)
                .HasForeignKey(e => e.ProductUnitID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.UserRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Unit)
                .WillCascadeOnDelete(false);
        }
    }
}
