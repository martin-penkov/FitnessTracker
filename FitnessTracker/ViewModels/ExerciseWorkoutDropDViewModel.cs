using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;

namespace FitnessTracker.ViewModels
{
    public class ExerciseWorkoutDropDViewModel
    {
        [Required] public List<string> uniqueExercises { get; set; }
    }
}
