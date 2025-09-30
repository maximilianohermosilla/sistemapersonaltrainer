using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.Models
{
    public class Muscle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public virtual ICollection<Exercise> PrimeMoverExercises { get; set; } = new List<Exercise>();
        public virtual ICollection<Exercise> SecondaryMoverExercises { get; set; } = new List<Exercise>();
        public virtual ICollection<Exercise> TertiaryMoverExercises { get; set; } = new List<Exercise>();
    }
}
