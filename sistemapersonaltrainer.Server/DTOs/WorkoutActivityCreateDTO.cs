namespace sistemapersonaltrainer.Server.DTOs
{
    public class WorkoutActivityCreateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public int WorkoutId { get; set; }

        public virtual ICollection<WorkoutActivityExerciseCreateDTO> WorkoutActivityExercises { get; set; } = new List<WorkoutActivityExerciseCreateDTO>();
    }
}
