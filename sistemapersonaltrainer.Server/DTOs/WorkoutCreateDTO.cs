namespace sistemapersonaltrainer.Server.DTOs
{
    public class WorkoutCreateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = null!;
        public int CustomerId { get; set; }
        public int? UserId { get; set; }

        public CustomerReadDTO? Customer { get; set; } = null;
        public virtual ICollection<WorkoutActivityCreateDTO> WorkoutActivities { get; set; } = new List<WorkoutActivityCreateDTO>();
    }
}
