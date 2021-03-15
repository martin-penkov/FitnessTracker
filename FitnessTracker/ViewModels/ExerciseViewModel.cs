using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.ViewModels
{
    public class ExerciseViewModel
    {
        [Required] public string Name { get; set; }
        [Required] public int BodyPartId { get; set; }
        [Required] public int CategoryId { get; set; }
    }
}
