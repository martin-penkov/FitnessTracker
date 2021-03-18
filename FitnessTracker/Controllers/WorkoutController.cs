using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Data;
using FitnessTracker.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly FitnessTrackerDBContext _db;
        public WorkoutController(FitnessTrackerDBContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult WorkoutDetails()
        {
            string name = Request.Path.Value.Split('/').LastOrDefault();
            var targetWorkout = _db.Workouts
                .Include(w => w.Exercises)
                .ThenInclude(e => e.Bodypart)
                .Include(w => w.Exercises)
                .ThenInclude(e => e.Category).FirstOrDefault(w => w.Name == name);
            
            WorkoutDetailsViewModel workout = new WorkoutDetailsViewModel()
            {
                Exercises = targetWorkout.Exercises.ToList(),
                Name = targetWorkout.Name
            };
            //{
            //    Name = w.Name,
            //    Exercises = w.Exercises.ToList()
            //}).FirstOrDefault(w => w.Name == name);


            return View("WorkoutDetails", workout);
        }

        public IActionResult CreateWorkout()
        {
            ExerciseWorkoutDropDViewModel exerciseData = new ExerciseWorkoutDropDViewModel();
            exerciseData.uniqueExercises = _db.Exercises.Select(e => e.Name).Distinct().ToList();
            return View("CreateWorkout", exerciseData);
        }

        public IActionResult CreateWorkoutAction(WorkoutDataViewModel inputWorkoutData)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            Workout workoutAdd = new Workout()
            {
                Name = inputWorkoutData.Name,
                UserId = user.Id,
            };
            var exerciseList = new List<Excercise>();
            foreach (var exercise in inputWorkoutData.ExerciseNames)
            {
                var exerciseFind = _db.Exercises.FirstOrDefault(e => e.Name == exercise);
                if (exerciseFind == null)
                { throw new Exception("No exercise with such name could be found!"); }
                exerciseList.Add(exerciseFind);
            }

            workoutAdd.Exercises = exerciseList;
            _db.Workouts.Add(workoutAdd);
            _db.SaveChanges();
            return RedirectToAction("RenderMain", "Dashboard");
        }
    }
}
