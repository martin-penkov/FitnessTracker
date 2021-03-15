using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;

namespace FitnessTracker.ViewModels
{
    public class FoodHistoryViewModel
    {
        [Required] public List<FoodDataViewModel> foods { get; set; }
        
    }
}
