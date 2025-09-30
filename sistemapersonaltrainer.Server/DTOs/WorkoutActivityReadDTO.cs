namespace sistemapersonaltrainer.Server.DTOs
{
    public class WorkoutActivityReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int WorkoutId { get; set; }

        public virtual ICollection<WorkoutActivityExerciseReadDTO> WorkoutActivityExercises { get; set; } = new List<WorkoutActivityExerciseReadDTO>();
    }
}
