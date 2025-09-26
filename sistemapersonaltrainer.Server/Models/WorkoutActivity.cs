using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.Models
{
    public class WorkoutActivity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int WorkoutId { get; set; }

        public Workout? Workout { get; set; } = null;
        public virtual ICollection<WorkoutActivityExercise> WorkoutActivityExercises { get; set; } = new List<WorkoutActivityExercise>();
    }
}
