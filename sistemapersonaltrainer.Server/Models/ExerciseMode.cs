using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.Models
{
    public class ExerciseMode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public virtual ICollection<Exercise> ArmExercises { get; set; } = new List<Exercise>();
        public virtual ICollection<Exercise> LegExercises { get; set; } = new List<Exercise>();
    }
}
