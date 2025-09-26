using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.Models
{
    public class Laterality
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public virtual ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}
