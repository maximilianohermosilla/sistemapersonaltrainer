namespace sistemapersonaltrainer.Server.DTOs
{
    public class WorkoutActivityExerciseCreateDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int WorkoutActivityId { get; set; }
        public int ExerciseId { get; set; }
        public int? Series { get; set; } = null!;
        public int? Repetitions { get; set; } = null!;
        public int? RestMinutes{ get; set; } = null!;
    }
}
