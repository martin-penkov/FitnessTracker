using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.ViewModels
{
    public class PreAddedFoodViewModel
    {
        [Required] public string Name { get; set; }
        [Required] public int Number { get; set; }
    }
}
