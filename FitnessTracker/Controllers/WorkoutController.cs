using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Data;

namespace FitnessTracker.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly FitnessTrackerDBContext _db;
        public WorkoutController(FitnessTrackerDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult CreateWorkout()
        //{

        //}
    }
}
