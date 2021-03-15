using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace FitnessTracker.Models
{
    public partial class User : IdentityUser
    {
        public User()
        {
            Excercises = new HashSet<Excercise>();
            Foods = new HashSet<Food>();
        }
        
        public string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public string LastName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public int Age { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public int Weight { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public int Height { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public string Gender { get; set; }


        public virtual ICollection<Excercise> Excercises { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
