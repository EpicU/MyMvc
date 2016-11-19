using MyMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMvc.Contexts
{
    public class MyStoreDbContext : DbContext
    {
        public MyStoreDbContext()
            : base("Server=(local);Database=MyStore;Trusted_Connection=True;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MyStoreDbContext>(null);

            modelBuilder.Entity<Product>()
                .HasRequired(c => c.ProductCategory);
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}