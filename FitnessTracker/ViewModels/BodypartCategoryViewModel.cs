using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FitnessTracker.ViewModels
{
    public class BodypartCategoryViewModel
    {
        [Required]
        public List<BodyPart> BodyParts { get; set; }
        [Required]
        public List<Category> Category { get; set; }
        
    }
}
