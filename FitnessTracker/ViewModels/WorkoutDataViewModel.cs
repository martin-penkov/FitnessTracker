using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.ViewModels
{
    public class WorkoutDataViewModel
    {
        [Required] public string Name { get; set; }
        [Required] public List<string> ExerciseNames { get; set; }
    }
}
