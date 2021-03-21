using FitnessTracker.Controllers;
using FitnessTracker.Data;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace FitnessTracker.Tests
{
    public class FoodTests
    {
        
        private FoodController foodContr;
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestIfGetAllUserFoodsReturnsCorrectData()
        {
            string exampleUserId = "1";
            var options = new DbContextOptionsBuilder<FitnessTrackerDBContext>()
                .UseInMemoryDatabase(databaseName: "FoodListDatabase")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new FitnessTrackerDBContext(options))
            {
                context.Foods.Add(new Food() { Id = 1, Name = "Apple", UserId = exampleUserId});
                context.Foods.Add(new Food() { Id = 2, Name = "Pear", UserId = exampleUserId});
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new FitnessTrackerDBContext(options))
            {
                foodContr = new FoodController(context);
                Assert.That(foodContr.GetAllUserFoods(exampleUserId).Count == 2, "No foods gets added into the database!");
            }
        }
    }
}
