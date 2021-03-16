using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitnessTracker.ViewModels
{
    public class InsightsViewModel
    {
        [Required] public double? currentDailyCalories { get; set; }

        [Required] public double? RequiredCalories { get; set; }

        [Required]
        public double? RemainingCalories
        {
            get { return RequiredCalories - currentDailyCalories; }
        }
        public List<InsightWorkoutsViewModel> userWorkouts { get; set; }
    }
}
