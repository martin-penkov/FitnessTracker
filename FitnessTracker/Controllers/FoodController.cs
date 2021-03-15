using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Data;
using FitnessTracker.Migrations;
using FitnessTracker.Models;
using FitnessTracker.ViewModels;

namespace FitnessTracker.Controllers
{
    public class FoodController : Controller
    {
        protected FitnessTrackerDBContext _db;
        public FoodController(FitnessTrackerDBContext context)
        {
            _db = context;
        }
        public IActionResult FoodHistory()
        {
            FoodHistoryViewModel foodData = new FoodHistoryViewModel()
            {
                foods = GetAllUserFoods()
            };
            return View(foodData);
        }

        public IActionResult AddFood()
        {
            CreateFoodViewModel inputFoods = new CreateFoodViewModel();
            List<Food> allFoods = _db.Foods.OrderBy(f => f).ToList();
            inputFoods.allFoods = allFoods;
            inputFoods.uniqueFoods = allFoods.Select(f => f.Name).Distinct().OrderBy(f => f).ToList();
            return View("FoodCreate", inputFoods);
        }

        public IActionResult AddFoodAction(Food food)
        {
            _db.Foods.Add(food);
            _db.SaveChanges();
            return RedirectToAction("RenderMain", "Dashboard");
        }

        public IActionResult AddPreAddedFood(PreAddedFoodViewModel inputData)
        {
            string userId = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            if (userId == null)
            {
                throw new Exception("No Authenticated user could be found!");
            }
            int count = inputData.Number;
            string foodName = inputData.Name;
            Food foodInfo = _db.Foods.FirstOrDefault(f => f.Name == foodName);
            if (foodInfo == null)
            {
                throw new Exception("Food could not be found!");
            }
            if (count <= 0)
            {
                throw new Exception("Count is below or equal to zero!");
            }

            if (count > 15)
            {
                throw new Exception("Count number too big!");
            }
            for (int i = 1; i <= count; i++)
            {
                Food foodEntity = new Food()
                {
                    Calories = foodInfo.Calories,
                    Carbohydrates = foodInfo.Carbohydrates,
                    DateAdded = DateTime.Now,
                    Fat = foodInfo.Fat,
                    Name = foodInfo.Name,
                    Protein = foodInfo.Protein,
                    UserId = userId
                };
                _db.Foods.Add(foodEntity);
            }
            _db.SaveChanges();
            return RedirectToAction("RenderMain", "Dashboard");
        }

        public List<FoodDataViewModel> GetAllUserFoods()
        {
            var user = _db.Users.FirstOrDefault(u => User.Identity.Name == u.UserName);
            List<Food> userFoods = _db.Foods.Where(f => f.UserId == user.Id).ToList();
            userFoods = userFoods.OrderByDescending(f => f.DateAdded).ToList();
            var foodData = new List<FoodDataViewModel>();
            foreach (var userFood in userFoods)
            {
                foodData.Add(new FoodDataViewModel()
                {
                    Name = userFood.Name,
                    DateAdded = userFood.DateAdded,
                    Calories = userFood.Calories,
                    Carbohydrates = userFood.Carbohydrates,
                    Fat = userFood.Fat,
                    Id = userFood.Id,
                    Protein = userFood.Protein,
                    User = userFood.User,
                    UserId = userFood.UserId
                });
            }
            return foodData;
        }

        public IActionResult CreateCustomFood(AddCustomFoodViewModel foodInputData)
        {

        }
    }
}
