namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public int id {get;set;}
        public string? message {get;set; }
        public string? lala { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
