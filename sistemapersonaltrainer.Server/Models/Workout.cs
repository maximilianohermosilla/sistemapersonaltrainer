using System.ComponentModel.DataAnnotations;

namespace sistemapersonaltrainer.Server.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = null!;
        public int CustomerId { get; set; }
        public int UserId { get; set; }

        public Customer? Customer { get; set; } = null;
        public User? User { get; set; } = null;
        public virtual ICollection<WorkoutActivity> WorkoutActivities { get; set; } = new List<WorkoutActivity>();
    }
}
