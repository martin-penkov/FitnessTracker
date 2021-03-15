using System;
using System.Collections.Generic;

#nullable disable

namespace FitnessTracker.Models
{
    public partial class Excercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? UserId { get; set; }
        public int? BodypartId { get; set; }
        public int? CategoryId { get; set; }

        public virtual BodyPart Bodypart { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}
