using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessTracker.ViewModels
{
    public class AddCustomFoodViewModel
    {
        [Required] public string Name { get; set; }
        [Required] public int Calories { get; set; }
        [Required] public int Fat { get; set; }
        [Required] public int Protein { get; set; }
        [Required] public int Carbohydrates { get; set; }
    }
}
