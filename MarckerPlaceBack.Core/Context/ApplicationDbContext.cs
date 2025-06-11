using MarckerPlaceBack.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarckerPlaceBack.Core.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchare> Purchares { get; set; }
        public DbSet <PurchareToProduct> PurcharesToProducts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(c =>
            {
                c.Property(cp => cp.CategoryName).IsRequired();

                c.HasData(
                    new Category { CategoryId = 1, CategoryName = "Vegetables" },
                    new Category { CategoryId = 2, CategoryName = "Toys" },
                    new Category { CategoryId = 3, CategoryName = "cloth" }
                );
            });

            modelBuilder.Entity<Customer>(c =>
            {
                c.Property(cp => cp.Name).IsRequired();
                c.Property(cp => cp.LastName).IsRequired();
                c.Property(cp => cp.BirthDay).IsRequired();

                c.HasData(
                    new Customer { CustomerId = 1, Name = "John", LastName = "Dou", BirthDay = DateTime.Parse("03-01-1997") },
                    new Customer { CustomerId = 2, Name = "Jim", MiddleName = "Ben", LastName = "Smit", BirthDay = DateTime.Parse("08-04-2004") },
                    new Customer { CustomerId = 3, Name = "Debra", LastName = "Smit", BirthDay = DateTime.Parse("03-01-2005") }
                );
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.Property(pp => pp.Name).IsRequired();
                p.Property(pp => pp.CategoryId).IsRequired();
                p.Property(pp => pp.Articul).IsRequired();
                p.Property(pp => pp.Price).IsRequired();

                p.HasData(
                    new Product { ProductId = 1, CategoryId = 1, Name = "Cucumber", Articul = (new Guid()).ToString(), Price = 0.85m },
                    new Product { ProductId = 2, CategoryId = 1, Name = "Tomato", Articul = (new Guid()).ToString(), Price = 1.10m },
                    new Product { ProductId = 3, CategoryId = 2, Name = "Hot Wheels Car", Articul = (new Guid()).ToString(), Price = 2.99m },
                    new Product { ProductId = 4, CategoryId = 3, Name = "T-Shirt", Articul = (new Guid()).ToString(), Price = 3.60m },
                    new Product { ProductId = 5, CategoryId = 3, Name = "Pants", Articul = (new Guid()).ToString(), Price = 12.50m }
                );
            });

            modelBuilder.Entity<Purchare>(p =>
            {
                p.Property(p => p.PurchareDate).IsRequired();
                p.Property(p => p.TotalPrice).IsRequired();

                p.HasData(
                    //2 Cucumbers and 1 Tomato
                    new Purchare { PurchareId = 1, CustomerId = 1, PurchareDate = DateTime.Parse("04-06-2025 12:00:00"), TotalPrice = 2.80m },
                    //One Pants
                    new Purchare { PurchareId = 2, CustomerId = 2, PurchareDate = DateTime.Parse("06-06-2025 11:25:00"), TotalPrice = 12.50m },
                    //Two T-Shirt and 10 Tomatos
                    new Purchare { PurchareId = 3, CustomerId = 2, PurchareDate = DateTime.Parse("06-06-2025 12:10:00"), TotalPrice = 18.2m },
                    //10 Cucumbers and 5 Tomatos
                    new Purchare { PurchareId = 4, CustomerId = 3, PurchareDate = DateTime.Parse("07-06-2025 14:00:00"), TotalPrice = 14m },
                    //1 Hot Wheels Car
                    new Purchare { PurchareId = 5, CustomerId = 1, PurchareDate = DateTime.Parse("08-06-2025 10:00:00"), TotalPrice = 2.99m }
                );
            });

            modelBuilder.Entity<PurchareToProduct>(ptp =>
            {
                ptp.Property(p => p.PurchareId).IsRequired();
                ptp.Property(p => p.ProductId).IsRequired();
                ptp.Property(p => p.ProductsCount).IsRequired();

                ptp.HasData(
                    new PurchareToProduct { PurchareToProductId = 1, PurchareId = 1, ProductId = 1, ProductsCount = 2 },
                    new PurchareToProduct { PurchareToProductId = 2, PurchareId = 1, ProductId = 2, ProductsCount = 1 },

                    new PurchareToProduct { PurchareToProductId = 3, PurchareId = 2, ProductId = 5, ProductsCount = 1 },

                    new PurchareToProduct { PurchareToProductId = 4, PurchareId = 3, ProductId = 4, ProductsCount = 2 },
                    new PurchareToProduct { PurchareToProductId = 5, PurchareId = 3, ProductId = 2, ProductsCount = 10 },

                    new PurchareToProduct { PurchareToProductId = 6, PurchareId = 4, ProductId = 1, ProductsCount = 10 },
                    new PurchareToProduct { PurchareToProductId = 7, PurchareId = 4, ProductId = 2, ProductsCount = 5 },

                    new PurchareToProduct { PurchareToProductId = 8, PurchareId = 5, ProductId = 3, ProductsCount = 1 }
                );
            });
        }
    }
}
