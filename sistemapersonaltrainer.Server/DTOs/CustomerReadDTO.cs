namespace sistemapersonaltrainer.Server.DTOs
{
    public class CustomerReadDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = null;
        public string? PhoneNumber { get; set; } = null;
        public string? DocumentNumber { get; set; } = null;
        public string? Email { get; set; } = null;
        public decimal? Weight { get; set; } = null;
        public decimal? Height { get; set; } = null;
        public decimal? IMC { get; set; } = null;
    }
}
