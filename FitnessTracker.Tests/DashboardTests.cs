using FitnessTracker.Controllers;
using FitnessTracker.Data;
using FitnessTracker.Models;
using Moq;
using NUnit.Framework;

namespace FitnessTracker.Tests
{
    public class Tests
    {
        private User user = new User();
        private DashboardController dashboardC = new DashboardController(null, null, null);

        [SetUp]
        public void Setup()
        {
            user.Weight = 78;
            user.Age = 18;
            user.Height = 182;
        }

        [Test]
        public void TestIfGetCurrentUserCalorieCountReturnsCorrectResultsForMale()
        {
            user.Gender = "Male";
            double expectedReturnValue = 2565.5;
            double? actualReturnValue = dashboardC.GetMaintainCalories(user);
            Assert.That(actualReturnValue.Equals(expectedReturnValue), "Method does not return correct data for male individuals!");
            
        }
        [Test]
        public void TestIfGetCurrentUserCalorieCountReturnsCorrectResultsForFemale()
        {
            user.Gender = "Female";
            double expectedReturnValue = 2333.1;
            double? actualReturnValue = dashboardC.GetMaintainCalories(user);
            Assert.That(actualReturnValue.Equals(expectedReturnValue), "Method does not return correct data for female individuals!");
        }
    }
}