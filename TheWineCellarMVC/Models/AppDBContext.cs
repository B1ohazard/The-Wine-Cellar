using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Models
{
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        // Constructor
        public AppDBContext(DbContextOptions<AppDBContext> options) :
            // Parse options to the database 
            base(options)
        {
        }

        // db set names --> what sets do you want to create
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // prepopulated data --> to place into the Db

            //Seeding a 'Administrator' role to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() });

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();

            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                UserName = "admin@twc.com",
                    NormalizedUserName = "ADMIN@TWC.COM",
                    PasswordHash = hasher.HashPassword(null, "Admin#123")
                }
            );

            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
            );

            // Seeding two farmers
            modelBuilder.Entity<Farmer>().HasData(
            new Farmer { FarmerId = 1, FirstName = "Jeffrey", LastName = "Knowles", ContactNumber = 0816257101 },
            new Farmer { FarmerId = 2, FirstName = "Arthur", LastName = "Hogget", ContactNumber = 0728991053 });

            // Seeding two products to database
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                ProductName = "Nedergberg Merlot",
                ProductDescription = "Our Merlot is an elegant red wine with a velvety texture and a bouquet of ripe red cherries, blackberries, and a touch of tobacco.",
                Category = "Red",
                ProductPrice = 349,
                ProductQuantity = 3,
                Date = DateTime.Now,
                ProductImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHnX_cZ-uOE_Xdb4fu3wdUVv0zwjmi3G8joA&usqp=CAU",
                FarmerId = "1"    
            },

             new Product
             {
                 ProductId = 2,
                 ProductName = "Ken Forrester sauvignon blanc",
                 ProductDescription = "Experience the vibrant allure of our Sauvignon Blanc, bursting with aromas of fresh-cut grass, citrus blossoms, and tropical fruits.",
                 Category = "White",
                 ProductPrice = 299,
                 ProductQuantity = 2,
                 Date = DateTime.Now,
                 ProductImage = "https://kenforresterwines.com/wp-content/uploads/2020/01/reserve-sauvignon-blanc-thegem-blog-timeline-large.jpg",
                 FarmerId = "2"
             });
        }
    }
}

