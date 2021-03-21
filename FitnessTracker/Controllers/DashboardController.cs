using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Data;
using FitnessTracker.Models;
using FitnessTracker.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        protected FitnessTrackerDBContext _db;
        protected User user;
        public DashboardController(FitnessTrackerDBContext context, SignInManager<IdentityUser> _signInManager, UserManager<IdentityUser> _userManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            _db = context;
        }
        public IActionResult RenderMain()
        {
            user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            var returnView = new InsightsViewModel();
            returnView.RequiredCalories = GetMaintainCalories(user);
            returnView.currentDailyCalories = GetCurrentUserCalorieCount(user);
            returnView.userWorkouts = _db.Workouts
                .Where(w => w.UserId == user.Id)
                .Select(w => new InsightWorkoutsViewModel()
                {
                    Name = w.Name,
                    ExerciseCount = w.Exercises.Count
                }).ToList();

            return View("GeneralPage", returnView);
        }

        public double? GetMaintainCalories(User user)
        {
            //calculate BMR
            double defaultActivityLevel = 1.4;
            double? BMR = null;
            if (user.Gender == "Male")
            {
                BMR = (10 * user.Weight / 1 + 6.25 * user.Height / 1 - 5 * user.Age / 1 + 5);
            }
            else
            {
                BMR = (10 * user.Weight / 1 + 6.25 * user.Height / 1 - 5 * user.Age / 1 - 161);
            }
            //multiply by assigned activity level
            BMR *= defaultActivityLevel;
            //return BMR representing the required calories
            return BMR;
        }

        public double? GetCurrentUserCalorieCount(User user)
        {
            //to get daily calories we need to check if food has been added within the last 24 hours
            //before that we filter out all the user food using the relation between user and food tables in the db
            var nowDate = DateTime.Now;
            var userFoods = _db.Foods.Where(f => f.UserId == user.Id && f.DateAdded > nowDate.AddHours(-24) && f.DateAdded <= nowDate);

            double caloryCount = 0;
            foreach (var userFood in userFoods)
            {
                caloryCount += userFood.Calories;
            }

            return caloryCount;
        }
    }
}
