using System;
using MariaDbWithNetCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace MariaDbWithNetCore.Api
{
    public class MariaDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductInStore> ProductInStores { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreShare> StoreShares { get; set; }

        public MariaDbContext()
        { }
        public MariaDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductInStore>()
                .Property(c => c.HasShortage)
                .HasDefaultValue(false);

            modelBuilder.Entity<ProductInStore>()
                .Property(c => c.ShortageDateTime)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<StoreShare>()
                .Property(c => c.SharePercent)
                .HasDefaultValue(0);

            modelBuilder.Entity<ProductInStore>()
                .HasKey(nameof(ProductInStore.ProductId), nameof(ProductInStore.StoreId));

            modelBuilder.Entity<StoreShare>()
                .HasKey(nameof(StoreShare.StoreId), nameof(StoreShare.GroupId));
        }
    }
}
