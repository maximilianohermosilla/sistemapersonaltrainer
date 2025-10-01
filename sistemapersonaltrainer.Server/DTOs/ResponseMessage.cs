namespace sistemapersonaltrainer.Server.DTOs
{
    public class ResponseMessage
    {
        public string Message { get; set; } = string.Empty;
        public Object? Data { get; set; } = null;
        public bool? Success { get; set; } = null;
    }
}
