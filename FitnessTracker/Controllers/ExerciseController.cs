using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Data;
using FitnessTracker.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitnessTracker.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly FitnessTrackerDBContext _db;
        public ExerciseController(FitnessTrackerDBContext db)
        {
            _db = db;
        }
       
        public IActionResult CreateExercise()
        {
            var dropdownData = new BodypartCategoryViewModel();
            dropdownData.BodyParts = _db.BodyParts.ToList();
            dropdownData.Category = _db.Categories.ToList();
            //var bodyparts = _db.BodyParts.ToList();
            //var categories = _db.Categories.ToList();
            //ViewBag.BodyParts = bodyparts;
            //ViewBag.Categories = categories;         
            return View(dropdownData);
        }
              
        public IActionResult CreateExerciseAction(ExerciseViewModel exerciseInput)
        {
            User user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            if (user.Id == null)
            {
                throw new Exception("No authenticated user could be found!");
            }
            Excercise newExercise = new Excercise()
            {
                Name = exerciseInput.Name,
                BodypartId = exerciseInput.BodyPartId,
                CategoryId = exerciseInput.CategoryId,
                UserId = user.Id
            };
            _db.Exercises.Add(newExercise);
            _db.SaveChanges();            
            return RedirectToAction("RenderMain", "Dashboard");
        }
    }
}
