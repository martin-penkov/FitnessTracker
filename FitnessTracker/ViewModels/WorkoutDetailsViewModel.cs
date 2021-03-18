using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;

namespace FitnessTracker.ViewModels
{
    public class WorkoutDetailsViewModel
    {
        [Required] public string Name { get; set; }
        [Required] public List<Excercise> Exercises { get; set; }
    }
}
