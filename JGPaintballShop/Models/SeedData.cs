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
                    Category = "Markers",
                    Price = 449.95m
                },

                new Product
                {
                    Name = "Empire Gun - Mini GS",
                    Description = "next generation of legendary paintball marker",
                    Category = "Markers",
                    Price = 329.95m
                },

                new Product
                {
                    Name = "Dye Mask - i4",
                    Description = "Comfortable anatomic mask fit keeps it in place and makes it comfortable to wear",
                    Category = "Masks",
                    Price = 124.95m
                },

                new Product
                {
                    Name = "Base Mask - GS-F",
                    Description = "Comes in Black, Green, or Gray",
                    Category = "Masks",
                    Price = 25.95m
                },

                new Product
                {
                    Name = "Speedball Field",
                    Description = "Fully Furnished Speedball Field",
                    Category = "Fields",
                    Price = 79500
                },

                new Product
                {
                    Name = "Dye Navigator 2.50S Gear Bag",
                    Description = "The Dye Navigator's unique design allows you to isolate your dirty field gear from your clean street clothes.",
                    Category = "Bags & Backpacks",
                    Price = 254.96m
                },

                new Product
                {
                    Name = "Planet Eclipse GX2 Marker Pack",
                    Description = "The Eclipse GX2 Marker Packs new secure barrel pocket opens up for complete accessibility and supports barrel sections up-to 11 Inches/28cm making it Shaft FL compatible.",
                    Category = "Bags & Backpacks",
                    Price = 29.95m
                },

                new Product
                {
                    Name = "HK Army expand Backpack/Gear Bag",
                    Description = "The Expand Gear Bag capacity can be increased by 30% by simply fully opening the bottom compartment.",
                    Category = "Bags & Backpacks",
                    Price = 109.95m
                },


                new Product
                {
                    Name = "Ninja Flat Bottom Compressed Air Tank w/ Adjustable Regulator - 35/3000",
                    Description = "The Ninja Paintball tank is one of the newest and most respected tanks in the paintball industry.",
                    Category = "Hoppers & Tanks",
                    Price = 64.95m
                },

                new Product
                {
                    Name = "Empire Mega Lite 68/4500 Compressed Air Paintball Tank",
                    Description = "Empire Mega Lite Systems offer an affordable option to the player who wants to upgrade to a High Pressure Air system.",
                    Category = "Hoppers & Tanks",
                    Price = 149.95m
                },

                new Product
                {
                    Name = "Dye Rotor R2 Paintball Loader",
                    Description = "After years of research and development and consulting with paintball’s top athletes, HK Army is proud to present you with the best loader experience paintball has to offer; The TFX.",
                    Category = "Hoppers & Tanks",
                    Price = 214.95m
                },

                new Product
                {
                    Name = "Empire Prophecy Z2 Paintball Loader",
                    Description = "The Empire Prophecy tradition continues with the release of the Prophecy Z2 Paintball Loader.",
                    Category = "Hoppers & Tanks",
                    Price = 169.95m
                }
                );
                context.SaveChanges();
            }
        }
    }
}
