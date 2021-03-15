using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;

namespace FitnessTracker.ViewModels
{
    public class CreateFoodViewModel
    {
        [Required] public List<Food> allFoods { get; set; }
        [Required] public List<string> uniqueFoods { get; set; }
    }
}
