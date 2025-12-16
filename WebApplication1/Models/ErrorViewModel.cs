namespace WebApplication1.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string id {get;set;}
        public string? message {get;set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
