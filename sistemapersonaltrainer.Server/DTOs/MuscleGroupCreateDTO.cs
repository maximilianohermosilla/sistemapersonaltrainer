namespace sistemapersonaltrainer.Server.DTOs
{
    public class MuscleGroupCreateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
    }
}
