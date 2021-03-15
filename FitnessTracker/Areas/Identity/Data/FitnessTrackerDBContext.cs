using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Data
{
    public class FitnessTrackerDBContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Excercise> Exercises { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BodyPart> BodyParts { get; set; }

        public DbSet<User> Users { get; set; }

        public FitnessTrackerDBContext(DbContextOptions<FitnessTrackerDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //add data seeding...
            builder.Entity<Food>().HasData(
                new Food { Id = 1, Name = "Boneless, Skinless Chicken Breast", Calories = 119, Fat = 3, Protein = 23, Carbohydrates = 0 },
                new Food { Id = 2, Name = "Tuna(water packed), can", Calories = 81, Fat = 1, Protein = 18, Carbohydrates = 0 },
                new Food { Id = 3, Name = "Salmon Filet", Calories = 78, Fat = 2, Protein = 15, Carbohydrates = 0 },
                new Food { Id = 4, Name = "Schrimp", Calories = 123, Fat = 3, Protein = 24, Carbohydrates = 0 },
                new Food { Id = 5, Name = "Extra Lean Ground Beef or Ground Round", Calories = 121, Fat = 4, Protein = 24, Carbohydrates = 0 },
                new Food { Id = 6, Name = "Egg", Calories = 69, Fat = 5, Protein = 6, Carbohydrates = 0 },
                new Food { Id = 7, Name = "Egg Whites", Calories = 52, Fat = 0, Protein = 11, Carbohydrates = 0 },
                new Food { Id = 8, Name = "Rib eye Steak", Calories = 235, Fat = 15, Protein = 25, Carbohydrates = 0 },
                new Food { Id = 9, Name = "Top round Steak", Calories = 212, Fat = 8, Protein = 35, Carbohydrates = 0 },
                new Food { Id = 10, Name = "Sirloin steak", Calories = 275, Fat = 15, Protein = 35, Carbohydrates = 0 },
                new Food { Id = 11, Name = "Filet Mignon", Calories = 200, Fat = 8, Protein = 32, Carbohydrates = 0 },
                new Food { Id = 12, Name = "NY Strip Steak", Calories = 100, Fat = 4, Protein = 16, Carbohydrates = 0 },
                new Food { Id = 13, Name = "Flank Steak(Stir Fry, Fajita)", Calories = 200, Fat = 8, Protein = 32, Carbohydrates = 0 },
                new Food { Id = 14, Name = "Pork Loin", Calories = 146, Fat = 6, Protein = 23, Carbohydrates = 0 },
                new Food { Id = 15, Name = "Ground turkey(Turkey Breast Slices or cutlets(fresh meat, not deli cuts)", Calories = 122, Fat = 2, Protein = 26, Carbohydrates = 0 },
                new Food { Id = 16, Name = "Sweet Potatoes, raw", Calories = 100, Fat = 0, Protein = 2, Carbohydrates = 23 },
                new Food { Id = 17, Name = "Quinoa", Calories = 272, Fat = 0, Protein = 6, Carbohydrates = 62 },
                new Food { Id = 18, Name = "Oats", Calories = 347, Fat = 7, Protein = 11, Carbohydrates = 60 },
                new Food { Id = 19, Name = "Old Fashioned Grifts", Calories = 459, Fat = 3, Protein = 12, Carbohydrates = 96 },
                new Food { Id = 20, Name = "White Rice", Calories = 360, Fat = 0, Protein = 6, Carbohydrates = 84 },
                new Food { Id = 21, Name = "White Potatoes, raw", Calories = 88, Fat = 0, Protein = 2, Carbohydrates = 20 },
                new Food { Id = 22, Name = "Lettuce", Calories = 12, Fat = 0, Protein = 1, Carbohydrates = 2 },
                new Food { Id = 23, Name = "Broccoli", Calories = 32, Fat = 0, Protein = 2, Carbohydrates = 6 },
                new Food { Id = 24, Name = "Asparagus", Calories = 24, Fat = 0, Protein = 2, Carbohydrates = 4 },
                new Food { Id = 25, Name = "Spinach", Calories = 8, Fat = 0, Protein = 1, Carbohydrates = 1 },
                new Food { Id = 26, Name = "Multi Colored Bell Peppers", Calories = 12, Fat = 0, Protein = 1, Carbohydrates = 2 },
                new Food { Id = 27, Name = "Brussels Sprouts", Calories = 20, Fat = 0, Protein = 1, Carbohydrates = 4 },
                new Food { Id = 28, Name = "Cauliflower", Calories = 28, Fat = 0, Protein = 2, Carbohydrates = 5 },
                new Food { Id = 29, Name = "Zucchini", Calories = 24, Fat = 0, Protein = 2, Carbohydrates = 4 },
                new Food { Id = 30, Name = "Cucumber", Calories = 20, Fat = 0, Protein = 1, Carbohydrates = 4 },
                new Food { Id = 31, Name = "Mushrooms", Calories = 16, Fat = 0, Protein = 2, Carbohydrates = 2 },
                new Food { Id = 32, Name = "Apple", Calories = 60, Fat = 0, Protein = 0, Carbohydrates = 15 },
                new Food { Id = 33, Name = "Banana", Calories = 112, Fat = 0, Protein = 1, Carbohydrates = 27 },
                new Food { Id = 34, Name = "Mango", Calories = 80, Fat = 0, Protein = 1, Carbohydrates = 19 },
                new Food { Id = 35, Name = "Navel orange", Calories = 72, Fat = 0, Protein = 2, Carbohydrates = 16 },
                new Food { Id = 36, Name = "Blueberries", Calories = 44, Fat = 0, Protein = 0, Carbohydrates = 11 },
                new Food { Id = 37, Name = "Strawberries", Calories = 40, Fat = 0, Protein = 1, Carbohydrates = 9 },
                new Food { Id = 38, Name = "Blackberries", Calories = 60, Fat = 0, Protein = 1, Carbohydrates = 14 },
                new Food { Id = 39, Name = "Almond Butter", Calories = 704, Fat = 56, Protein = 22, Carbohydrates = 28 },
                new Food { Id = 40, Name = "Olive Oil", Calories = 1008, Fat = 112, Protein = 0, Carbohydrates = 0 },
                new Food { Id = 41, Name = "Clarified or organic butter", Calories = 504, Fat = 56, Protein = 0, Carbohydrates = 0 },
                new Food { Id = 42, Name = "Coconut oil", Calories = 1008, Fat = 112, Protein = 0, Carbohydrates = 0 },
                new Food { Id = 43, Name = "Avocado", Calories = 142, Fat = 14, Protein = 2, Carbohydrates = 2 }
                );

            builder.Entity<BodyPart>().HasData(
                new BodyPart { Id = 1, Name = "Core" },
                new BodyPart { Id = 2, Name = "Arms" },
                new BodyPart { Id = 3, Name = "Back" },
                new BodyPart { Id = 4, Name = "Chest" },
                new BodyPart { Id = 5, Name = "Legs" },
                new BodyPart { Id = 6, Name = "Shoulders" },
                new BodyPart { Id = 7, Name = "Other" },
                new BodyPart { Id = 8, Name = "Full Body" }
            );
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cardio" },
                new Category { Id = 2, Name = "Dumbbell" },
                new Category { Id = 3, Name = "Bodyweight" },
                new Category { Id = 4, Name = "Barbell" },
                new Category { Id = 5, Name = "Machine/Other" }
            );
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
