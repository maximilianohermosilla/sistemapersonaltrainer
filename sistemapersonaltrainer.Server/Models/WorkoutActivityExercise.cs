using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.Models
{
    public class WorkoutActivityExercise
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int WorkoutActivityId { get; set; }
        public int? ExerciseId { get; set; }
        public int? Series { get; set; } = null!;
        public int? Repetitions { get; set; } = null!;
        public int? RestMinutes{ get; set; } = null!;
        public string? ShortVideo { get; set; } = null!;
        public string? LongVideo { get; set; } = null!;

        public WorkoutActivity? WorkoutActivity { get; set; } = null;
        public Exercise? Exercise { get; set; } = null;
    }
}
