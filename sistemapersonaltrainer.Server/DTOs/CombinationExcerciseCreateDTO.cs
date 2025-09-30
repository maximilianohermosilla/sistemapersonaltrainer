using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.DTOs
{
    public class CombinationExcerciseCreateDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
    }
}
