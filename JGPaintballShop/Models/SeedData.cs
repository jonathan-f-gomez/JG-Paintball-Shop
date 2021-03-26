using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace JGPaintballShop.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Empire Gun - Axe 2.0",
                    Description = "Empire Axe 2.0 Gun Pressure controlled poppet engine for proven, reliable performance",
                    Category = "Marker",
                    Price = 449.95m
                },
                new Product
                {
                    Name = "Empire Gun - Mini GS",
                    Description = "next generation of legendary paintball marker",
                    Category = "Marker",
                    Price = 329.95m
                },
                new Product
                {
                    Name = "Dye Mask - i4",
                    Description = "Comfortable anatomic mask fit keeps it in place and makes it comfortable to wear",
                    Category = "Mask",
                    Price = 124.95m
                },
                new Product
                {
                    Name = "Base Mask - GS-F",
                    Description = "Comes in Black, Green, or Gray",
                    Category = "Mask",
                    Price = 25.95m
                },
                new Product
                {
                    Name = "Speedball Field",
                    Description = "Fully Furnished Speedball Field",
                    Category = "Paintball",
                    Price = 79500
                },
                new Product
                {
                    Name = "Thinking Cap",
                    Description = "Improve brain efficiency by 75%",
                    Category = "Chess",
                    Price = 16
                },
                new Product
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
                    Category = "Chess",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Human Chess Board",
                    Description = "A fun game for the family",
                    Category = "Chess",
                    Price = 75
                },
                new Product
                {
                    Name = "Bling-Bling King",
                    Description = "Gold-plated, diamond-studded King",
                    Category = "Chess",
                    Price = 1200
                }
                );
                context.SaveChanges();
            }
        }
    }
}
