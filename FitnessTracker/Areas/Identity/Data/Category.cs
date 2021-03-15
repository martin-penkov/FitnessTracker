using System;
using System.Collections.Generic;

#nullable disable

namespace FitnessTracker.Models
{
    public partial class Category
    {
        public Category()
        {
            Excercises = new HashSet<Excercise>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Excercise> Excercises { get; set; }
    }
}
