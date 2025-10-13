namespace sistemapersonaltrainer.Server.DTOs
{
    public class WorkoutReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = null!;
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public CustomerReadDTO? Customer { get; set; } = null;
        public UserReadDTO? User { get; set; } = null;
        public virtual ICollection<WorkoutActivityReadDTO> WorkoutActivities { get; set; } = new List<WorkoutActivityReadDTO>();
    }
}
